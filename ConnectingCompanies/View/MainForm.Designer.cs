
namespace ConnectingCompanies
{
    partial class MainForm
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
            this.splitContainerLoginScreen = new System.Windows.Forms.SplitContainer();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonGuestLogin = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLoginUserTag = new System.Windows.Forms.Label();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.textBoxLoginUserName = new System.Windows.Forms.TextBox();
            this.textBoxRegPassword = new System.Windows.Forms.TextBox();
            this.labelRegPassword = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.dateTimePickerRegBirthDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxRegAddress = new System.Windows.Forms.TextBox();
            this.textBoxRegUserName = new System.Windows.Forms.TextBox();
            this.textBoxRegUserTag = new System.Windows.Forms.TextBox();
            this.labelRegUserTag = new System.Windows.Forms.Label();
            this.labelRegAddress = new System.Windows.Forms.Label();
            this.labelRegBirthDate = new System.Windows.Forms.Label();
            this.labelRegUserName = new System.Windows.Forms.Label();
            this.labelRegistration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLoginScreen)).BeginInit();
            this.splitContainerLoginScreen.Panel1.SuspendLayout();
            this.splitContainerLoginScreen.Panel2.SuspendLayout();
            this.splitContainerLoginScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerLoginScreen
            // 
            this.splitContainerLoginScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerLoginScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLoginScreen.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerLoginScreen.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLoginScreen.Name = "splitContainerLoginScreen";
            // 
            // splitContainerLoginScreen.Panel1
            // 
            this.splitContainerLoginScreen.Panel1.AccessibleName = "LoginPanel";
            this.splitContainerLoginScreen.Panel1.Controls.Add(this.labelLogin);
            this.splitContainerLoginScreen.Panel1.Controls.Add(this.buttonGuestLogin);
            this.splitContainerLoginScreen.Panel1.Controls.Add(this.buttonLogin);
            this.splitContainerLoginScreen.Panel1.Controls.Add(this.labelPassword);
            this.splitContainerLoginScreen.Panel1.Controls.Add(this.labelLoginUserTag);
            this.splitContainerLoginScreen.Panel1.Controls.Add(this.textBoxLoginPassword);
            this.splitContainerLoginScreen.Panel1.Controls.Add(this.textBoxLoginUserName);
            this.splitContainerLoginScreen.Panel1MinSize = 310;
            // 
            // splitContainerLoginScreen.Panel2
            // 
            this.splitContainerLoginScreen.Panel2.AccessibleName = "RegisterPanel";
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.textBoxRegPassword);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.labelRegPassword);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.buttonRegister);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.dateTimePickerRegBirthDate);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.textBoxRegAddress);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.textBoxRegUserName);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.textBoxRegUserTag);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.labelRegUserTag);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.labelRegAddress);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.labelRegBirthDate);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.labelRegUserName);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.labelRegistration);
            this.splitContainerLoginScreen.Panel2MinSize = 310;
            this.splitContainerLoginScreen.Size = new System.Drawing.Size(624, 441);
            this.splitContainerLoginScreen.SplitterDistance = 312;
            this.splitContainerLoginScreen.TabIndex = 20;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.Location = new System.Drawing.Point(87, 65);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(148, 26);
            this.labelLogin.TabIndex = 12;
            this.labelLogin.Text = "Bejelentkezés";
            // 
            // buttonGuestLogin
            // 
            this.buttonGuestLogin.Location = new System.Drawing.Point(102, 406);
            this.buttonGuestLogin.Name = "buttonGuestLogin";
            this.buttonGuestLogin.Size = new System.Drawing.Size(106, 23);
            this.buttonGuestLogin.TabIndex = 4;
            this.buttonGuestLogin.Text = "Vendég Belépés";
            this.buttonGuestLogin.UseVisualStyleBackColor = true;
            this.buttonGuestLogin.Click += new System.EventHandler(this.buttonGuestLogin_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(76, 219);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(159, 43);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Bejelentkezés";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(86, 172);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(39, 13);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Jelszó:";
            // 
            // labelLoginUserTag
            // 
            this.labelLoginUserTag.AutoSize = true;
            this.labelLoginUserTag.Location = new System.Drawing.Point(9, 146);
            this.labelLoginUserTag.Name = "labelLoginUserTag";
            this.labelLoginUserTag.Size = new System.Drawing.Size(116, 13);
            this.labelLoginUserTag.TabIndex = 8;
            this.labelLoginUserTag.Text = "Felhasználó azonosító:";
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.AcceptsReturn = true;
            this.textBoxLoginPassword.Location = new System.Drawing.Point(131, 169);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.PasswordChar = '*';
            this.textBoxLoginPassword.Size = new System.Drawing.Size(169, 20);
            this.textBoxLoginPassword.TabIndex = 2;
            // 
            // textBoxLoginUserName
            // 
            this.textBoxLoginUserName.AcceptsReturn = true;
            this.textBoxLoginUserName.Location = new System.Drawing.Point(131, 143);
            this.textBoxLoginUserName.Name = "textBoxLoginUserName";
            this.textBoxLoginUserName.Size = new System.Drawing.Size(169, 20);
            this.textBoxLoginUserName.TabIndex = 1;
            // 
            // textBoxRegPassword
            // 
            this.textBoxRegPassword.Location = new System.Drawing.Point(137, 167);
            this.textBoxRegPassword.Name = "textBoxRegPassword";
            this.textBoxRegPassword.Size = new System.Drawing.Size(159, 20);
            this.textBoxRegPassword.TabIndex = 18;
            // 
            // labelRegPassword
            // 
            this.labelRegPassword.AutoSize = true;
            this.labelRegPassword.Location = new System.Drawing.Point(92, 170);
            this.labelRegPassword.Name = "labelRegPassword";
            this.labelRegPassword.Size = new System.Drawing.Size(39, 13);
            this.labelRegPassword.TabIndex = 19;
            this.labelRegPassword.Text = "Jelszó:";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(87, 303);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(130, 38);
            this.buttonRegister.TabIndex = 9;
            this.buttonRegister.Text = "Regisztrálás";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // dateTimePickerRegBirthDate
            // 
            this.dateTimePickerRegBirthDate.Location = new System.Drawing.Point(137, 247);
            this.dateTimePickerRegBirthDate.Name = "dateTimePickerRegBirthDate";
            this.dateTimePickerRegBirthDate.Size = new System.Drawing.Size(159, 20);
            this.dateTimePickerRegBirthDate.TabIndex = 8;
            // 
            // textBoxRegAddress
            // 
            this.textBoxRegAddress.Location = new System.Drawing.Point(137, 220);
            this.textBoxRegAddress.Name = "textBoxRegAddress";
            this.textBoxRegAddress.Size = new System.Drawing.Size(159, 20);
            this.textBoxRegAddress.TabIndex = 7;
            // 
            // textBoxRegUserName
            // 
            this.textBoxRegUserName.Location = new System.Drawing.Point(137, 193);
            this.textBoxRegUserName.Name = "textBoxRegUserName";
            this.textBoxRegUserName.Size = new System.Drawing.Size(159, 20);
            this.textBoxRegUserName.TabIndex = 6;
            // 
            // textBoxRegUserTag
            // 
            this.textBoxRegUserTag.Location = new System.Drawing.Point(137, 141);
            this.textBoxRegUserTag.Name = "textBoxRegUserTag";
            this.textBoxRegUserTag.Size = new System.Drawing.Size(159, 20);
            this.textBoxRegUserTag.TabIndex = 5;
            // 
            // labelRegUserTag
            // 
            this.labelRegUserTag.AutoSize = true;
            this.labelRegUserTag.Location = new System.Drawing.Point(15, 144);
            this.labelRegUserTag.Name = "labelRegUserTag";
            this.labelRegUserTag.Size = new System.Drawing.Size(116, 13);
            this.labelRegUserTag.TabIndex = 17;
            this.labelRegUserTag.Text = "Felhasználó azonosító:";
            // 
            // labelRegAddress
            // 
            this.labelRegAddress.AutoSize = true;
            this.labelRegAddress.Location = new System.Drawing.Point(84, 223);
            this.labelRegAddress.Name = "labelRegAddress";
            this.labelRegAddress.Size = new System.Drawing.Size(47, 13);
            this.labelRegAddress.TabIndex = 16;
            this.labelRegAddress.Text = "Lakhely:";
            // 
            // labelRegBirthDate
            // 
            this.labelRegBirthDate.AutoSize = true;
            this.labelRegBirthDate.Location = new System.Drawing.Point(62, 253);
            this.labelRegBirthDate.Name = "labelRegBirthDate";
            this.labelRegBirthDate.Size = new System.Drawing.Size(69, 13);
            this.labelRegBirthDate.TabIndex = 15;
            this.labelRegBirthDate.Text = "Születési idő:";
            // 
            // labelRegUserName
            // 
            this.labelRegUserName.AutoSize = true;
            this.labelRegUserName.Location = new System.Drawing.Point(44, 196);
            this.labelRegUserName.Name = "labelRegUserName";
            this.labelRegUserName.Size = new System.Drawing.Size(87, 13);
            this.labelRegUserName.TabIndex = 14;
            this.labelRegUserName.Text = "Felhasználó név:";
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRegistration.Location = new System.Drawing.Point(85, 65);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(132, 26);
            this.labelRegistration.TabIndex = 13;
            this.labelRegistration.Text = "Regisztráció";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.splitContainerLoginScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connecting Companies - Bejelentkezés";
            this.splitContainerLoginScreen.Panel1.ResumeLayout(false);
            this.splitContainerLoginScreen.Panel1.PerformLayout();
            this.splitContainerLoginScreen.Panel2.ResumeLayout(false);
            this.splitContainerLoginScreen.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLoginScreen)).EndInit();
            this.splitContainerLoginScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerLoginScreen;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonGuestLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLoginUserTag;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.TextBox textBoxLoginUserName;
        private System.Windows.Forms.Label labelRegAddress;
        private System.Windows.Forms.Label labelRegBirthDate;
        private System.Windows.Forms.Label labelRegUserName;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegBirthDate;
        private System.Windows.Forms.TextBox textBoxRegAddress;
        private System.Windows.Forms.TextBox textBoxRegUserName;
        private System.Windows.Forms.TextBox textBoxRegUserTag;
        private System.Windows.Forms.Label labelRegUserTag;
        private System.Windows.Forms.TextBox textBoxRegPassword;
        private System.Windows.Forms.Label labelRegPassword;
    }
}

