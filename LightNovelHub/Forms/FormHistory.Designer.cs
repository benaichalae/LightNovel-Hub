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
            this.historyPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // historyPanel
            // 
            this.historyPanel.AutoScroll = true;
            this.historyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyPanel.Location = new System.Drawing.Point(0, 0);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(800, 450);
            this.historyPanel.TabIndex = 0;
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(65, 66, 102);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.historyPanel);
            this.Name = "FormHistory";
            this.Text = "Reading History";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel historyPanel;
    }
}
