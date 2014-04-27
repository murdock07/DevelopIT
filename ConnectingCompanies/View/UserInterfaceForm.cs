﻿using Adatkezelő;
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

        /**/
        private Controller.AddEventHandler aeh = new Controller.AddEventHandler();//interface...

        public UserInterfaceForm(Session cs)
        {
            InitializeComponent();
            currentSession = cs;
            GetMenuStripItems();
            GetUserName();
            sessionTimer = currentSession.Timer;
            sessionTimer.Tick += sessionTimer_Tick;

            //feltöltjük a listboxPersonalEventset azokkal az eseményekkel melyeket ő hozott létre
            listBoxPersonalEvents.DataSource = aeh.GetPersonalEvents(currentSession.CurrentUser);
            //feltöltjük a listát azokkal az eseményekkel melyek kapcsolatosak az ő csoportjaival
            listBoxGroupEvents.DataSource = aeh.GetGroupEvents(currentSession.CurrentUser);
            HideLabels();//kezdetben nincs kiválasztva semmi, ne legyenek fals labelek
            setUserProfileDatas();

            //--// pictureBoxUserPicture image-ét beállítani
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
                buttonUserUploadImage.Enabled = true;
                setUserProfileFields(true);
            }
        }

        private void buttonUserSaveData_Click(object sender, EventArgs e)
        {
            if (buttonUserSaveData.Enabled)
            {
                buttonUserSaveData.Enabled = false;
                buttonUserUploadImage.Enabled = false;
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
            /**/
            using (AddEventDialogForm adf = new AddEventDialogForm(currentSession))
            {
                adf.ShowDialog();
            }
        }

        private void buttonModifyEvent_Click(object sender, EventArgs e)
        {
            /**/
            using (ModifyEventDialogForm medf = new ModifyEventDialogForm(currentSession))
            {
                medf.ShowDialog();
            }
        }

        private void buttonDeleteEvent_Click(object sender, EventArgs e)
        {
            //tegyük fel,hogy csak azokat az eseményeket tudja törölni melyeket ő hozott létre
            //ha egy csoport tagja és meg van hívva, akkor nem tudja törölni, szal csak az első listboxban tud nyúkálni
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

        /**/

        private void buttonClearSearchParameters_Click(object sender, EventArgs e)
        {//szerintem..
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            checkBox1.Checked = false;
            listBoxSearchResults.DataSource = null;
        }

        /**/

        private void buttonSearch_Click(object sender, EventArgs e)
        {//tegyük fel, hogy egyszerre csak 1 mező alapján lehet keresni
            //ha több bementi adato adott meg akkor nem keresünk, talán így a legegyszerűbb
            //mindig egy mezőben lehet csak érték-ha nem akkor hiba
            //idő alapján keresni=>checkbox check=>többi bemenet=""
            Controller.SearchHandler sh = new Controller.SearchHandler();//interface
            if (comboBoxSearchGroupOption.SelectedIndex != -1)
            {
                if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "" & !checkBox1.Checked)
                {
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Felhasználó")//ha felhasználót akar keresni
                        listBoxSearchResults.DataSource = sh.FindUserByName(textBox1.Text);
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Ajánlat")//ha ajánlatot keres//keződ cég alapján
                        listBoxSearchResults.DataSource = sh.FindOfferBySCompany(textBox1.Text);
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Csoport")
                        listBoxSearchResults.DataSource = sh.GetGroupsByName(textBox1.Text);
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Esemény")
                        listBoxSearchResults.DataSource = sh.GetEventsByName(textBox1.Text);
                }//első textbox alapján akar keresni /többi üres,és nincs checked
                else if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text == "" & !checkBox1.Checked)
                {
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Felhasználó")
                        listBoxSearchResults.DataSource = sh.GetUsersByAddr(textBox2.Text);
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Ajánlat")
                        listBoxSearchResults.DataSource = sh.GetOffersByDestCompany(textBox2.Text); //fogadó cég
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Csoport")
                        listBoxSearchResults.DataSource = sh.GetGroupsByAdd(textBox2.Text);
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Esemény")
                        listBoxSearchResults.DataSource = sh.GetGroupsByDesc(textBox2.Text);//leírás alapján
                }//második textbox alapján akar keresni/többi üres,és nincs checked
                else if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text != "" & !checkBox1.Checked)
                {
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Felhasználó")
                        listBoxSearchResults.DataSource = sh.GetUserByBPlace(textBox3.Text);
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Ajánlat")
                        listBoxSearchResults.DataSource = sh.GetOffersByName(textBox3.Text);//megnevezés
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Csoport")
                        listBoxSearchResults.DataSource = sh.GetGroupsByCLeader(textBox3.Text);//cégvezető
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Esemény")
                        listBoxSearchResults.DataSource = sh.GetEventsByPlace(textBox3.Text);
                }//harmadik textbox alapján akar keresni/többi üres és nincs checked
                else if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" & checkBox1.Checked)
                {
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Felhasználó")
                        listBoxSearchResults.DataSource = sh.GetUserByBDate(dateTimePicker1.Value);  //születési idő alapján
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Ajánlat")
                        listBoxSearchResults.DataSource = sh.GetOffersByDateTime(dateTimePicker1.Value);   //kezdő és végpont közé esik a megadott időpont
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Csoport")
                        listBoxSearchResults.DataSource = sh.GetGroupsByCreateDate(dateTimePicker1.Value);  //alapítás dátuma alapján
                    if (comboBoxSearchGroupOption.SelectedItem.ToString() == "Esemény")
                        listBoxSearchResults.DataSource = sh.GetEventsByDate(dateTimePicker1.Value);    //esemény időpont alapján
                }//minden üres, checked=true => csak dátum alapján akar keresni
                else MessageBox.Show("Hibás keresés!");//több helyre adott meg értéket
            }
        }

        /**/

        private void tabControlUserInterface_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as TabControl).SelectedTab.Name == "tabPageSearch")
            {
                BuildGui();
            }
        }

        /**/

        private void BuildGui()//labelek tartalmának beállítása, ha kell elrejtés
        {
            if (tabControlUserInterface.SelectedTab.Name == "tabPageSearch")
            {
                ComboBox combo = comboBoxSearchGroupOption;
                if (combo.SelectedItem != null)//ha van kiválasztva valami
                {
                    ShowLabels();//legyenek labelek, ha már választott ki valamit
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
                        label4.Text = "Dátum:";     //olyanokat fogunk majd visszaadni melynek keződ és vég időpontja közé esik ez az időpont
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
                else//nincs kiválasztva szempont ne legyenek label-ek
                { HideLabels(); }
            }
        }

        /**/

        private void ShowLabels()
        {
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();     //intervallumon belül
        }

        /**/

        private void HideLabels()//elrejti
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();     //intervallumon belül
        }

        /**/

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