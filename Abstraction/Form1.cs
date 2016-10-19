using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GlobalNesneler.Logger.Logla(textBox1.Text);
            //GlobalNesneler.Logger.Logla("Uygulama Başladı.");
            //GlobalNesneler.Logger.Logla("Uygulama Sonladı.");
            //GlobalNesneler.Logger.Logla(".. kullanıcı giriş yaptı.");

            GlobalNesneler.LoggerManager.Logla(textBox1.Text);


            //LogToDatabase logger = new LogToDatabase();
            //logger.Logla(textBox1.Text);

            //ILogger logger = new LogToFile();
            //logger.Logla(textBox1.Text);

            //LogToFile logger = new LogToFile();
            //logger.Logla(textBox1.Text);
        }
    }
}
