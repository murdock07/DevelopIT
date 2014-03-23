namespace ConnectingCompanies.Forms
{
    partial class NewOfferForm
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
            this.labelOfferSender = new System.Windows.Forms.Label();
            this.labelOfferTo = new System.Windows.Forms.Label();
            this.labelOfferName = new System.Windows.Forms.Label();
            this.labelOfferDescription = new System.Windows.Forms.Label();
            this.labelOfferPrice = new System.Windows.Forms.Label();
            this.labelOfferDateInterval = new System.Windows.Forms.Label();
            this.textBoxOfferSender = new System.Windows.Forms.TextBox();
            this.comboBoxOfferTo = new System.Windows.Forms.ComboBox();
            this.textBoxOfferName = new System.Windows.Forms.TextBox();
            this.dateTimePickerOfferStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOfferEndDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxOfferPrice = new System.Windows.Forms.TextBox();
            this.textBoxOfferDescription = new System.Windows.Forms.TextBox();
            this.buttonSendOffer = new System.Windows.Forms.Button();
            this.buttonCloseOffer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOfferSender
            // 
            this.labelOfferSender.AutoSize = true;
            this.labelOfferSender.Location = new System.Drawing.Point(13, 13);
            this.labelOfferSender.Name = "labelOfferSender";
            this.labelOfferSender.Size = new System.Drawing.Size(116, 13);
            this.labelOfferSender.TabIndex = 0;
            this.labelOfferSender.Text = "Ajánlat kezdeményező:";
            // 
            // labelOfferTo
            // 
            this.labelOfferTo.AutoSize = true;
            this.labelOfferTo.Location = new System.Drawing.Point(13, 40);
            this.labelOfferTo.Name = "labelOfferTo";
            this.labelOfferTo.Size = new System.Drawing.Size(78, 13);
            this.labelOfferTo.TabIndex = 1;
            this.labelOfferTo.Text = "Ajánlat fogadó:";
            // 
            // labelOfferName
            // 
            this.labelOfferName.AutoSize = true;
            this.labelOfferName.Location = new System.Drawing.Point(13, 67);
            this.labelOfferName.Name = "labelOfferName";
            this.labelOfferName.Size = new System.Drawing.Size(66, 13);
            this.labelOfferName.TabIndex = 2;
            this.labelOfferName.Text = "Ajánlat címe";
            // 
            // labelOfferDescription
            // 
            this.labelOfferDescription.AutoSize = true;
            this.labelOfferDescription.Location = new System.Drawing.Point(12, 147);
            this.labelOfferDescription.Name = "labelOfferDescription";
            this.labelOfferDescription.Size = new System.Drawing.Size(77, 13);
            this.labelOfferDescription.TabIndex = 5;
            this.labelOfferDescription.Text = "Ajánlat leírása:";
            // 
            // labelOfferPrice
            // 
            this.labelOfferPrice.AutoSize = true;
            this.labelOfferPrice.Location = new System.Drawing.Point(13, 120);
            this.labelOfferPrice.Name = "labelOfferPrice";
            this.labelOfferPrice.Size = new System.Drawing.Size(60, 13);
            this.labelOfferPrice.TabIndex = 4;
            this.labelOfferPrice.Text = "Ajánlat ára:";
            // 
            // labelOfferDateInterval
            // 
            this.labelOfferDateInterval.AutoSize = true;
            this.labelOfferDateInterval.Location = new System.Drawing.Point(13, 96);
            this.labelOfferDateInterval.Name = "labelOfferDateInterval";
            this.labelOfferDateInterval.Size = new System.Drawing.Size(91, 13);
            this.labelOfferDateInterval.TabIndex = 3;
            this.labelOfferDateInterval.Text = "Ajánlat időtartama";
            // 
            // textBoxOfferSender
            // 
            this.textBoxOfferSender.Location = new System.Drawing.Point(136, 10);
            this.textBoxOfferSender.Name = "textBoxOfferSender";
            this.textBoxOfferSender.Size = new System.Drawing.Size(236, 20);
            this.textBoxOfferSender.TabIndex = 7;
            // 
            // comboBoxOfferTo
            // 
            this.comboBoxOfferTo.FormattingEnabled = true;
            this.comboBoxOfferTo.Location = new System.Drawing.Point(136, 37);
            this.comboBoxOfferTo.Name = "comboBoxOfferTo";
            this.comboBoxOfferTo.Size = new System.Drawing.Size(236, 21);
            this.comboBoxOfferTo.TabIndex = 8;
            // 
            // textBoxOfferName
            // 
            this.textBoxOfferName.Location = new System.Drawing.Point(136, 64);
            this.textBoxOfferName.Name = "textBoxOfferName";
            this.textBoxOfferName.Size = new System.Drawing.Size(236, 20);
            this.textBoxOfferName.TabIndex = 9;
            // 
            // dateTimePickerOfferStartDate
            // 
            this.dateTimePickerOfferStartDate.Location = new System.Drawing.Point(136, 90);
            this.dateTimePickerOfferStartDate.Name = "dateTimePickerOfferStartDate";
            this.dateTimePickerOfferStartDate.Size = new System.Drawing.Size(110, 20);
            this.dateTimePickerOfferStartDate.TabIndex = 10;
            // 
            // dateTimePickerOfferEndDate
            // 
            this.dateTimePickerOfferEndDate.Location = new System.Drawing.Point(262, 90);
            this.dateTimePickerOfferEndDate.Name = "dateTimePickerOfferEndDate";
            this.dateTimePickerOfferEndDate.Size = new System.Drawing.Size(110, 20);
            this.dateTimePickerOfferEndDate.TabIndex = 11;
            // 
            // textBoxOfferPrice
            // 
            this.textBoxOfferPrice.Location = new System.Drawing.Point(136, 117);
            this.textBoxOfferPrice.Name = "textBoxOfferPrice";
            this.textBoxOfferPrice.Size = new System.Drawing.Size(236, 20);
            this.textBoxOfferPrice.TabIndex = 12;
            // 
            // textBoxOfferDescription
            // 
            this.textBoxOfferDescription.Location = new System.Drawing.Point(136, 144);
            this.textBoxOfferDescription.Multiline = true;
            this.textBoxOfferDescription.Name = "textBoxOfferDescription";
            this.textBoxOfferDescription.Size = new System.Drawing.Size(236, 110);
            this.textBoxOfferDescription.TabIndex = 13;
            // 
            // buttonSendOffer
            // 
            this.buttonSendOffer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSendOffer.Location = new System.Drawing.Point(84, 276);
            this.buttonSendOffer.Name = "buttonSendOffer";
            this.buttonSendOffer.Size = new System.Drawing.Size(75, 23);
            this.buttonSendOffer.TabIndex = 14;
            this.buttonSendOffer.Text = "Küldés";
            this.buttonSendOffer.UseVisualStyleBackColor = true;
            this.buttonSendOffer.Click += new System.EventHandler(this.buttonSendOffer_Click);
            // 
            // buttonCloseOffer
            // 
            this.buttonCloseOffer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCloseOffer.Location = new System.Drawing.Point(226, 276);
            this.buttonCloseOffer.Name = "buttonCloseOffer";
            this.buttonCloseOffer.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseOffer.TabIndex = 15;
            this.buttonCloseOffer.Text = "Bezárás";
            this.buttonCloseOffer.UseVisualStyleBackColor = true;
            this.buttonCloseOffer.Click += new System.EventHandler(this.buttonCloseOffer_Click);
            // 
            // NewOfferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.buttonCloseOffer);
            this.Controls.Add(this.buttonSendOffer);
            this.Controls.Add(this.textBoxOfferDescription);
            this.Controls.Add(this.textBoxOfferPrice);
            this.Controls.Add(this.dateTimePickerOfferEndDate);
            this.Controls.Add(this.dateTimePickerOfferStartDate);
            this.Controls.Add(this.textBoxOfferName);
            this.Controls.Add(this.comboBoxOfferTo);
            this.Controls.Add(this.textBoxOfferSender);
            this.Controls.Add(this.labelOfferDescription);
            this.Controls.Add(this.labelOfferPrice);
            this.Controls.Add(this.labelOfferDateInterval);
            this.Controls.Add(this.labelOfferName);
            this.Controls.Add(this.labelOfferTo);
            this.Controls.Add(this.labelOfferSender);
            this.Name = "NewOfferForm";
            this.Text = "Új ajánlat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOfferSender;
        private System.Windows.Forms.Label labelOfferTo;
        private System.Windows.Forms.Label labelOfferName;
        private System.Windows.Forms.Label labelOfferDescription;
        private System.Windows.Forms.Label labelOfferPrice;
        private System.Windows.Forms.Label labelOfferDateInterval;
        private System.Windows.Forms.TextBox textBoxOfferSender;
        private System.Windows.Forms.ComboBox comboBoxOfferTo;
        private System.Windows.Forms.TextBox textBoxOfferName;
        private System.Windows.Forms.DateTimePicker dateTimePickerOfferStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerOfferEndDate;
        private System.Windows.Forms.TextBox textBoxOfferPrice;
        private System.Windows.Forms.TextBox textBoxOfferDescription;
        private System.Windows.Forms.Button buttonSendOffer;
        private System.Windows.Forms.Button buttonCloseOffer;
    }
}