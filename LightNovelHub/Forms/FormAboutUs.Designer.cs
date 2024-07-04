namespace LightNovelHub.Forms
{
    partial class FormAboutUs
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblIntroduction;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutUs));
            lblIntroduction = new Label();
            Twitter = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Github = new LinkLabel();
            pictureBox3 = new PictureBox();
            LinkedIn = new LinkLabel();
            pictureBox4 = new PictureBox();
            Gmail = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblIntroduction
            // 
            lblIntroduction.Anchor = AnchorStyles.Top;
            lblIntroduction.AutoSize = true;
            lblIntroduction.Font = new Font("Segoe Script", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblIntroduction.ForeColor = Color.FromArgb(2, 39, 59);
            lblIntroduction.Location = new Point(17, 23);
            lblIntroduction.MaximumSize = new Size(360, 0);
            lblIntroduction.Name = "lblIntroduction";
            lblIntroduction.Size = new Size(354, 100);
            lblIntroduction.TabIndex = 0;
            lblIntroduction.Text = "Hi, I'm benaichalae. I created this software to provide a seamless experience for reading and managing light novels, I hope you like it.";
            lblIntroduction.TextAlign = ContentAlignment.TopCenter;
            // 
            // Twitter
            // 
            Twitter.Anchor = AnchorStyles.Bottom;
            Twitter.AutoSize = true;
            Twitter.Location = new Point(38, 380);
            Twitter.Name = "Twitter";
            Twitter.Size = new Size(42, 15);
            Twitter.TabIndex = 1;
            Twitter.TabStop = true;
            Twitter.Text = "Twitter";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(28, 313);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(121, 313);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Github
            // 
            Github.Anchor = AnchorStyles.Bottom;
            Github.AutoSize = true;
            Github.Location = new Point(131, 380);
            Github.Name = "Github";
            Github.Size = new Size(43, 15);
            Github.TabIndex = 3;
            Github.TabStop = true;
            Github.Text = "Github";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(214, 313);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // LinkedIn
            // 
            LinkedIn.Anchor = AnchorStyles.Bottom;
            LinkedIn.AutoSize = true;
            LinkedIn.Location = new Point(219, 380);
            LinkedIn.Name = "LinkedIn";
            LinkedIn.Size = new Size(52, 15);
            LinkedIn.TabIndex = 5;
            LinkedIn.TabStop = true;
            LinkedIn.Text = "LinkedIn";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Location = new Point(307, 313);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(62, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // Gmail
            // 
            Gmail.Anchor = AnchorStyles.Bottom;
            Gmail.AutoSize = true;
            Gmail.Location = new Point(319, 380);
            Gmail.Name = "Gmail";
            Gmail.Size = new Size(38, 15);
            Gmail.TabIndex = 7;
            Gmail.TabStop = true;
            Gmail.Text = "Gmail";
            // 
            // FormAboutUs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 61, 91);
            ClientSize = new Size(400, 404);
            Controls.Add(pictureBox4);
            Controls.Add(Gmail);
            Controls.Add(pictureBox3);
            Controls.Add(LinkedIn);
            Controls.Add(pictureBox2);
            Controls.Add(Github);
            Controls.Add(pictureBox1);
            Controls.Add(Twitter);
            Controls.Add(lblIntroduction);
            MinimumSize = new Size(416, 389);
            Name = "FormAboutUs";
            Text = "About Us";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private LinkLabel Twitter;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private LinkLabel Github;
        private PictureBox pictureBox3;
        private LinkLabel LinkedIn;
        private PictureBox pictureBox4;
        private LinkLabel Gmail;
    }
}
