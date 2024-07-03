using System;
using System.Linq;
using System.Windows.Forms;

namespace LightNovelHub.Forms
{
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
            LoadHistory();
        }

        private void LoadHistory()
        {
            var readingHistory = EpubReaderForm.ReadingHistory;
            foreach (var entry in readingHistory)
            {
                var panel = new Panel { Height = 100, Dock = DockStyle.Top, Padding = new Padding(10), Margin = new Padding(10) };

                var coverPictureBox = new PictureBox
                {
                    Image = entry.CoverImage,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 80,
                    Height = 100,
                    Dock = DockStyle.Left,
                    Margin = new Padding(10)
                };
                panel.Controls.Add(coverPictureBox);

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

                panel.Controls.Add(infoPanel);

                panel.Tag = entry;
                panel.DoubleClick += Panel_DoubleClick;

                historyPanel.Controls.Add(panel);
            }
        }

        private void Panel_DoubleClick(object? sender, EventArgs e)
        {
            if (sender is Panel panel)
            {
                if (panel.Tag is ReadingHistoryEntry entry)
                {
                    var epubReaderForm = new EpubReaderForm(entry.FilePath, entry.LastReadChapter);
                    epubReaderForm.Show();
                }
            }
        }
    }
}
