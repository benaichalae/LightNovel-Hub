namespace LightNovelHub
{
    public partial class Form2 : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Form2()
        {
            InitializeComponent();
            random = new Random();
        }

        //Methods
        private Color Selectthemecolor()
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

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Selectthemecolor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
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
            this.panelLibrary.Controls.Add(childForm);
            this.panelLibrary.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLibrary(), sender);
        }

        private void btnrowser_click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBrowser(), sender);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHistory(), sender);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProfile(), sender);
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAboutUs(), sender);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLibrary_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
