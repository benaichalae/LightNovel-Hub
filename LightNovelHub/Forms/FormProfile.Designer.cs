namespace LightNovelHub.Forms
{
    partial class FormProfile
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cmbSexe;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnSave;

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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            cmbSexe = new ComboBox();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top;
            txtFirstName.Location = new Point(20, 20);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(204, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top;
            txtLastName.Location = new Point(20, 60);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(204, 23);
            txtLastName.TabIndex = 1;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Anchor = AnchorStyles.Top;
            dtpDateOfBirth.Location = new Point(20, 100);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(204, 23);
            dtpDateOfBirth.TabIndex = 2;
            // 
            // cmbSexe
            // 
            cmbSexe.Anchor = AnchorStyles.Top;
            cmbSexe.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexe.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbSexe.Location = new Point(20, 140);
            cmbSexe.Name = "cmbSexe";
            cmbSexe.Size = new Size(204, 23);
            cmbSexe.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top;
            txtUsername.Location = new Point(20, 180);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(204, 23);
            txtUsername.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.Location = new Point(20, 220);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(204, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top;
            txtPassword.Location = new Point(20, 260);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(204, 23);
            txtPassword.TabIndex = 6;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.Top;
            txtConfirmPassword.Location = new Point(20, 300);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.Size = new Size(204, 23);
            txtConfirmPassword.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.Location = new Point(20, 340);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(204, 31);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 27, 32);
            ClientSize = new Size(254, 401);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(cmbSexe);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(btnSave);
            MinimumSize = new Size(270, 440);
            Name = "FormProfile";
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
