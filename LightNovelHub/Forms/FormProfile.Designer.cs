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
            this.txtFirstName = new TextBox();
            this.txtLastName = new TextBox();
            this.dtpDateOfBirth = new DateTimePicker();
            this.cmbSexe = new ComboBox();
            this.txtUsername = new TextBox();
            this.txtEmail = new TextBox();
            this.txtPassword = new TextBox();
            this.txtConfirmPassword = new TextBox();
            this.btnSave = new Button();
            this.SuspendLayout();

            // txtFirstName
            this.txtFirstName.Location = new System.Drawing.Point(20, 20);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.Size = new System.Drawing.Size(204, 23);
            this.txtFirstName.TabIndex = 0;

            // txtLastName
            this.txtLastName.Location = new System.Drawing.Point(20, 60);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.Size = new System.Drawing.Size(204, 23);
            this.txtLastName.TabIndex = 1;

            // dtpDateOfBirth
            this.dtpDateOfBirth.Location = new System.Drawing.Point(20, 100);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(204, 23);
            this.dtpDateOfBirth.TabIndex = 2;

            // cmbSexe
            this.cmbSexe.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSexe.Items.AddRange(new object[] { "Male", "Female", "Other" });
            this.cmbSexe.Location = new System.Drawing.Point(20, 140);
            this.cmbSexe.Name = "cmbSexe";
            this.cmbSexe.Size = new System.Drawing.Size(204, 23);
            this.cmbSexe.TabIndex = 3;

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(20, 180);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(204, 23);
            this.txtUsername.TabIndex = 4;

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(20, 220);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(204, 23);
            this.txtEmail.TabIndex = 5;

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(20, 260);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(204, 23);
            this.txtPassword.TabIndex = 6;

            // txtConfirmPassword
            this.txtConfirmPassword.Location = new System.Drawing.Point(20, 300);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.PlaceholderText = "Confirm Password";
            this.txtConfirmPassword.Size = new System.Drawing.Size(204, 23);
            this.txtConfirmPassword.TabIndex = 7;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(20, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(204, 31);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // FormProfile
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(61, 61, 91);
            this.ClientSize = new System.Drawing.Size(254, 401);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.cmbSexe);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.btnSave);
            this.MinimumSize = new System.Drawing.Size(270, 440);
            this.Name = "FormProfile";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
