using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace LightNovelHub.Forms
{
    public partial class FormBrowser : Form
    {
        public FormBrowser()
        {
            InitializeComponent();
        }

        private async void btnDownloadNovel_Click(object sender, EventArgs e)
        {
            string baseUrl = "https://boxnovel.com/novel";
            string novelName = search.Text.Trim().Replace(" ", "-").ToLower();
            string novelUrl = $"{baseUrl}/{novelName}"; // Construct the novel URL

            await DownloadLightNovel(novelUrl);
        }

        private async Task DownloadLightNovel(string url)
        {
            using HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string pageContent = await response.Content.ReadAsStringAsync();

                HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                document.LoadHtml(pageContent);

                // Extract novel title
                var titleNode = document.DocumentNode.SelectSingleNode("//h1[@class='entry-title']");
                string title = titleNode?.InnerText.Trim();
                if (string.IsNullOrEmpty(title))
                {
                    title = "Unknown Title";
                }
                MessageBox.Show($"Title: {title}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Extract chapter links
                var chapterNodes = document.DocumentNode.SelectNodes("//ul[@class='main version-chap']//li/a");
                if (chapterNodes != null)
                {
                    foreach (var chapterNode in chapterNodes)
                    {
                        string chapterTitle = chapterNode.InnerText.Trim();
                        string chapterLink = "https://boxnovel.com" + chapterNode.GetAttributeValue("href", "");
                        MessageBox.Show($"Downloading {chapterTitle} from {chapterLink}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await DownloadChapter(chapterLink);
                    }
                }
                else
                {
                    MessageBox.Show("No chapters found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"HTTP Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task DownloadChapter(string url)
        {
            using HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string pageContent = await response.Content.ReadAsStringAsync();

                HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                document.LoadHtml(pageContent);

                // Extract chapter content
                var contentNode = document.DocumentNode.SelectSingleNode("//div[@class='cha-words']");
                string content = contentNode?.InnerHtml ?? "No content";

                // Save chapter content to file
                var titleNode = document.DocumentNode.SelectSingleNode("//h1[@class='entry-title']");
                string chapterTitle = titleNode?.InnerText.Trim() ?? "Unknown Chapter";
                string fileName = $"{chapterTitle}.html";
                await System.IO.File.WriteAllTextAsync(fileName, content);
                MessageBox.Show($"Saved {chapterTitle} to {fileName}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"HTTP Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            // Optional: You can add functionality here if needed
        }
    }
}
