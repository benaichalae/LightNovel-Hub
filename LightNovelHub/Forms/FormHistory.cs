using System;
using System.Linq;
using System.Windows.Forms;

namespace LightNovelHub.Forms
{
    public partial class FormHistory : Form
    {
        private Form2 parentForm;

        public FormHistory(Form2 parent)
        {
            InitializeComponent();
            this.parentForm = parent;
            LoadHistory();
        }

        private void LoadHistory()
        {
            var readingHistory = EpubReaderForm.ReadingHistory;
            // Sort the reading history by LastReadChapter in descending order
            var sortedHistory = readingHistory.OrderByDescending(entry => entry.LastReadChapter).ToList();

            foreach (var entry in sortedHistory)
            {
                var panel = new TableLayoutPanel
                {
                    Height = 100,
                    Dock = DockStyle.Top,
                    Padding = new Padding(10),
                    ColumnCount = 2,
                    RowCount = 1,
                    AutoSize = true,
                    Margin = new Padding(10)
                };

                var coverPictureBox = new PictureBox
                {
                    Image = entry.CoverImage,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 80,
                    Height = 100,
                    Dock = DockStyle.Fill,
                    Margin = new Padding(10)
                };
                coverPictureBox.DoubleClick += (s, e) => OpenEpubReaderForm(entry);
                panel.Controls.Add(coverPictureBox, 0, 0);

                var infoPanel = new Panel { Dock = DockStyle.Fill, Margin = new Padding(10) };

                var titleLabel = new Label
                {
                    Text = entry.Title,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 11.25F),
                    Dock = DockStyle.Top,
                    Height = 20
                };
                infoPanel.Controls.Add(titleLabel);

                var chapterLabel = new Label
                {
                    Text = $"Last read chapter: {entry.LastReadChapter + 1}",
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 11.25F),
                    Dock = DockStyle.Top,
                    Height = 20
                };
                infoPanel.Controls.Add(chapterLabel);

                panel.Controls.Add(infoPanel, 1, 0);

                panel.Tag = entry;
                panel.DoubleClick += (s, e) => OpenEpubReaderForm(entry);

                historyPanel.Controls.Add(panel);
            }
        }

        private void OpenEpubReaderForm(ReadingHistoryEntry entry)
        {
            var epubReaderForm = new EpubReaderForm(entry.FilePath, entry.LastReadChapter);
            parentForm.OpenChildForm(epubReaderForm, this);
        }
    }
}
