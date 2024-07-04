using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VersOne.Epub;

namespace LightNovelHub.Forms
{
    public partial class EpubReaderForm : Form
    {
        private EpubBook epubBook;
        private int currentChapterIndex;
        private string epubFile;
        private static List<ReadingHistoryEntry> readingHistory = new List<ReadingHistoryEntry>();

        public static List<ReadingHistoryEntry> ReadingHistory => readingHistory;

        public int CurrentChapterIndex => currentChapterIndex;

        public EpubReaderForm(string epubFile, int startChapterIndex)
        {
            InitializeComponent();
            this.epubFile = epubFile;
            epubBook = EpubReader.ReadBook(epubFile);
            currentChapterIndex = startChapterIndex;
            LoadChapter(currentChapterIndex);
        }

        private void LoadChapter(int chapterIndex)
        {
            if (chapterIndex < 0 || chapterIndex >= epubBook.ReadingOrder.Count)
            {
                MessageBox.Show("Invalid chapter index");
                return;
            }

            var chapter = epubBook.ReadingOrder[chapterIndex];
            string content = chapter.Content;
            string htmlContent = $@"
                <html>
                <head>
                    <style>
                        body {{
                            background-color: rgb(26, 27, 32);
                            font-family: 'Segoe UI';
                            font-size: 11.25pt;
                            color: white;
                        }}
                    </style>
                </head>
                <body>
                    {content}
                </body>
                </html>";
            webBrowser1.DocumentText = htmlContent;
            this.Text = $"{epubBook.Title} - Chapter {chapterIndex + 1}";

            UpdateReadingHistory();
        }

        private void UpdateReadingHistory()
        {
            var coverImage = GetCoverImage(epubBook);
            var existingEntry = readingHistory.FirstOrDefault(h => h.FilePath == epubFile);

            if (existingEntry != null)
            {
                readingHistory.Remove(existingEntry);
            }

            readingHistory.Insert(0, new ReadingHistoryEntry
            {
                FilePath = epubFile,
                LastReadChapter = currentChapterIndex,
                CoverImage = coverImage,
                Title = epubBook.Title ?? string.Empty
            });
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

        private void btnNextChapter_Click(object sender, EventArgs e)
        {
            if (currentChapterIndex < epubBook.ReadingOrder.Count - 1)
            {
                currentChapterIndex++;
                LoadChapter(currentChapterIndex);
            }
        }

        private void btnPreviousChapter_Click(object sender, EventArgs e)
        {
            if (currentChapterIndex > 0)
            {
                currentChapterIndex--;
                LoadChapter(currentChapterIndex);
            }
        }
    }
}
