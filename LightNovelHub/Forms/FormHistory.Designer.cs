namespace LightNovelHub.Forms
{
    partial class FormHistory
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
            historyPanel = new Panel();
            SuspendLayout();
            // 
            // historyPanel
            // 
            historyPanel.AutoScroll = true;
            historyPanel.BackColor = Color.FromArgb(26, 27, 32);
            historyPanel.Dock = DockStyle.Fill;
            historyPanel.Location = new Point(0, 0);
            historyPanel.Name = "historyPanel";
            historyPanel.Size = new Size(800, 450);
            historyPanel.TabIndex = 0;
            // 
            // FormHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 66, 102);
            ClientSize = new Size(800, 450);
            Controls.Add(historyPanel);
            Name = "FormHistory";
            Text = "Reading History";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel historyPanel;
    }
}
