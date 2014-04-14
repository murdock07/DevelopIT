using System;
using System.Collections.Generic;
using System.IO;
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

        string defaultDirectory = "./Logok/";

        public Logger(Exception ex, DateTime timeStamp)
        {
            this.ex = ex;
            this.user = Environment.UserName;
            this.timeStamp = timeStamp;

            string[] logMessage = CreateLogMessage();

            LogToConsole(logMessage);
            LogToFile(logMessage);
        }

        private string[] CreateLogMessage()
        {
            string[] log = new string[4];
            log[0] = "Felhasználó: " + user;
            log[1] = "Időpont: " + timeStamp;
            log[2] = "Hibaüzenet: " + ex.Message;
            if (ex.InnerException != null)
            {
                log[3] = "Belső kivétel: " + ex.InnerException.Message;
            }
            else
            {
                log[3] = "Belső kivétel: " + "Nincs belső kivétel";
            }
            return log;
        }

        private void LogToConsole(string[] logMessage)
        {
            foreach (var item in logMessage)
            {
                Console.WriteLine(item);
            }
        }
        private void LogToFile(string[] logMessage)
        {
            string idopont = timeStamp.Year + timeStamp.Month + timeStamp.Day + "_" +
                timeStamp.Hour + timeStamp.Minute;
            string fileName = user + "_" + idopont;
            string path = defaultDirectory + fileName + ".txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var item in logMessage)
                {
                    sw.WriteLine(item);
                }
            }
        }
    }
}
