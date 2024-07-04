namespace LightNovelHub.Forms
{
    partial class EpubReaderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            webBrowser1 = new WebBrowser();
            btnNextChapter = new Button();
            btnPreviousChapter = new Button();
            SuspendLayout();
            // 
            // webBrowser1
            // 
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.Location = new Point(0, 0);
            webBrowser1.MinimumSize = new Size(20, 20);
            webBrowser1.Name = "webBrowser1";
            webBrowser1.Size = new Size(800, 450);
            webBrowser1.TabIndex = 0;
            // 
            // btnNextChapter
            // 
            btnNextChapter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNextChapter.Location = new Point(698, 410);
            btnNextChapter.Name = "btnNextChapter";
            btnNextChapter.Size = new Size(75, 23);
            btnNextChapter.TabIndex = 1;
            btnNextChapter.Text = "Next";
            btnNextChapter.UseVisualStyleBackColor = true;
            btnNextChapter.Click += btnNextChapter_Click;
            // 
            // btnPreviousChapter
            // 
            btnPreviousChapter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPreviousChapter.Location = new Point(12, 410);
            btnPreviousChapter.Name = "btnPreviousChapter";
            btnPreviousChapter.Size = new Size(75, 23);
            btnPreviousChapter.TabIndex = 2;
            btnPreviousChapter.Text = "Previous";
            btnPreviousChapter.UseVisualStyleBackColor = true;
            btnPreviousChapter.Click += btnPreviousChapter_Click;
            // 
            // EpubReaderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 66, 102);
            ClientSize = new Size(800, 450);
            Controls.Add(btnPreviousChapter);
            Controls.Add(btnNextChapter);
            Controls.Add(webBrowser1);
            Name = "EpubReaderForm";
            Text = "EpubReaderForm";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnNextChapter;
        private System.Windows.Forms.Button btnPreviousChapter;
    }
}
