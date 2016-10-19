using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraction
{
    public class LogToDatabase : ILogger
    {
        public void Logla(string mesaj)
        {
            //DatabaseContext db = new DatabaseContext();
            //db.Log.Add(new Log()
            //{
            //    Text = mesaj
            //});
            //db.SaveChanges();

            MessageBox.Show("Mesajınız veritabanına kaydedildi");
        }
    }
}
