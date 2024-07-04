using System;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace LightNovelHub.Forms
{
    public partial class FormProfile : Form
    {
        private Form2 parentForm;
        private const string profileFilePath = @"C:\Users\benai\source\repos\LightNovelHub\LightNovelHub\Profile\userProfile.txt";

        public FormProfile(Form2 parent)
        {
            InitializeComponent();
            parentForm = parent;
            LoadProfile();
        }

        private void LoadProfile()
        {
            if (File.Exists(profileFilePath))
            {
                var lines = File.ReadAllLines(profileFilePath);
                if (lines.Length >= 7)
                {
                    txtFirstName.Text = lines[0];
                    txtLastName.Text = lines[1];
                    dtpDateOfBirth.Value = DateTime.Parse(lines[2]);
                    cmbSexe.SelectedItem = lines[3];
                    txtUsername.Text = lines[4];
                    txtEmail.Text = lines[5];
                    txtPassword.Text = lines[6];
                    txtConfirmPassword.Text = lines[6]; // Assuming the saved password is the same for both fields
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            if (txtUsername.Text.Contains(" "))
            {
                MessageBox.Show("Username must not contain spaces.");
                return;
            }

            if (dtpDateOfBirth.Value > DateTime.Now.AddYears(-18))
            {
                MessageBox.Show("You must be at least 18 years old.");
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            var profileData = new[]
            {
                txtFirstName.Text,
                txtLastName.Text,
                dtpDateOfBirth.Value.ToString("yyyy-MM-dd"),
                cmbSexe.SelectedItem?.ToString() ?? "",
                txtUsername.Text,
                txtEmail.Text,
                txtPassword.Text
            };

            File.WriteAllLines(profileFilePath, profileData);
            MessageBox.Show("Profile saved successfully.");
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
