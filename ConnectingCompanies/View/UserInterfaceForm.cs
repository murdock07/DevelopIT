using Adatkezelő;
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
        private Session currentSession;
        private Timer sessionTimer;
        List<ToolStripItem> menuItems;

        public UserInterfaceForm(Session cs)
        {
            InitializeComponent();
            currentSession = cs;
            GetMenuStripItems();
            GetUserName();
            sessionTimer = currentSession.Timer;
            sessionTimer.Tick += sessionTimer_Tick;

        }

        void sessionTimer_Tick(object sender, EventArgs e)
        {
            if (currentSession.SessionTimeOut)
            {
                this.Close();
            }
            else
            {
                string min = (currentSession.Sec == 0) ? (currentSession.Min + 1).ToString() : currentSession.Min.ToString();
                string sec = (currentSession.Sec < 10) ? ("0" + currentSession.Sec) : currentSession.Sec.ToString();
                menuItems[2].Text = "Hátralévő idő: " + min + ":" + sec;
            }
        }

        private void GetMenuStripItems()
        {
            var menu = this.Controls.Find("menuStrip", true);
            MenuStrip ms = (MenuStrip)menu[0];

            menuItems = new List<ToolStripItem>();
            foreach (ToolStripItem item in ms.Items)
            {
                menuItems.Add(item);
            }
        }
        private void GetUserName()
        {
            menuItems[0].Text = "Bejelentkezve: " + currentSession.CurrentUser.UserName;
        }

        private void kijelentkezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentSession.Timer.Stop();
            currentSession.Timer.Dispose();
            this.Close();
        }
        private void hátralévőIdőToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentSession.ResetSession();
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
