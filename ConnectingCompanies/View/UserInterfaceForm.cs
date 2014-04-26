using Adatkezelő;
using ConnectingCompanies.Controller;
using ConnectingCompanies.Forms;
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
    public partial class UserInterfaceForm : Form
    {
        private Session currentSession;
        private Timer sessionTimer;
        private List<ToolStripItem> menuItems;

        public UserInterfaceForm(Session cs)
        {
            InitializeComponent();
            currentSession = cs;
            GetMenuStripItems();
            GetUserName();
            sessionTimer = currentSession.Timer;
            sessionTimer.Tick += sessionTimer_Tick;
            setUserProfileDatas();
            //--// pictureBoxUserPicture image-ét beállít
        }

        private void setUserProfileDatas()
        {
            textBoxUserName.Text = currentSession.CurrentUser.Profile.DisplayName;
            textBoxUserAddress.Text = currentSession.CurrentUser.Profile.PersonalAddress;
            textBoxUserBirthPlace.Text = currentSession.CurrentUser.Profile.BirthPlace;
            dateTimePickerUserBirthDate.Value = currentSession.CurrentUser.Profile.BirthDate;
            textBoxUserDescription.Text = currentSession.CurrentUser.Profile.Description;
            textBoxUserGroupPost.Text = currentSession.CurrentUser.Rank;
            if (currentSession.CurrentUser.Profile.Group != null)
            {
                textBoxUserGroupName.Text = currentSession.CurrentUser.Profile.Group.groupProfile.GroupName;
                textBoxUserGroupAddress.Text = currentSession.CurrentUser.Profile.Group.groupProfile.GroupAddress;
            }
            
        }

        private void sessionTimer_Tick(object sender, EventArgs e)
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
        }

        private void buttonUserOpenMail_Click(object sender, EventArgs e)
        {
        }

        private void buttonUserDeleteMail_Click(object sender, EventArgs e)
        {
        }

        private void setUserProfileFields(bool enable)
        {
            textBoxUserName.Enabled = enable;
            textBoxUserAddress.Enabled = enable;
            textBoxUserBirthPlace.Enabled = enable;
            dateTimePickerUserBirthDate.Enabled = enable;
            textBoxUserDescription.Enabled = enable;
            textBoxUserGroupPost.Enabled = enable;
        }

        private void buttonUserModifyData_Click(object sender, EventArgs e)
        {
            if (buttonUserModifyData.Enabled)
            {
                buttonUserModifyData.Enabled = false;
                buttonUserSaveData.Enabled = true;
                setUserProfileFields(true);
            }
        }

        private void buttonUserSaveData_Click(object sender, EventArgs e)
        {
            if (buttonUserSaveData.Enabled)
            {
                buttonUserSaveData.Enabled = false;
                buttonUserModifyData.Enabled = true;
                setUserProfileFields(false);
                IUserHandler iuh = new UserHandler();
                iuh.saveUserProfileDatas(currentSession.CurrentUser.Id, textBoxUserName.Text, textBoxUserAddress.Text, textBoxUserBirthPlace.Text,
                    dateTimePickerUserBirthDate.Value, textBoxUserDescription.Text, textBoxUserGroupPost.Text);
            }
        }

        private void buttonUserUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.FileOk += ofd_FileOk;
                ofd.ShowDialog();

                if (newUserPicture != "")//ha választott ki valamit
                {
                    //--//új kép hozzárendelése a felhasználóhoz
                    //--//picturebox frissítése
                    newUserPicture = "";//ha később akar..
                }
            }
        }

        private string newUserPicture = ""; //Viktornak: ez mi?

        private void ofd_FileOk(object sender, CancelEventArgs e)
        {//megkapja a kiválasztott elérési utat az adattag
            if (!e.Cancel)//ha választott ki valamit
            { newUserPicture = (sender as OpenFileDialog).FileName; }
        }

        //----------------------

        #endregion Felhasználó

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

        private string newCompanyPicutre = "";

        private void buttonGroupUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.FileOk += ofd_FileOkCompany;
                ofd.ShowDialog();
                if (newCompanyPicutre != "")//ha választott ki valamit
                {
                    //--//kép mentése a céghez
                    //--//pictureBoxCompany frissítése
                    newCompanyPicutre = "";//ha akar még módosítani
                }
            }
        }

        private void ofd_FileOkCompany(object sender, CancelEventArgs e)
        {//megkapja a kiválasztott elérési utat az adattag
            if (!e.Cancel)//ha választott ki valamit
            { newCompanyPicutre = (sender as OpenFileDialog).FileName; }
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

        #endregion Csoport

        #region Naptár

        //----------------------
        private void buttonCreateNewEvent_Click(object sender, EventArgs e)
        {
        }

        private void buttonModifyEvent_Click(object sender, EventArgs e)
        {
        }

        private void buttonDeleteEvent_Click(object sender, EventArgs e)
        {
        }

        //----------------------

        #endregion Naptár

        #region Keresés

        //----------------------
        private void buttonClearSearchParameters_Click(object sender, EventArgs e)
        {
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
        }

        //----------------------

        #endregion Keresés

        #region Admin

        //----------------------
        private void buttonAdminUsers_Click(object sender, EventArgs e)
        {
        }

        private void buttonAdminGroups_Click(object sender, EventArgs e)
        {
        }

        private void buttonAdminOffers_Click(object sender, EventArgs e)
        {
        }

        private void buttonAdminEvents_Click(object sender, EventArgs e)
        {
        }

        private void buttonAdminFiles_Click(object sender, EventArgs e)
        {
        }

        private void groupBoxStatistics_Paint(object sender, PaintEventArgs e)
        {
            AdminHandler.CreateStatistics(sender, e, dataGridViewStat);
        }

        private void tabControlUserInterface_TabIndexChanged(object sender, EventArgs e)
        {
        }

        //----------------------

        #endregion Admin
    }
}