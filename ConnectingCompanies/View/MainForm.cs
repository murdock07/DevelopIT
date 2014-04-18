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
    public partial class MainForm : Form
    {
        public static adatbazisEntities entities;
        public Session currentSession;

        public MainForm()
        {
            InitializeComponent();
            entities = new adatbazisEntities();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string user = textBoxLoginUserName.Text;
            string password = textBoxLoginPassword.Text;

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

        //Normális esetben user-t fogad
        private void SetStartupScreenByUserType(string user)
        {
            /* <----------------------TEST---------------------->  */

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //Adatok összeszedése
            //User létrehozása
            //Beléptetés
        }
    }
}
