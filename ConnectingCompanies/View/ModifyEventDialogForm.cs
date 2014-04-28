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
        private Adatkezelő.User user;
        private Adatkezelő.Event modEvent;//módosítandó személyes esemény amit kiválasztott
        private Adatkezelő.Event modEventGroup;//módosítandó csoportos esemény amit kiválasztott
        public ModifyEventDialogForm(Session s, Adatkezelő.Event modEvent, Adatkezelő.Event modEventGroup)
        {
            InitializeComponent();
            this.user = s.CurrentUser;
            this.modEvent = modEvent;
            this.modEventGroup = modEventGroup;
        }
        Controller.AddEventHandler aeh = new Controller.AddEventHandler();
        private void buttonSaveNewEvent_Click(object sender, EventArgs e)
        {
            if (textBoxEventPlace.Text != "" && textBoxEventName.Text != "" && textBoxDescription.Text != null)
            {//ne legyen üres mező
                if(radioButtonGroup.Checked&&modEventGroup!=null)//ha csoportos és van mit módosítani
                    aeh.ModifyEventsGroup(user,modEventGroup, textBoxEventName.Text, textBoxDescription.Text, textBoxEventPlace.Text, dateTimePickerEventDate.Value);
                if (radioButtonUser.Checked && modEvent != null)//ha egyéni és van mit módosítani
                    aeh.ModifyPersonalEvent(user, modEvent, textBoxEventName.Text, textBoxDescription.Text, textBoxEventPlace.Text, dateTimePickerEventDate.Value);

                //adatok csomagolása
                //visszajelzés
                MessageBox.Show("Mentve");
                //bezárás
                this.Close();
            }
            else MessageBox.Show("Hibás adatbevitel!");
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

        private void radioButtonGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGroup.Checked)
            { 
                listBoxUsersInvited.Enabled = false;
                listBoxUsersToInvite.Enabled = false;
                buttonCancelInvitation.Enabled = false;
                buttonInviteUser.Enabled = false;
            }
        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonGroup.Checked)
            {
                listBoxUsersInvited.Enabled = true;
                listBoxUsersToInvite.Enabled = true;
                buttonCancelInvitation.Enabled = true;
                buttonInviteUser.Enabled = true;
            }
        }
    }
}
