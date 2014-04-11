namespace ConnectingCompanies
{
    partial class AddEventDialogForm
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
            this.buttonSaveNewEvent = new System.Windows.Forms.Button();
            this.buttonCloseNewEventDialog = new System.Windows.Forms.Button();
            this.dateTimePickerEventDate = new System.Windows.Forms.DateTimePicker();
            this.labelEventDate = new System.Windows.Forms.Label();
            this.labelEventName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.listBoxUsersToInvite = new System.Windows.Forms.ListBox();
            this.textBoxEventName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxEventPlace = new System.Windows.Forms.TextBox();
            this.labelEventPlace = new System.Windows.Forms.Label();
            this.listBoxUsersInvited = new System.Windows.Forms.ListBox();
            this.buttonInviteUser = new System.Windows.Forms.Button();
            this.buttonCancelInvitation = new System.Windows.Forms.Button();
            this.radioButtonGroup = new System.Windows.Forms.RadioButton();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonSaveNewEvent
            // 
            this.buttonSaveNewEvent.Location = new System.Drawing.Point(518, 10);
            this.buttonSaveNewEvent.Name = "buttonSaveNewEvent";
            this.buttonSaveNewEvent.Size = new System.Drawing.Size(94, 32);
            this.buttonSaveNewEvent.TabIndex = 0;
            this.buttonSaveNewEvent.Text = "Mentés";
            this.buttonSaveNewEvent.UseVisualStyleBackColor = true;
            this.buttonSaveNewEvent.Click += new System.EventHandler(this.buttonSaveNewEvent_Click);
            // 
            // buttonCloseNewEventDialog
            // 
            this.buttonCloseNewEventDialog.Location = new System.Drawing.Point(518, 48);
            this.buttonCloseNewEventDialog.Name = "buttonCloseNewEventDialog";
            this.buttonCloseNewEventDialog.Size = new System.Drawing.Size(94, 32);
            this.buttonCloseNewEventDialog.TabIndex = 1;
            this.buttonCloseNewEventDialog.Text = "Bezárás";
            this.buttonCloseNewEventDialog.UseVisualStyleBackColor = true;
            this.buttonCloseNewEventDialog.Click += new System.EventHandler(this.buttonCloseNewEventDialog_Click);
            // 
            // dateTimePickerEventDate
            // 
            this.dateTimePickerEventDate.Location = new System.Drawing.Point(359, 13);
            this.dateTimePickerEventDate.Name = "dateTimePickerEventDate";
            this.dateTimePickerEventDate.Size = new System.Drawing.Size(140, 20);
            this.dateTimePickerEventDate.TabIndex = 2;
            // 
            // labelEventDate
            // 
            this.labelEventDate.AutoSize = true;
            this.labelEventDate.Location = new System.Drawing.Point(301, 15);
            this.labelEventDate.Name = "labelEventDate";
            this.labelEventDate.Size = new System.Drawing.Size(52, 13);
            this.labelEventDate.TabIndex = 3;
            this.labelEventDate.Text = "Időpőont:";
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Location = new System.Drawing.Point(9, 15);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(80, 13);
            this.labelEventName.TabIndex = 4;
            this.labelEventName.Text = "Esemény neve:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(9, 42);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(40, 13);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Leírás:";
            // 
            // listBoxUsersToInvite
            // 
            this.listBoxUsersToInvite.FormattingEnabled = true;
            this.listBoxUsersToInvite.Location = new System.Drawing.Point(12, 178);
            this.listBoxUsersToInvite.Name = "listBoxUsersToInvite";
            this.listBoxUsersToInvite.Size = new System.Drawing.Size(293, 121);
            this.listBoxUsersToInvite.TabIndex = 6;
            // 
            // textBoxEventName
            // 
            this.textBoxEventName.Location = new System.Drawing.Point(95, 13);
            this.textBoxEventName.Name = "textBoxEventName";
            this.textBoxEventName.Size = new System.Drawing.Size(200, 20);
            this.textBoxEventName.TabIndex = 7;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(95, 40);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(200, 53);
            this.textBoxDescription.TabIndex = 8;
            // 
            // textBoxEventPlace
            // 
            this.textBoxEventPlace.Location = new System.Drawing.Point(359, 40);
            this.textBoxEventPlace.Name = "textBoxEventPlace";
            this.textBoxEventPlace.Size = new System.Drawing.Size(140, 20);
            this.textBoxEventPlace.TabIndex = 9;
            // 
            // labelEventPlace
            // 
            this.labelEventPlace.AutoSize = true;
            this.labelEventPlace.Location = new System.Drawing.Point(301, 43);
            this.labelEventPlace.Name = "labelEventPlace";
            this.labelEventPlace.Size = new System.Drawing.Size(51, 13);
            this.labelEventPlace.TabIndex = 10;
            this.labelEventPlace.Text = "Helyszín:";
            // 
            // listBoxUsersInvited
            // 
            this.listBoxUsersInvited.FormattingEnabled = true;
            this.listBoxUsersInvited.Location = new System.Drawing.Point(319, 178);
            this.listBoxUsersInvited.Name = "listBoxUsersInvited";
            this.listBoxUsersInvited.Size = new System.Drawing.Size(293, 121);
            this.listBoxUsersInvited.TabIndex = 11;
            // 
            // buttonInviteUser
            // 
            this.buttonInviteUser.Location = new System.Drawing.Point(205, 142);
            this.buttonInviteUser.Name = "buttonInviteUser";
            this.buttonInviteUser.Size = new System.Drawing.Size(100, 30);
            this.buttonInviteUser.TabIndex = 12;
            this.buttonInviteUser.Text = "Meghív ->";
            this.buttonInviteUser.UseVisualStyleBackColor = true;
            this.buttonInviteUser.Click += new System.EventHandler(this.buttonInviteUser_Click);
            // 
            // buttonCancelInvitation
            // 
            this.buttonCancelInvitation.Location = new System.Drawing.Point(319, 142);
            this.buttonCancelInvitation.Name = "buttonCancelInvitation";
            this.buttonCancelInvitation.Size = new System.Drawing.Size(100, 30);
            this.buttonCancelInvitation.TabIndex = 13;
            this.buttonCancelInvitation.Text = "<- Visszavon";
            this.buttonCancelInvitation.UseVisualStyleBackColor = true;
            this.buttonCancelInvitation.Click += new System.EventHandler(this.buttonCancelInvitation_Click);
            // 
            // radioButtonGroup
            // 
            this.radioButtonGroup.AutoSize = true;
            this.radioButtonGroup.Location = new System.Drawing.Point(422, 66);
            this.radioButtonGroup.Name = "radioButtonGroup";
            this.radioButtonGroup.Size = new System.Drawing.Size(72, 17);
            this.radioButtonGroup.TabIndex = 14;
            this.radioButtonGroup.TabStop = true;
            this.radioButtonGroup.Text = "Csoportos";
            this.radioButtonGroup.UseVisualStyleBackColor = true;
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.Location = new System.Drawing.Point(359, 66);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(57, 17);
            this.radioButtonUser.TabIndex = 15;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "Egyéni";
            this.radioButtonUser.UseVisualStyleBackColor = true;
            // 
            // AddEventDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 311);
            this.Controls.Add(this.radioButtonUser);
            this.Controls.Add(this.radioButtonGroup);
            this.Controls.Add(this.buttonCancelInvitation);
            this.Controls.Add(this.buttonInviteUser);
            this.Controls.Add(this.listBoxUsersInvited);
            this.Controls.Add(this.labelEventPlace);
            this.Controls.Add(this.textBoxEventPlace);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxEventName);
            this.Controls.Add(this.listBoxUsersToInvite);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelEventName);
            this.Controls.Add(this.labelEventDate);
            this.Controls.Add(this.dateTimePickerEventDate);
            this.Controls.Add(this.buttonCloseNewEventDialog);
            this.Controls.Add(this.buttonSaveNewEvent);
            this.Name = "AddEventDialogForm";
            this.Text = "Új esemény";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveNewEvent;
        private System.Windows.Forms.Button buttonCloseNewEventDialog;
        private System.Windows.Forms.DateTimePicker dateTimePickerEventDate;
        private System.Windows.Forms.Label labelEventDate;
        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ListBox listBoxUsersToInvite;
        private System.Windows.Forms.TextBox textBoxEventName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxEventPlace;
        private System.Windows.Forms.Label labelEventPlace;
        private System.Windows.Forms.ListBox listBoxUsersInvited;
        private System.Windows.Forms.Button buttonInviteUser;
        private System.Windows.Forms.Button buttonCancelInvitation;
        private System.Windows.Forms.RadioButton radioButtonGroup;
        private System.Windows.Forms.RadioButton radioButtonUser;
    }
}