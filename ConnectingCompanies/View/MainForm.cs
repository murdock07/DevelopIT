using ConnectingCompanies.Controller;
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
    public partial class
        MainForm : Form
    {
        public static nyilvantartasEntities entities = new nyilvantartasEntities();
        public Session currentSession;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string user = textBoxLoginUserName.Text;
            string password = textBoxLoginPassword.Text;
            //???????????????????????????????
            #region
            /* string s = "";
             var v = from x in entities.felhasznalok//majd tötöld ki
                     select x;
             foreach (var item in v)
             {
                 s += (item as felhasznalok).azonosito + (item as felhasznalok).jelszo+"\n";
             }
             MessageBox.Show(s);*/
            //string s = "";
            //var v = from x in entities.esemenyek//majd tötöld ki
            //        select x;
            //foreach (var item in v)
            //{
            //    s += (item as esemenyek).idopont + " " + (item as esemenyek).Id + "" + (item as esemenyek).letrehozo.ToString() + "\n";
            //}
            //MessageBox.Show(s);
            #endregion
            try
            {
                currentSession = Controller.LoginHandler.CheckCredentials(user, password);
                Form UI = Controller.LoginHandler.SetUIByUserType(currentSession);
                UI.Show();
            }
            catch (Exception ex)
            {
                if (ex is LoginHandlerException)
                {
                    MessageBox.Show(((LoginHandlerException)ex).Uzenet);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
                new Logger(ex);
            }
        }

        private void buttonGuestLogin_Click(object sender, EventArgs e)
        {
            string user = "guest";
            string password = "guest";

            try
            {
                currentSession = Controller.LoginHandler.CheckCredentials(user, password);
                Form UI = Controller.LoginHandler.SetUIByUserType(currentSession);
                UI.Show();
            }
            catch (LoginHandlerException lhex)
            {
                MessageBox.Show(lhex.Uzenet);
                new Logger(lhex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                new Logger(ex);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string account = textBoxRegUserTag.Text;
                string password = textBoxRegPassword.Text;
                string name = textBoxRegUserName.Text;
                string address = textBoxRegAddress.Text;
                DateTime birthDate = dateTimePickerRegBirthDate.Value;

                currentSession = LoginHandler.DoRegister(account, password, name, address, birthDate);
                MessageBox.Show("Sikeres regisztráció!\nKattintson az 'OK' gombra a továbblépéshez.");
                Form UI = Controller.LoginHandler.SetUIByUserType(currentSession);
                UI.Show();
            }
            catch (UserExistsException ueeex)
            {
                MessageBox.Show(ueeex.Uzenet);
                new Logger(ueeex);
            }
            catch (LoginHandlerException lhex)
            {
                MessageBox.Show(lhex.Uzenet);
                new Logger(lhex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                new Logger(ex);
            }
        }
    }
}