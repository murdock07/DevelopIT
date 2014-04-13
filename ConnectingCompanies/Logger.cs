using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectingCompanies
{
    class Logger
    {
        Exception ex;
        string user;
        DateTime timeStamp;

        public Logger(Exception ex, string user, DateTime timeStamp)
        {
            this.ex = ex;
            this.user = user;
            this.timeStamp = timeStamp;

            LogToConsole();
            LogToFile();
        }

        private void LogToConsole()
        {
            Console.WriteLine("Felhasználó: {0}\nIdőpont: {1}\nHibaüzenet:\n {2}",user,timeStamp,ex.Message);
        }
        private void LogToFile()
        {

        }
    }
}
