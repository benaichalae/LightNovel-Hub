using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LightNovelHub
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.AcceptButton = button2;
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Apply rounded corners
            int radius = 30; // Adjust the radius as needed
            IntPtr hRgn = CreateRoundRectRgn(0, 0, this.Width, this.Height, radius, radius);
            SetWindowRgn(this.Handle, hRgn, true);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Check username and password
            if (username == "benaichalae" && password == "Hydra1996")
            {
                // Login successful, open new form and hide current form
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide(); // Use Hide() instead of Close() to keep the application running
            }
            else
            {
                // Login failed, show error message
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string username = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string password = textBox2.Text;
        }
    }
}