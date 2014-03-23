using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectingCompanies.Forms
{
    public partial class ModifyEventDialogForm : Form
    {
        public ModifyEventDialogForm()
        {
            InitializeComponent();
        }

        private void buttonSaveNewEvent_Click(object sender, EventArgs e)
        {
            //adatok csomagolása
            //visszajelzés
            MessageBox.Show("Mentve");
            //bezárás
            this.Close();
        }

        private void buttonCloseNewEventDialog_Click(object sender, EventArgs e)
        {
            //Figyelmeztetés
            MessageBox.Show("Biztosan bezárja?", "Figyelmeztetés", MessageBoxButtons.YesNo);
            //Bezárás
            this.Close();
        }

        private void buttonInviteUser_Click(object sender, EventArgs e)
        {
            //meghívottak hozzáadása
        }

        private void buttonCancelInvitation_Click(object sender, EventArgs e)
        {
            //meghívás visszavonása
        }
    }
}
