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
            this.labelUserTag = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonRegister = new System.Windows.Forms.Button();
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
            this.splitContainerLoginScreen.Panel1.Controls.Add(this.labelUserTag);
            this.splitContainerLoginScreen.Panel1.Controls.Add(this.textBoxPassword);
            this.splitContainerLoginScreen.Panel1.Controls.Add(this.textBoxUserName);
            this.splitContainerLoginScreen.Panel1MinSize = 310;
            // 
            // splitContainerLoginScreen.Panel2
            // 
            this.splitContainerLoginScreen.Panel2.AccessibleName = "RegisterPanel";
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.buttonRegister);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.dateTimePicker1);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.textBox3);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.textBox2);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.textBox1);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.label5);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.label4);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.label3);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.label2);
            this.splitContainerLoginScreen.Panel2.Controls.Add(this.label1);
            this.splitContainerLoginScreen.Panel2MinSize = 310;
            this.splitContainerLoginScreen.Size = new System.Drawing.Size(624, 441);
            this.splitContainerLoginScreen.SplitterDistance = 312;
            this.splitContainerLoginScreen.TabIndex = 0;
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
            this.buttonGuestLogin.TabIndex = 11;
            this.buttonGuestLogin.Text = "Vendég Belépés";
            this.buttonGuestLogin.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(76, 219);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(159, 43);
            this.buttonLogin.TabIndex = 10;
            this.buttonLogin.Text = "Bejelentkezés";
            this.buttonLogin.UseVisualStyleBackColor = true;
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
            // labelUserTag
            // 
            this.labelUserTag.AutoSize = true;
            this.labelUserTag.Location = new System.Drawing.Point(9, 146);
            this.labelUserTag.Name = "labelUserTag";
            this.labelUserTag.Size = new System.Drawing.Size(116, 13);
            this.labelUserTag.TabIndex = 8;
            this.labelUserTag.Text = "Felhasználó azonosító:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(131, 169);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(169, 20);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(131, 143);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(169, 20);
            this.textBoxUserName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(85, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Regisztráció";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Felhasználó név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Születési idő:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Lakhely:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Felhasználó azonosító:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 194);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 20);
            this.textBox3.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 221);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(87, 277);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(130, 38);
            this.buttonRegister.TabIndex = 22;
            this.buttonRegister.Text = "Regisztrálás";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.splitContainerLoginScreen);
            this.Name = "MainForm";
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
        private System.Windows.Forms.Label labelUserTag;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}

