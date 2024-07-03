namespace LightNovelHub.Forms
{
    partial class FormBrowser
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
            btnDownloadNovel = new Button();
            search = new TextBox();
            SuspendLayout();
            // 
            // btnDownloadNovel
            // 
            btnDownloadNovel.Location = new Point(122, 139);
            btnDownloadNovel.Name = "btnDownloadNovel";
            btnDownloadNovel.Size = new Size(535, 77);
            btnDownloadNovel.TabIndex = 0;
            btnDownloadNovel.Text = "DownloadNovel";
            btnDownloadNovel.UseVisualStyleBackColor = true;
            btnDownloadNovel.Click += btnDownloadNovel_Click;
            // 
            // search
            // 
            search.Location = new Point(145, 53);
            search.Name = "search";
            search.Size = new Size(487, 23);
            search.TabIndex = 1;
            search.TextChanged += search_TextChanged;
            // 
            // FormBrowser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 61, 91);
            ClientSize = new Size(800, 450);
            Controls.Add(search);
            Controls.Add(btnDownloadNovel);
            Name = "FormBrowser";
            Text = "FormBrowser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDownloadNovel;
        private TextBox search;
    }
}