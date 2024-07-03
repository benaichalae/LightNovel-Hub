using System;
using System.IO;
using System.Windows.Forms;

namespace LightNovelHub.Forms
{
    public partial class FormBrowser : Form
    {
        private Form2 parentForm;

        public FormBrowser(Form2 parent)
        {
            InitializeComponent();
            parentForm = parent;

            // Enable drag-and-drop functionality
            this.AllowDrop = true;
            this.DragEnter += FormBrowser_DragEnter;
            this.DragDrop += FormBrowser_DragDrop;
        }

        private void FormBrowser_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.FileDrop) == true)
            {
                // Check if the dropped files are ePub files
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    if (Path.GetExtension(file).Equals(".epub", StringComparison.OrdinalIgnoreCase))
                    {
                        e.Effect = DragDropEffects.Copy;
                        return; // Exit after setting the effect to Copy
                    }
                }
            }

            // If no ePub files were found, set the effect to None (disable drop)
            e.Effect = DragDropEffects.None;
        }

        private void FormBrowser_DragDrop(object? sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.FileDrop) == true)
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string file in files)
                {
                    // Check if it's an ePub file (optional, since it's already checked in DragEnter)
                    if (Path.GetExtension(file).Equals(".epub", StringComparison.OrdinalIgnoreCase))
                    {
                        // Define your target folder
                        string targetFolder = @"C:\Users\benai\source\repos\LightNovelHub\LightNovelHub\ePub";

                        // Construct a unique file name if necessary
                        string fileName = Path.GetFileName(file);
                        string destFilePath = Path.Combine(targetFolder, fileName);

                        // Copy the file to the target folder
                        File.Copy(file, destFilePath, true); // Set overwrite to true if needed
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Implement logic for when selected index changes
            // For example, get selected item:
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                // Example: Display selected item text
                MessageBox.Show(selectedItem.Text);
            }
        }
    }
}
