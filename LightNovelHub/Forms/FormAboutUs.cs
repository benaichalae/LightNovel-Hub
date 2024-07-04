using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LightNovelHub.Forms
{
    public partial class FormAboutUs : Form
    {
        private Form2 parentForm;

        public FormAboutUs(Form2 parent)
        {
            InitializeComponent();
            parentForm = parent;
            InitializeLinkLabels();
        }

        private void InitializeLinkLabels()
        {
            Twitter.Tag = "https://twitter.com/AlaeBenaicha";
            Gmail.Tag = "mailto:benaichalae@gmail.com";
            Github.Tag = "https://github.com/benaichalae";
            LinkedIn.Tag = "https://www.linkedin.com/in/alae-ben-aicha-140129187/";

            Twitter.LinkClicked += OpenLink!;
            Gmail.LinkClicked += OpenLink!;
            Github.LinkClicked += OpenLink!;
            LinkedIn.LinkClicked += OpenLink!;
        }

        private void OpenLink(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            if (sender is LinkLabel linkLabel && linkLabel.Tag is string url && !string.IsNullOrEmpty(url))
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
        }
    }
}
