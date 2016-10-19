using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraction
{
    public class LogToFile : ILogger
    {
        public void Logla(string mesaj)
        {
            //System.IO.File.WriteAllText(Server.MapPath("~/") + "\\log.txt", mesaj);
            //System.IO.File.WriteAllText(Application.StartupPath + "\\log.txt", mesaj);

            MessageBox.Show("Mesajınız dosyaya kaydedildi");
        }
    }
}
