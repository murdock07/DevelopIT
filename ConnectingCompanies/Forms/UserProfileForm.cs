using ConnectingCompanies.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectingCompanies
{
    public partial class UserInterfaceForm : Form
    {
        public UserInterfaceForm()
        {
            InitializeComponent();
        }

        private void buttonCreateNewEvent_Click(object sender, EventArgs e)
        {
            AddEventDialogForm AEDF = new AddEventDialogForm();
            AEDF.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModifyEventDialogForm MEDF = new ModifyEventDialogForm();
            MEDF.Show();
        }

        private void groupBoxPersonalInformation_Enter(object sender, EventArgs e)
        {

        }

        private void tabPageUserProfile_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxPersonalMailing_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPageGroupProfile_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxGroupFunctions_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxGroupInformation_Enter(object sender, EventArgs e)
        {

        }

        private void tabPageCalendar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void labelGroupEvents_Click(object sender, EventArgs e)
        {

        }

        private void labelPersonalEvents_Click(object sender, EventArgs e)
        {

        }

        private void listBoxGroupEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxPersonalEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageSearch_Click(object sender, EventArgs e)
        {

        }

        private void listBoxPersonalMails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
