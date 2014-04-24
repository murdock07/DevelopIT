namespace ConnectingCompanies.Forms
{
    partial class NewMailForm
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
            this.labelMailSender = new System.Windows.Forms.Label();
            this.textBoxMailSender = new System.Windows.Forms.TextBox();
            this.labelMailTo = new System.Windows.Forms.Label();
            this.textBoxMailSubject = new System.Windows.Forms.TextBox();
            this.labelMailSubject = new System.Windows.Forms.Label();
            this.textBoxMailBody = new System.Windows.Forms.TextBox();
            this.labelMailBody = new System.Windows.Forms.Label();
            this.buttonCloseMail = new System.Windows.Forms.Button();
            this.buttonSendMail = new System.Windows.Forms.Button();
            this.comboBoxMailTo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelMailSender
            // 
            this.labelMailSender.AutoSize = true;
            this.labelMailSender.Location = new System.Drawing.Point(12, 13);
            this.labelMailSender.Name = "labelMailSender";
            this.labelMailSender.Size = new System.Drawing.Size(37, 13);
            this.labelMailSender.TabIndex = 0;
            this.labelMailSender.Text = "Küldő:";
            // 
            // textBoxMailSender
            // 
            this.textBoxMailSender.Location = new System.Drawing.Point(62, 10);
            this.textBoxMailSender.Name = "textBoxMailSender";
            this.textBoxMailSender.Size = new System.Drawing.Size(310, 20);
            this.textBoxMailSender.TabIndex = 1;
            // 
            // labelMailTo
            // 
            this.labelMailTo.AutoSize = true;
            this.labelMailTo.Location = new System.Drawing.Point(12, 39);
            this.labelMailTo.Name = "labelMailTo";
            this.labelMailTo.Size = new System.Drawing.Size(46, 13);
            this.labelMailTo.TabIndex = 2;
            this.labelMailTo.Text = "Címzett:";
            // 
            // textBoxMailSubject
            // 
            this.textBoxMailSubject.Location = new System.Drawing.Point(62, 62);
            this.textBoxMailSubject.Name = "textBoxMailSubject";
            this.textBoxMailSubject.Size = new System.Drawing.Size(310, 20);
            this.textBoxMailSubject.TabIndex = 5;
            // 
            // labelMailSubject
            // 
            this.labelMailSubject.AutoSize = true;
            this.labelMailSubject.Location = new System.Drawing.Point(12, 65);
            this.labelMailSubject.Name = "labelMailSubject";
            this.labelMailSubject.Size = new System.Drawing.Size(37, 13);
            this.labelMailSubject.TabIndex = 4;
            this.labelMailSubject.Text = "Tárgy:";
            // 
            // textBoxMailBody
            // 
            this.textBoxMailBody.Location = new System.Drawing.Point(62, 88);
            this.textBoxMailBody.Multiline = true;
            this.textBoxMailBody.Name = "textBoxMailBody";
            this.textBoxMailBody.Size = new System.Drawing.Size(310, 161);
            this.textBoxMailBody.TabIndex = 7;
            // 
            // labelMailBody
            // 
            this.labelMailBody.AutoSize = true;
            this.labelMailBody.Location = new System.Drawing.Point(12, 91);
            this.labelMailBody.Name = "labelMailBody";
            this.labelMailBody.Size = new System.Drawing.Size(44, 13);
            this.labelMailBody.TabIndex = 6;
            this.labelMailBody.Text = "Üzenet:";
            // 
            // buttonCloseMail
            // 
            this.buttonCloseMail.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCloseMail.Location = new System.Drawing.Point(191, 270);
            this.buttonCloseMail.Name = "buttonCloseMail";
            this.buttonCloseMail.Size = new System.Drawing.Size(97, 29);
            this.buttonCloseMail.TabIndex = 8;
            this.buttonCloseMail.Text = "Bezárás";
            this.buttonCloseMail.UseVisualStyleBackColor = true;
            this.buttonCloseMail.Click += new System.EventHandler(this.buttonCloseMail_Click);
            // 
            // buttonSendMail
            // 
            this.buttonSendMail.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSendMail.Location = new System.Drawing.Point(88, 270);
            this.buttonSendMail.Name = "buttonSendMail";
            this.buttonSendMail.Size = new System.Drawing.Size(97, 29);
            this.buttonSendMail.TabIndex = 9;
            this.buttonSendMail.Text = "Küldés";
            this.buttonSendMail.UseVisualStyleBackColor = true;
            this.buttonSendMail.Click += new System.EventHandler(this.buttonSendMail_Click);
            // 
            // comboBoxMailTo
            // 
            this.comboBoxMailTo.FormattingEnabled = true;
            this.comboBoxMailTo.Location = new System.Drawing.Point(62, 36);
            this.comboBoxMailTo.Name = "comboBoxMailTo";
            this.comboBoxMailTo.Size = new System.Drawing.Size(310, 21);
            this.comboBoxMailTo.TabIndex = 10;
            // 
            // NewMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.comboBoxMailTo);
            this.Controls.Add(this.buttonSendMail);
            this.Controls.Add(this.buttonCloseMail);
            this.Controls.Add(this.textBoxMailBody);
            this.Controls.Add(this.labelMailBody);
            this.Controls.Add(this.textBoxMailSubject);
            this.Controls.Add(this.labelMailSubject);
            this.Controls.Add(this.labelMailTo);
            this.Controls.Add(this.textBoxMailSender);
            this.Controls.Add(this.labelMailSender);
            this.Name = "NewMailForm";
            this.Text = "Új üzenet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMailSender;
        private System.Windows.Forms.TextBox textBoxMailSender;
        private System.Windows.Forms.Label labelMailTo;
        private System.Windows.Forms.TextBox textBoxMailSubject;
        private System.Windows.Forms.Label labelMailSubject;
        private System.Windows.Forms.TextBox textBoxMailBody;
        private System.Windows.Forms.Label labelMailBody;
        private System.Windows.Forms.Button buttonCloseMail;
        private System.Windows.Forms.Button buttonSendMail;
        private System.Windows.Forms.ComboBox comboBoxMailTo;
    }
}