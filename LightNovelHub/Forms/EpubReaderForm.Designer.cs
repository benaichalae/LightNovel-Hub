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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnNextChapter = new System.Windows.Forms.Button();
            this.btnPreviousChapter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 400);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnNextChapter
            // 
            this.btnNextChapter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextChapter.Location = new System.Drawing.Point(713, 410);
            this.btnNextChapter.Name = "btnNextChapter";
            this.btnNextChapter.Size = new System.Drawing.Size(75, 23);
            this.btnNextChapter.TabIndex = 1;
            this.btnNextChapter.Text = "Next";
            this.btnNextChapter.UseVisualStyleBackColor = true;
            this.btnNextChapter.Click += new System.EventHandler(this.btnNextChapter_Click);
            // 
            // btnPreviousChapter
            // 
            this.btnPreviousChapter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPreviousChapter.Location = new System.Drawing.Point(12, 410);
            this.btnPreviousChapter.Name = "btnPreviousChapter";
            this.btnPreviousChapter.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousChapter.TabIndex = 2;
            this.btnPreviousChapter.Text = "Previous";
            this.btnPreviousChapter.UseVisualStyleBackColor = true;
            this.btnPreviousChapter.Click += new System.EventHandler(this.btnPreviousChapter_Click);
            // 
            // EpubReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(65, 66, 102);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPreviousChapter);
            this.Controls.Add(this.btnNextChapter);
            this.Controls.Add(this.webBrowser1);
            this.Name = "EpubReaderForm";
            this.Text = "EpubReaderForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnNextChapter;
        private System.Windows.Forms.Button btnPreviousChapter;
    }
}
