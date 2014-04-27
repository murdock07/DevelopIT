using ConnectingCompanies.Controller;
using ConnectingCompanies.Interface;
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
    public partial class AddEventDialogForm : Form
    {
        private Session sess;
        private IAddEventHandler aeh = new AddEventHandler();

        public AddEventDialogForm(Session sess)
        {
            InitializeComponent();
            listBoxUsersToInvite.DataSource = aeh.GetAllUsers();//megjelenítjük az összes felhasználót//vagy csak azokat akikkel egy csoportban van?
            this.sess = sess;
        }

        //nem példányosítunk....
        //Controller.AddEventHandler aeh = new Controller.AddEventHandler();
        private void buttonSaveNewEvent_Click(object sender, EventArgs e)
        {
            if (textBoxEventPlace.Text == "" || textBoxEventName.Text == "" || textBoxDescription.Text == "" || invitedUsers.Count() < 2 && !radioButtonGroup.Checked)
            {//adjon meg minden bemeneti mezőbe értéket...és legyen kiválasztva legalább 2 ember, vagy a csoportos lehetőség
                MessageBox.Show("Hibás adatbevitel");
            }
            else
            {
                try
                {
                    aeh.CreateEvent(sess.CurrentUser, radioButtonGroup.Checked, textBoxEventName.Text, textBoxDescription.Text, textBoxEventPlace.Text, dateTimePickerEventDate.Value, invitedUsers);
                    //adatok csomagolása
                    //visszajelzés
                    MessageBox.Show("Elküldve");
                    //bezárás
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /*OK*/

        private void buttonCloseNewEventDialog_Click(object sender, EventArgs e)
        {
            //Figyelmeztetés
            MessageBox.Show("Biztosan bezárja?", "Figyelmeztetés", MessageBoxButtons.YesNo);
            //Bezárás
            this.Close();
        }

        private List<Adatkezelő.User> invitedUsers = new List<Adatkezelő.User>();
        /*OK*/

        private void buttonInviteUser_Click(object sender, EventArgs e)
        {
            if (listBoxUsersToInvite.SelectedIndex != -1)//ha kiválasztott usert
            {
                if (!invitedUsers.Contains(listBoxUsersToInvite.SelectedItem))
                {//ne tudjon duplikálni
                    invitedUsers.Add(listBoxUsersToInvite.SelectedItem as Adatkezelő.User);//elmentjük
                    listBoxUsersInvited.DataSource = null;
                    listBoxUsersInvited.DataSource = invitedUsers;  //megjelenítjük
                }
            }
            //meghívottak hozzáadása
        }

        /*OK*/

        private void buttonCancelInvitation_Click(object sender, EventArgs e)
        {
            if (listBoxUsersInvited.SelectedIndex != -1)//ha választott ki visszavonandó usert
            {
                invitedUsers.Remove(listBoxUsersInvited.SelectedItem as Adatkezelő.User);
                listBoxUsersInvited.DataSource = null;//kell....
                listBoxUsersInvited.DataSource = invitedUsers;
            }
            //meghívás visszavonása
        }

        /*OK*/

        private void radioButtonGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGroup.Checked)//ha csoportos akkor ne válasszon ki emereeket
            {
                listBoxUsersInvited.Enabled = false;
                listBoxUsersToInvite.Enabled = false;
                buttonCancelInvitation.Enabled = false;
                buttonInviteUser.Enabled = false;
            }
        }

        /*OK*/

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUser.Checked)
            {
                listBoxUsersToInvite.Enabled = true;
                listBoxUsersInvited.Enabled = true;
                buttonCancelInvitation.Enabled = true;
                buttonInviteUser.Enabled = true;
            }
        }
    }
}