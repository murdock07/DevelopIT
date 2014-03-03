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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.tabControlUserInterface.SuspendLayout();
            this.tabPageUserProfile.SuspendLayout();
            this.tabPageGroupProfile.SuspendLayout();
            this.tabPageCalendar.SuspendLayout();
            this.groupBoxPersonalInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUserInterface
            // 
            this.tabControlUserInterface.Controls.Add(this.tabPageUserProfile);
            this.tabControlUserInterface.Controls.Add(this.tabPageGroupProfile);
            this.tabControlUserInterface.Controls.Add(this.tabPageCalendar);
            this.tabControlUserInterface.Controls.Add(this.tabPageSearch);
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
            this.groupBoxPersonalInformation.Controls.Add(this.button5);
            this.groupBoxPersonalInformation.Controls.Add(this.button4);
            this.groupBoxPersonalInformation.Controls.Add(this.button3);
            this.groupBoxPersonalInformation.Controls.Add(this.textBox7);
            this.groupBoxPersonalInformation.Controls.Add(this.label8);
            this.groupBoxPersonalInformation.Controls.Add(this.groupBox1);
            this.groupBoxPersonalInformation.Controls.Add(this.dateTimePicker1);
            this.groupBoxPersonalInformation.Controls.Add(this.textBox3);
            this.groupBoxPersonalInformation.Controls.Add(this.label7);
            this.groupBoxPersonalInformation.Controls.Add(this.textBox5);
            this.groupBoxPersonalInformation.Controls.Add(this.label5);
            this.groupBoxPersonalInformation.Controls.Add(this.textBox6);
            this.groupBoxPersonalInformation.Controls.Add(this.label6);
            this.groupBoxPersonalInformation.Controls.Add(this.label3);
            this.groupBoxPersonalInformation.Controls.Add(this.textBox4);
            this.groupBoxPersonalInformation.Controls.Add(this.label4);
            this.groupBoxPersonalInformation.Controls.Add(this.textBox2);
            this.groupBoxPersonalInformation.Controls.Add(this.label2);
            this.groupBoxPersonalInformation.Controls.Add(this.textBox1);
            this.groupBoxPersonalInformation.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználó neve:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(323, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lakhely:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Születési idő:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(105, 97);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(323, 20);
            this.textBox4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Születési hely:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(105, 222);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(323, 20);
            this.textBox5.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Beosztás:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(105, 168);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(323, 20);
            this.textBox6.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cég:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 195);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(323, 20);
            this.textBox3.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cég címe:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 123);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(323, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(248, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 200);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profil kép";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Magamról:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(7, 269);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(235, 194);
            this.textBox7.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 469);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Adatok módosítása";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(128, 469);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Adatok mentése";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(295, 469);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Kép feltöltés";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(752, 511);
            this.tabPageSearch.TabIndex = 3;
            this.tabPageSearch.Text = "Keresés";
            this.tabPageSearch.UseVisualStyleBackColor = true;
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
            this.groupBoxPersonalInformation.ResumeLayout(false);
            this.groupBoxPersonalInformation.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPageSearch;
    }
}