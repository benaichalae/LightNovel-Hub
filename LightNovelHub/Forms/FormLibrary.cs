using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VersOne.Epub;

namespace LightNovelHub.Forms
{
    public partial class FormLibrary : Form
    {
        private const string epubFolderPath = @"C:\Users\benai\source\repos\LightNovelHub\LightNovelHub\ePub";
        private RoundedButton? refreshButton;
        private Dictionary<string, int> lastReadChapters = new Dictionary<string, int>();
        private Form2 parentForm;

        public FormLibrary(Form2 parent)
        {
            InitializeComponent();
            parentForm = parent;
            // Add the Load event handler
            this.Load += FormLibrary_Load;
        }

        private void FormLibrary_Load(object? sender, EventArgs e)
        {
            // Load EPUB covers on form load
            LoadEpubCovers(epubFolderPath);
            // Add a refresh button to the panel
            AddRefreshButton();
        }

        private void AddRefreshButton()
        {
            refreshButton = new RoundedButton
            {
                Text = "Refresh",
                Width = 150,
                Height = 50,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                ForeColor = Color.White // Set text color to white for better contrast
            };

            refreshButton.Click += RefreshButton_Click;
            panelRefreshButton.Controls.Add(refreshButton);
            PositionRefreshButton();
        }

        private void RefreshButton_Click(object? sender, EventArgs e)
        {
            LoadEpubCovers(epubFolderPath);
        }

        private void LoadEpubCovers(string folderPath)
        {
            // Clear any existing controls
            flowLayoutPanel1.Controls.Clear();

            // Set padding for the FlowLayoutPanel
            flowLayoutPanel1.Padding = new Padding(10); // Add some padding to the FlowLayoutPanel

            // Get all EPUB files in the folder
            var epubFiles = Directory.GetFiles(folderPath, "*.epub");

            foreach (var epubFile in epubFiles)
            {
                try
                {
                    // Load the EPUB book
                    EpubBook book = EpubReader.ReadBook(epubFile);
                    Image? coverImage = GetCoverImage(book);

                    if (coverImage != null)
                    {
                        // Create a PictureBox for the cover image
                        PictureBox pictureBox = new PictureBox
                        {
                            Image = coverImage,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Width = 150,
                            Height = 200,
                            BorderStyle = BorderStyle.FixedSingle, // Add a border to the PictureBox
                            Margin = new Padding(10), // Add margin to create space between pictures
                            Tag = epubFile // Store the file path in the Tag property
                        };

                        // Attach double-click event handler
                        pictureBox.DoubleClick += PictureBox_DoubleClick;

                        // Add PictureBox to the FlowLayoutPanel
                        flowLayoutPanel1.Controls.Add(pictureBox);
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., invalid EPUB file)
                    MessageBox.Show($"Failed to load {epubFile}: {ex.Message}");
                }
            }
        }

        private Image? GetCoverImage(EpubBook book)
        {
            if (book.CoverImage != null)
            {
                using (var ms = new MemoryStream(book.CoverImage))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }

        private void PictureBox_DoubleClick(object? sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                string? epubFile = pictureBox.Tag as string;
                if (epubFile != null)
                {
                    int lastReadChapter = 0;
                    if (lastReadChapters.ContainsKey(epubFile))
                    {
                        lastReadChapter = lastReadChapters[epubFile];
                    }

                    parentForm.OpenChildForm(new EpubReaderForm(epubFile, lastReadChapter), this); // Pass 'this' instead of null
                }
            }
        }

        private void PositionRefreshButton()
        {
            if (refreshButton != null)
            {
                refreshButton.Location = new Point(panelRefreshButton.ClientSize.Width - refreshButton.Width - 10,
                                                   panelRefreshButton.ClientSize.Height - refreshButton.Height - 10);
                refreshButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Custom paint logic if needed
        }
    }
}
