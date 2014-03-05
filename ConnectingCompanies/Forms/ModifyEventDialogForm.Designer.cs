namespace ConnectingCompanies.Forms
{
    partial class ModifyEventDialogForm
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
            this.buttonCancelInvitation = new System.Windows.Forms.Button();
            this.buttonInviteUser = new System.Windows.Forms.Button();
            this.listBoxUsersInvited = new System.Windows.Forms.ListBox();
            this.labelEventPlace = new System.Windows.Forms.Label();
            this.textBoxEventPlace = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxEventName = new System.Windows.Forms.TextBox();
            this.listBoxUsersToInvite = new System.Windows.Forms.ListBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelEventName = new System.Windows.Forms.Label();
            this.labelEventDate = new System.Windows.Forms.Label();
            this.dateTimePickerEventDate = new System.Windows.Forms.DateTimePicker();
            this.buttonCloseNewEventDialog = new System.Windows.Forms.Button();
            this.buttonSaveNewEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCancelInvitation
            // 
            this.buttonCancelInvitation.Location = new System.Drawing.Point(321, 143);
            this.buttonCancelInvitation.Name = "buttonCancelInvitation";
            this.buttonCancelInvitation.Size = new System.Drawing.Size(100, 30);
            this.buttonCancelInvitation.TabIndex = 27;
            this.buttonCancelInvitation.Text = "<- Visszavon";
            this.buttonCancelInvitation.UseVisualStyleBackColor = true;
            // 
            // buttonInviteUser
            // 
            this.buttonInviteUser.Location = new System.Drawing.Point(207, 143);
            this.buttonInviteUser.Name = "buttonInviteUser";
            this.buttonInviteUser.Size = new System.Drawing.Size(100, 30);
            this.buttonInviteUser.TabIndex = 26;
            this.buttonInviteUser.Text = "Meghív ->";
            this.buttonInviteUser.UseVisualStyleBackColor = true;
            // 
            // listBoxUsersInvited
            // 
            this.listBoxUsersInvited.FormattingEnabled = true;
            this.listBoxUsersInvited.Location = new System.Drawing.Point(321, 179);
            this.listBoxUsersInvited.Name = "listBoxUsersInvited";
            this.listBoxUsersInvited.Size = new System.Drawing.Size(293, 121);
            this.listBoxUsersInvited.TabIndex = 25;
            // 
            // labelEventPlace
            // 
            this.labelEventPlace.AutoSize = true;
            this.labelEventPlace.Location = new System.Drawing.Point(303, 44);
            this.labelEventPlace.Name = "labelEventPlace";
            this.labelEventPlace.Size = new System.Drawing.Size(51, 13);
            this.labelEventPlace.TabIndex = 24;
            this.labelEventPlace.Text = "Helyszín:";
            // 
            // textBoxEventPlace
            // 
            this.textBoxEventPlace.Location = new System.Drawing.Point(361, 41);
            this.textBoxEventPlace.Name = "textBoxEventPlace";
            this.textBoxEventPlace.Size = new System.Drawing.Size(140, 20);
            this.textBoxEventPlace.TabIndex = 23;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(97, 41);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(200, 53);
            this.textBoxDescription.TabIndex = 22;
            // 
            // textBoxEventName
            // 
            this.textBoxEventName.Location = new System.Drawing.Point(97, 14);
            this.textBoxEventName.Name = "textBoxEventName";
            this.textBoxEventName.Size = new System.Drawing.Size(200, 20);
            this.textBoxEventName.TabIndex = 21;
            // 
            // listBoxUsersToInvite
            // 
            this.listBoxUsersToInvite.FormattingEnabled = true;
            this.listBoxUsersToInvite.Location = new System.Drawing.Point(14, 179);
            this.listBoxUsersToInvite.Name = "listBoxUsersToInvite";
            this.listBoxUsersToInvite.Size = new System.Drawing.Size(293, 121);
            this.listBoxUsersToInvite.TabIndex = 20;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(11, 43);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(40, 13);
            this.labelDescription.TabIndex = 19;
            this.labelDescription.Text = "Leírás:";
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Location = new System.Drawing.Point(11, 16);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(80, 13);
            this.labelEventName.TabIndex = 18;
            this.labelEventName.Text = "Esemény neve:";
            // 
            // labelEventDate
            // 
            this.labelEventDate.AutoSize = true;
            this.labelEventDate.Location = new System.Drawing.Point(303, 16);
            this.labelEventDate.Name = "labelEventDate";
            this.labelEventDate.Size = new System.Drawing.Size(52, 13);
            this.labelEventDate.TabIndex = 17;
            this.labelEventDate.Text = "Időpőont:";
            // 
            // dateTimePickerEventDate
            // 
            this.dateTimePickerEventDate.Location = new System.Drawing.Point(361, 14);
            this.dateTimePickerEventDate.Name = "dateTimePickerEventDate";
            this.dateTimePickerEventDate.Size = new System.Drawing.Size(140, 20);
            this.dateTimePickerEventDate.TabIndex = 16;
            // 
            // buttonCloseNewEventDialog
            // 
            this.buttonCloseNewEventDialog.Location = new System.Drawing.Point(520, 49);
            this.buttonCloseNewEventDialog.Name = "buttonCloseNewEventDialog";
            this.buttonCloseNewEventDialog.Size = new System.Drawing.Size(94, 32);
            this.buttonCloseNewEventDialog.TabIndex = 15;
            this.buttonCloseNewEventDialog.Text = "Bezárás";
            this.buttonCloseNewEventDialog.UseVisualStyleBackColor = true;
            // 
            // buttonSaveNewEvent
            // 
            this.buttonSaveNewEvent.Location = new System.Drawing.Point(520, 11);
            this.buttonSaveNewEvent.Name = "buttonSaveNewEvent";
            this.buttonSaveNewEvent.Size = new System.Drawing.Size(94, 32);
            this.buttonSaveNewEvent.TabIndex = 14;
            this.buttonSaveNewEvent.Text = "Mentés";
            this.buttonSaveNewEvent.UseVisualStyleBackColor = true;
            // 
            // ModifyEventDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 311);
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
            this.Name = "ModifyEventDialogForm";
            this.Text = "Esemény módostása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelInvitation;
        private System.Windows.Forms.Button buttonInviteUser;
        private System.Windows.Forms.ListBox listBoxUsersInvited;
        private System.Windows.Forms.Label labelEventPlace;
        private System.Windows.Forms.TextBox textBoxEventPlace;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxEventName;
        private System.Windows.Forms.ListBox listBoxUsersToInvite;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.Label labelEventDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEventDate;
        private System.Windows.Forms.Button buttonCloseNewEventDialog;
        private System.Windows.Forms.Button buttonSaveNewEvent;
    }
}