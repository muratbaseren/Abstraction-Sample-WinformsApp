using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraction
{
    public class LogToEventViewer : ILogger
    {
        public void Logla(string mesaj)
        {
            //string sSource;
            //string sLog;

            //sSource = "dotNET Sample App";
            //sLog = "Application";

            //if (!EventLog.SourceExists(sSource))
            //    EventLog.CreateEventSource(sSource, sLog);

            //EventLog.WriteEntry(sSource, mesaj);
            //EventLog.WriteEntry(sSource, mesaj,
            //    EventLogEntryType.Warning, 234);

            MessageBox.Show("Mesajınız event viewer'a kaydedildi");

        }
    }
}
