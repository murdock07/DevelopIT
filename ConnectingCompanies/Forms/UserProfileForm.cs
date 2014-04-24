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
        public UserInterfaceForm(string user)
        {
            InitializeComponent();
            GetUserName(user);
        }

        private void GetUserName(string user)
        {
            var menu = this.Controls.Find("menuStrip", true);
            MenuStrip ms = (MenuStrip)menu[0];
            Console.WriteLine(menu);

            List<ToolStripItem> menuItems = new List<ToolStripItem>();
            foreach (ToolStripItem item in ms.Items)
            {
                menuItems.Add(item);
            }
            Console.WriteLine(menuItems);
            menuItems[0].Text = "Bejelentkezve: " + user;
        }

        private void kijelentkezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void hátralévőIdőToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //reset timer
        }   
        
        #region Felhasználó
        //----------------------
        private void buttonUserNewMail_Click(object sender, EventArgs e)
        {
            NewMailForm NMF = new NewMailForm();
            NMF.Show();
        }
        private void buttonUserOpenMail_Click(object sender, EventArgs e)
        {

        }
        private void buttonUserDeleteMail_Click(object sender, EventArgs e)
        {

        }
        private void buttonUserModifyData_Click(object sender, EventArgs e)
        {

        }
        private void buttonUserSaveData_Click(object sender, EventArgs e)
        {

        }
        private void buttonUserUploadImage_Click(object sender, EventArgs e)
        {

        }
        //----------------------
        #endregion

        #region Csoport
        //----------------------
        private void buttonGroupNewMail_Click(object sender, EventArgs e)
        {

        }
        private void buttonGroupOpenMail_Click(object sender, EventArgs e)
        {

        }
        private void buttonGroupDeleteMail_Click(object sender, EventArgs e)
        {

        }
        private void buttonGroupOpenOffer_Click(object sender, EventArgs e)
        {

        }
        private void buttonGroupDeleteOffer_Click(object sender, EventArgs e)
        {

        }
        private void buttonGroupUploadImage_Click(object sender, EventArgs e)
        {

        }
        private void buttonGroupModifyData_Click(object sender, EventArgs e)
        {

        }
        private void buttonGroupSaveData_Click(object sender, EventArgs e)
        {

        }
        private void buttonGroupNewOffer_Click(object sender, EventArgs e)
        {
            NewOfferForm NOF = new NewOfferForm();
            NOF.Show();
        }
        //----------------------
        #endregion

        #region Naptár
        //----------------------
        private void buttonCreateNewEvent_Click(object sender, EventArgs e)
        {
            AddEventDialogForm AEDF = new AddEventDialogForm();
            AEDF.Show();
        }
        private void buttonModifyEvent_Click(object sender, EventArgs e)
        {
            ModifyEventDialogForm MEDF = new ModifyEventDialogForm();
            MEDF.Show();
        }
        private void buttonDeleteEvent_Click(object sender, EventArgs e)
        {

        }
        //----------------------
        #endregion

        #region Keresés
        //----------------------
        private void buttonClearSearchParameters_Click(object sender, EventArgs e)
        {

        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
        //----------------------
        #endregion

        #region Admin
        //----------------------

        //----------------------
        #endregion
    }
}
