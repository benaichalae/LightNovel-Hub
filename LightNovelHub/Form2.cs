using System;
using System.Drawing;
using System.Windows.Forms;

namespace LightNovelHub
{
    public partial class Form2 : Form
    {
        private Button? currentButton;
        private Random random;
        private int tempIndex;
        private Form? activeForm;

        public Form2()
        {
            InitializeComponent();
            random = new Random();
            currentButton = null;
            activeForm = null;
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object? btnSender)
        {
            if (btnSender is Button button)
            {
                if (currentButton != button)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = button;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn is Button)
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
                }
            }
        }

        public void OpenChildForm(Form childForm, object? btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelLibrary.Controls.Add(childForm);
            panelLibrary.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLibrary(this), sender);
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBrowser(this), sender);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHistory(this), sender);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProfile(this), sender);
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAboutUs(this), sender);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Paint event handler (if needed)
        }

        private void panelLibrary_Paint(object sender, PaintEventArgs e)
        {
            // Paint event handler for panelLibrary (if needed)
        }
    }
}
