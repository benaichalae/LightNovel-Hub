namespace LightNovelHub
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panelMenu = new Panel();
            btnAboutUs = new Button();
            btnSetting = new Button();
            btnHistory = new Button();
            btnBrowser = new Button();
            btnProfile = new Button();
            panel1 = new Panel();
            panelLibrary = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(26, 27, 32);
            panelMenu.Controls.Add(btnAboutUs);
            panelMenu.Controls.Add(btnSetting);
            panelMenu.Controls.Add(btnHistory);
            panelMenu.Controls.Add(btnBrowser);
            panelMenu.Controls.Add(btnProfile);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 531);
            panelMenu.TabIndex = 0;
            // 
            // btnAboutUs
            // 
            btnAboutUs.BackColor = Color.FromArgb(26, 27, 32);
            btnAboutUs.Dock = DockStyle.Top;
            btnAboutUs.FlatAppearance.BorderSize = 0;
            btnAboutUs.FlatStyle = FlatStyle.Flat;
            btnAboutUs.Font = new Font("Segoe UI", 11.25F);
            btnAboutUs.ForeColor = Color.White;
            btnAboutUs.Image = (Image)resources.GetObject("btnAboutUs.Image");
            btnAboutUs.ImageAlign = ContentAlignment.MiddleLeft;
            btnAboutUs.Location = new Point(0, 360);
            btnAboutUs.Name = "btnAboutUs";
            btnAboutUs.Padding = new Padding(12, 0, 0, 0);
            btnAboutUs.Size = new Size(220, 70);
            btnAboutUs.TabIndex = 5;
            btnAboutUs.Text = "   About Us";
            btnAboutUs.TextAlign = ContentAlignment.MiddleLeft;
            btnAboutUs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAboutUs.UseVisualStyleBackColor = false;
            btnAboutUs.Click += btnAboutUs_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.FromArgb(26, 27, 32);
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Segoe UI", 11.25F);
            btnSetting.ForeColor = Color.White;
            btnSetting.Image = (Image)resources.GetObject("btnSetting.Image");
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 290);
            btnSetting.Name = "btnSetting";
            btnSetting.Padding = new Padding(12, 0, 0, 0);
            btnSetting.Size = new Size(220, 70);
            btnSetting.TabIndex = 4;
            btnSetting.Text = "   Profile";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnProfile_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.FromArgb(26, 27, 32);
            btnHistory.Dock = DockStyle.Top;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 11.25F);
            btnHistory.ForeColor = Color.White;
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(0, 220);
            btnHistory.Name = "btnHistory";
            btnHistory.Padding = new Padding(12, 0, 0, 0);
            btnHistory.Size = new Size(220, 70);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "   History";
            btnHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnBrowser
            // 
            btnBrowser.BackColor = Color.FromArgb(26, 27, 32);
            btnBrowser.Dock = DockStyle.Top;
            btnBrowser.FlatAppearance.BorderSize = 0;
            btnBrowser.FlatStyle = FlatStyle.Flat;
            btnBrowser.Font = new Font("Segoe UI", 11.25F);
            btnBrowser.ForeColor = Color.White;
            btnBrowser.Image = (Image)resources.GetObject("btnBrowser.Image");
            btnBrowser.ImageAlign = ContentAlignment.MiddleLeft;
            btnBrowser.Location = new Point(0, 150);
            btnBrowser.Name = "btnBrowser";
            btnBrowser.Padding = new Padding(12, 0, 0, 0);
            btnBrowser.Size = new Size(220, 70);
            btnBrowser.TabIndex = 2;
            btnBrowser.Text = "  Add More";
            btnBrowser.TextAlign = ContentAlignment.MiddleLeft;
            btnBrowser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBrowser.UseVisualStyleBackColor = false;
            btnBrowser.Click += btnBrowser_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(26, 27, 32);
            btnProfile.Dock = DockStyle.Top;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 11.25F);
            btnProfile.ForeColor = Color.White;
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(0, 80);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(12, 0, 0, 0);
            btnProfile.Size = new Size(220, 70);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "   Library";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnLibrary_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 80);
            panel1.TabIndex = 0;
            // 
            // panelLibrary
            // 
            panelLibrary.BackColor = Color.FromArgb(26, 27, 32);
            panelLibrary.BorderStyle = BorderStyle.FixedSingle;
            panelLibrary.Controls.Add(pictureBox1);
            panelLibrary.Dock = DockStyle.Fill;
            panelLibrary.Location = new Point(220, 0);
            panelLibrary.Name = "panelLibrary";
            panelLibrary.Size = new Size(648, 531);
            panelLibrary.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(98, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(444, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(868, 531);
            Controls.Add(panelLibrary);
            Controls.Add(panelMenu);
            MinimumSize = new Size(240, 470);
            Name = "Form2";
            Text = "LightNovel Hub";
            panelMenu.ResumeLayout(false);
            panelLibrary.ResumeLayout(false);
            panelLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private Button btnProfile;
        private Button btnHistory;
        private Button btnBrowser;
        private Button btnAboutUs;
        private Button btnSetting;
        private Panel panelLibrary;
        private PictureBox pictureBox1;
    }
}