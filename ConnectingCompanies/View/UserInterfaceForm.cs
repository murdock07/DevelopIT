using Adatkezelő;
using ConnectingCompanies.Controller;
using ConnectingCompanies.Exection;
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
        private IGroupHandler igh = new GroupHandler();
        private IUserHandler iuh = new UserHandler();

        IAddEventHandler aeh = new Controller.AddEventHandler();

        public UserInterfaceForm(Session cs)
        {
            InitializeComponent();
            currentSession = cs;
            GetMenuStripItems();
            GetUserName();
            sessionTimer = currentSession.Timer;
            sessionTimer.Tick += sessionTimer_Tick;
            listBoxPersonalEvents.DataSource = aeh.GetPersonalEvents(currentSession.CurrentUser);
            listBoxGroupEvents.DataSource = aeh.GetGroupEvents(currentSession.CurrentUser);
            setUserProfileDatas();
            setGroupPrilfeDatas();
            comboBoxSearchGroupOption.SelectedIndex = 1;
            if (cs.CurrentUser.Type == UserType.Guest)
            {//egy lehetséges megoldás, vendég csoportadatokat nézhessen csak...
                comboBoxSearchGroupOption.Items.Remove("Ajánlat");
                comboBoxSearchGroupOption.Items.Remove("Esemény");
                comboBoxSearchGroupOption.Items.Remove("Felhasználó");
            }
            BuildGui();
            
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
            String avatarPath = iuh.getUserAvatarPath(currentSession.CurrentUser.Id);
            if (avatarPath != null)
            {
                pictureUserPicutre.ImageLocation = avatarPath;
            }
        }

        private void setGroupPrilfeDatas()
        {
            if (currentSession.CurrentUser.Group != null)
            {
                Group userGroup = currentSession.CurrentUser.Group;
                textBoxGroupName.Text = userGroup.Name;
                textBoxGroupAddress.Text = userGroup.Address;
                Console.WriteLine("GROUPADMIN: " + userGroup.GroupAdmin.Id);
                textBoxGroupLeader.Text = userGroup.GroupAdmin.Profile.DisplayName;
                textBoxGroupMailAdress.Text = userGroup.MailAddress;
                dateTimePickerDateOfFounding.Value = userGroup.DateOfFounding == null ? DateTime.Now : (DateTime)userGroup.DateOfFounding;
                textBoxGroupDescription.Text = userGroup.Description;
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
            buttonUserUploadImage.Enabled = enable;
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
            }
        }

        private void ofd_FileOk(object sender, CancelEventArgs e)
        {
            String pictureUrl = "";
            if (!e.Cancel)
            {
                pictureUrl = (sender as OpenFileDialog).FileName;
                String newPictureUrl = iuh.saveUserAvatar(currentSession.CurrentUser.Id, pictureUrl);
                pictureUserPicutre.ImageLocation = newPictureUrl;
            }
        }

        //----------------------

        #endregion Felhasználó

        #region Csoport

        private void setGroupProfileFields(bool enable)
        {
            
            textBoxGroupName.Enabled = enable;
            textBoxGroupAddress.Enabled = enable;
            textBoxGroupMailAdress.Enabled = enable;
            dateTimePickerDateOfFounding.Enabled = enable;
            textBoxGroupDescription.Enabled = enable;
            
        }

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
            try
            {
                igh.userHavePermission(currentSession.CurrentUser.Id);
                if (buttonGroupModifyData.Enabled)
                {
                    buttonGroupModifyData.Enabled = false;
                    buttonGroupSaveData.Enabled = true;
                    setGroupProfileFields(true);
                }
            }
            catch (PermissionDeniedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonGroupSaveData_Click(object sender, EventArgs e)
        {
            try
            {
                igh.saveGroupDatas(currentSession.CurrentUser.Id);
            }
            catch (PermissionDeniedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (buttonGroupSaveData.Enabled)
                {
                    buttonGroupSaveData.Enabled = false;
                    buttonGroupModifyData.Enabled = true;
                    setGroupProfileFields(false);
                }
            }
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
            using (AddEventDialogForm adf = new AddEventDialogForm(currentSession))
            {
                adf.FormClosing += adf_FormClosing;
                adf.ShowDialog();
            }
        }
        void adf_FormClosing(object sender, FormClosingEventArgs e)
        {//nem menti el db-be?
            listBoxPersonalEvents.DataSource = aeh.GetPersonalEvents(currentSession.CurrentUser);
        }

        private void buttonModifyEvent_Click(object sender, EventArgs e)
        {
            using (ModifyEventDialogForm medf = new ModifyEventDialogForm(currentSession,listBoxPersonalEvents.SelectedItem as Event,listBoxGroupEvents.SelectedItem as Event))
            {
                medf.FormClosing += medf_FormClosing;
                medf.ShowDialog();
            }
        }
        void medf_FormClosing(object sender, FormClosingEventArgs e)
        {
            listBoxGroupEvents.DataSource = aeh.GetGroupEvents(currentSession.CurrentUser);
            listBoxPersonalEvents.DataSource = aeh.GetPersonalEvents(currentSession.CurrentUser);
        }

        private void buttonDeleteEvent_Click(object sender, EventArgs e)
        {
            //a listboxban annyi rekord lesz ahány embert meghívott az általa létrehozott eseményekre+annyi ahány csoportosat csinált..
            //pl.: csinált: 2 db csoportosat, 3 db egyénit 2 meghívottal, 2db egyénit 3 meghívottal
            //így a listbox tartalma 2+3*2+2*3= 14db, .. adatbázis táblának nem pont így kéne kinéznie
            //ha csoportost választott ki akkor törli Id alapján
            //ha kiválaszt egyet akkor azt az egy egyéni esményt törli Id alapján
            if (listBoxPersonalEvents.SelectedIndex != -1)
            {
                aeh.DeleteEvent(listBoxPersonalEvents.SelectedItem as Adatkezelő.Event);
                listBoxPersonalEvents.DataSource = aeh.GetPersonalEvents(currentSession.CurrentUser);//frissül a listbox
            }
            else
                MessageBox.Show("Nincs kiválasztott esemény!");
        }

        //----------------------

        #endregion Naptár

        #region Keresés

        //----------------------

        private void buttonClearSearchParameters_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            checkBox1.Checked = false;
            listBoxSearchResults.DataSource = null;
        }

        ISearchHandler sh = new Controller.SearchHandler();//interface

        private void buttonSearch_Click(object sender, EventArgs e)
        {   //tegyük fel, hogy egyszerre csak 1 mező alapján lehet keresni
            //ha több bementi adato adott meg akkor nem keresünk, talán így a legegyszerűbb
            //mindig egy mezőben lehet csak érték-ha nem akkor hiba
            //idő alapján keresni=>checkbox check=>többi bemenet=""

            if (comboBoxSearchGroupOption.SelectedIndex != -1)
            {
                if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "" & !checkBox1.Checked)
                {//első textbox alapján akar keresni /többi üres,és nincs checked
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Felhasználó")
                        listBoxSearchResults.DataSource = sh.GetUsers(textBox1.Text, null, null, DateTime.MinValue);
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Ajánlat")
                        listBoxSearchResults.DataSource = sh.GetOffers(null, textBox1.Text, null, DateTime.MinValue);
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Csoport")
                        listBoxSearchResults.DataSource = sh.GetGroups(textBox1.Text, null, null, DateTime.MinValue);
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Esemény")
                        listBoxSearchResults.DataSource = sh.GetEvent(textBox1.Text, null, null, DateTime.MinValue);
                }
                else if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text == "" & !checkBox1.Checked)
                {//második textbox alapján akar keresni/többi üres,és nincs checked
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Felhasználó")
                        listBoxSearchResults.DataSource = sh.GetUsers(null, textBox2.Text, null, DateTime.MinValue);
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Ajánlat")
                        listBoxSearchResults.DataSource = sh.GetOffers(null, null, textBox2.Text, DateTime.MinValue);
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Csoport")
                        listBoxSearchResults.DataSource = sh.GetGroups(null, null, textBox2.Text, DateTime.MinValue);
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Esemény")
                        listBoxSearchResults.DataSource = sh.GetEvent(null, null, textBox2.Text, DateTime.MinValue);
                }
                else if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text != "" & !checkBox1.Checked)
                {//harmadik textbox alapján akar keresni/többi üres és nincs checked
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Felhasználó")
                        listBoxSearchResults.DataSource = sh.GetUsers(null, null, textBox3.Text, DateTime.MinValue);
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Ajánlat")
                        listBoxSearchResults.DataSource = sh.GetOffers(textBox3.Text, null, null, DateTime.MinValue);
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Csoport")
                        listBoxSearchResults.DataSource = sh.GetGroups(null, textBox3.Text, null, DateTime.MinValue);
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Esemény")
                        listBoxSearchResults.DataSource = sh.GetEvent(null, textBox3.Text, null, DateTime.MinValue);
                }
                else if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" & checkBox1.Checked)
                {//minden üres, checked=true => csak dátum alapján akar keresni
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Felhasználó")
                        listBoxSearchResults.DataSource = sh.GetUsers(null, null, null, dateTimePicker1.Value);
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Ajánlat")
                        listBoxSearchResults.DataSource = sh.GetOffers(null, null, null, dateTimePicker1.Value);
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Csoport")
                        listBoxSearchResults.DataSource = sh.GetGroups(null, null, null, dateTimePicker1.Value);
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Esemény")
                        listBoxSearchResults.DataSource = sh.GetEvent(null, null, null, dateTimePicker1.Value);
                }
                else MessageBox.Show("Hibás keresés!");//több helyre adott meg értéket
            }
        }

        private void tabControlUserInterface_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as TabControl).SelectedTab.Name == "tabPageSearch")
            {
                BuildGui();
            }
        }

        private void BuildGui()//labelek tartalmának beállítása
        {
                ComboBox combo = comboBoxSearchGroupOption;
                if (combo.SelectedItem != null)//ha van kiválasztva valami
                {
                    if (combo.SelectedItem.ToString() == "Felhasználó")
                    {
                        label1.Text = "Neve";
                        label2.Text = "Címe:";
                        label3.Text = "Szül hely:";
                        label4.Text = "Szül. idő:";
                    }
                    if (combo.SelectedItem.ToString() == "Ajánlat")
                    {
                        label1.Text = "Kezdő cég:";
                        label2.Text = "Fogadó cég:";
                        label3.Text = "Megnevezés:";
                        label4.Text = "Dátum:";     //kezdő és vég időpontja közé esik ez az időpont
                    }
                    if (combo.SelectedItem.ToString() == "Csoport")
                    {
                        label1.Text = "Cégnév:";
                        label2.Text = "Telephely:";
                        label3.Text = "Cégvezető:";
                        label4.Text = "Dátum:";     //alapítás dátuma
                    }
                    if (combo.SelectedItem.ToString() == "Esemény")
                    {
                        label1.Text = "Megnevezés:";
                        label2.Text = "Leírás:";
                        label3.Text = "Helyszín:";
                        label4.Text = "Időpont:";
                    }
            }
        }

        private void comboBoxSearchGroupOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildGui();//labelek tartalmának beállítása szempont szerint
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