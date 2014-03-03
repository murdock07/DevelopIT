namespace ConnectingCompanies
{
    partial class UserInterfaceForm
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
            this.tabControlUserInterface = new System.Windows.Forms.TabControl();
            this.tabPageUserProfile = new System.Windows.Forms.TabPage();
            this.tabPageGroupProfile = new System.Windows.Forms.TabPage();
            this.tabPageCalendar = new System.Windows.Forms.TabPage();
            this.groupBoxPersonalInformation = new System.Windows.Forms.GroupBox();
            this.groupBoxPersonalFunctions = new System.Windows.Forms.GroupBox();
            this.groupBoxGroupFunctions = new System.Windows.Forms.GroupBox();
            this.groupBoxGroupInformation = new System.Windows.Forms.GroupBox();
            this.buttonCreateNewEvent = new System.Windows.Forms.Button();
            this.listBoxPersonalEvents = new System.Windows.Forms.ListBox();
            this.listBoxGroupEvents = new System.Windows.Forms.ListBox();
            this.labelPersonalEvents = new System.Windows.Forms.Label();
            this.labelGroupEvents = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControlUserInterface.SuspendLayout();
            this.tabPageUserProfile.SuspendLayout();
            this.tabPageGroupProfile.SuspendLayout();
            this.tabPageCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUserInterface
            // 
            this.tabControlUserInterface.Controls.Add(this.tabPageUserProfile);
            this.tabControlUserInterface.Controls.Add(this.tabPageGroupProfile);
            this.tabControlUserInterface.Controls.Add(this.tabPageCalendar);
            this.tabControlUserInterface.Location = new System.Drawing.Point(12, 12);
            this.tabControlUserInterface.Name = "tabControlUserInterface";
            this.tabControlUserInterface.SelectedIndex = 0;
            this.tabControlUserInterface.Size = new System.Drawing.Size(760, 537);
            this.tabControlUserInterface.TabIndex = 0;
            // 
            // tabPageUserProfile
            // 
            this.tabPageUserProfile.Controls.Add(this.groupBoxPersonalFunctions);
            this.tabPageUserProfile.Controls.Add(this.groupBoxPersonalInformation);
            this.tabPageUserProfile.Location = new System.Drawing.Point(4, 22);
            this.tabPageUserProfile.Name = "tabPageUserProfile";
            this.tabPageUserProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserProfile.Size = new System.Drawing.Size(752, 511);
            this.tabPageUserProfile.TabIndex = 0;
            this.tabPageUserProfile.Text = "Felhasználó Adatlap";
            this.tabPageUserProfile.UseVisualStyleBackColor = true;
            // 
            // tabPageGroupProfile
            // 
            this.tabPageGroupProfile.Controls.Add(this.groupBoxGroupFunctions);
            this.tabPageGroupProfile.Controls.Add(this.groupBoxGroupInformation);
            this.tabPageGroupProfile.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroupProfile.Name = "tabPageGroupProfile";
            this.tabPageGroupProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroupProfile.Size = new System.Drawing.Size(752, 511);
            this.tabPageGroupProfile.TabIndex = 1;
            this.tabPageGroupProfile.Text = "Csoport Adatlap";
            this.tabPageGroupProfile.UseVisualStyleBackColor = true;
            // 
            // tabPageCalendar
            // 
            this.tabPageCalendar.Controls.Add(this.button2);
            this.tabPageCalendar.Controls.Add(this.button1);
            this.tabPageCalendar.Controls.Add(this.labelGroupEvents);
            this.tabPageCalendar.Controls.Add(this.labelPersonalEvents);
            this.tabPageCalendar.Controls.Add(this.listBoxGroupEvents);
            this.tabPageCalendar.Controls.Add(this.listBoxPersonalEvents);
            this.tabPageCalendar.Controls.Add(this.buttonCreateNewEvent);
            this.tabPageCalendar.Location = new System.Drawing.Point(4, 22);
            this.tabPageCalendar.Name = "tabPageCalendar";
            this.tabPageCalendar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCalendar.Size = new System.Drawing.Size(752, 511);
            this.tabPageCalendar.TabIndex = 2;
            this.tabPageCalendar.Text = "Események";
            this.tabPageCalendar.UseVisualStyleBackColor = true;
            // 
            // groupBoxPersonalInformation
            // 
            this.groupBoxPersonalInformation.Location = new System.Drawing.Point(7, 7);
            this.groupBoxPersonalInformation.Name = "groupBoxPersonalInformation";
            this.groupBoxPersonalInformation.Size = new System.Drawing.Size(434, 498);
            this.groupBoxPersonalInformation.TabIndex = 0;
            this.groupBoxPersonalInformation.TabStop = false;
            this.groupBoxPersonalInformation.Text = "Személyes Adatok";
            // 
            // groupBoxPersonalFunctions
            // 
            this.groupBoxPersonalFunctions.Location = new System.Drawing.Point(447, 7);
            this.groupBoxPersonalFunctions.Name = "groupBoxPersonalFunctions";
            this.groupBoxPersonalFunctions.Size = new System.Drawing.Size(299, 498);
            this.groupBoxPersonalFunctions.TabIndex = 1;
            this.groupBoxPersonalFunctions.TabStop = false;
            this.groupBoxPersonalFunctions.Text = "Személyes Funkciók";
            // 
            // groupBoxGroupFunctions
            // 
            this.groupBoxGroupFunctions.Location = new System.Drawing.Point(447, 6);
            this.groupBoxGroupFunctions.Name = "groupBoxGroupFunctions";
            this.groupBoxGroupFunctions.Size = new System.Drawing.Size(299, 498);
            this.groupBoxGroupFunctions.TabIndex = 3;
            this.groupBoxGroupFunctions.TabStop = false;
            this.groupBoxGroupFunctions.Text = "Csoport Funkciók";
            // 
            // groupBoxGroupInformation
            // 
            this.groupBoxGroupInformation.Location = new System.Drawing.Point(7, 6);
            this.groupBoxGroupInformation.Name = "groupBoxGroupInformation";
            this.groupBoxGroupInformation.Size = new System.Drawing.Size(434, 498);
            this.groupBoxGroupInformation.TabIndex = 2;
            this.groupBoxGroupInformation.TabStop = false;
            this.groupBoxGroupInformation.Text = "Csoport Adatok";
            // 
            // buttonCreateNewEvent
            // 
            this.buttonCreateNewEvent.Location = new System.Drawing.Point(552, 28);
            this.buttonCreateNewEvent.Name = "buttonCreateNewEvent";
            this.buttonCreateNewEvent.Size = new System.Drawing.Size(194, 50);
            this.buttonCreateNewEvent.TabIndex = 1;
            this.buttonCreateNewEvent.Text = "Új esemény";
            this.buttonCreateNewEvent.UseVisualStyleBackColor = true;
            this.buttonCreateNewEvent.Click += new System.EventHandler(this.buttonCreateNewEvent_Click);
            // 
            // listBoxPersonalEvents
            // 
            this.listBoxPersonalEvents.FormattingEnabled = true;
            this.listBoxPersonalEvents.Location = new System.Drawing.Point(6, 28);
            this.listBoxPersonalEvents.Name = "listBoxPersonalEvents";
            this.listBoxPersonalEvents.Size = new System.Drawing.Size(267, 472);
            this.listBoxPersonalEvents.TabIndex = 2;
            // 
            // listBoxGroupEvents
            // 
            this.listBoxGroupEvents.FormattingEnabled = true;
            this.listBoxGroupEvents.Location = new System.Drawing.Point(279, 28);
            this.listBoxGroupEvents.Name = "listBoxGroupEvents";
            this.listBoxGroupEvents.Size = new System.Drawing.Size(267, 472);
            this.listBoxGroupEvents.TabIndex = 3;
            // 
            // labelPersonalEvents
            // 
            this.labelPersonalEvents.AutoSize = true;
            this.labelPersonalEvents.Location = new System.Drawing.Point(3, 12);
            this.labelPersonalEvents.Name = "labelPersonalEvents";
            this.labelPersonalEvents.Size = new System.Drawing.Size(115, 13);
            this.labelPersonalEvents.TabIndex = 4;
            this.labelPersonalEvents.Text = "Személyes Események";
            // 
            // labelGroupEvents
            // 
            this.labelGroupEvents.AutoSize = true;
            this.labelGroupEvents.Location = new System.Drawing.Point(276, 12);
            this.labelGroupEvents.Name = "labelGroupEvents";
            this.labelGroupEvents.Size = new System.Drawing.Size(101, 13);
            this.labelGroupEvents.TabIndex = 5;
            this.labelGroupEvents.Text = "Csoport Események";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Esemény módosítása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(552, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Esemény törlése";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UserInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControlUserInterface);
            this.Name = "UserInterfaceForm";
            this.Text = "Connecting Companies";
            this.tabControlUserInterface.ResumeLayout(false);
            this.tabPageUserProfile.ResumeLayout(false);
            this.tabPageGroupProfile.ResumeLayout(false);
            this.tabPageCalendar.ResumeLayout(false);
            this.tabPageCalendar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlUserInterface;
        private System.Windows.Forms.TabPage tabPageUserProfile;
        private System.Windows.Forms.TabPage tabPageGroupProfile;
        private System.Windows.Forms.TabPage tabPageCalendar;
        private System.Windows.Forms.GroupBox groupBoxPersonalFunctions;
        private System.Windows.Forms.GroupBox groupBoxPersonalInformation;
        private System.Windows.Forms.GroupBox groupBoxGroupFunctions;
        private System.Windows.Forms.GroupBox groupBoxGroupInformation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelGroupEvents;
        private System.Windows.Forms.Label labelPersonalEvents;
        private System.Windows.Forms.ListBox listBoxGroupEvents;
        private System.Windows.Forms.ListBox listBoxPersonalEvents;
        private System.Windows.Forms.Button buttonCreateNewEvent;
    }
}