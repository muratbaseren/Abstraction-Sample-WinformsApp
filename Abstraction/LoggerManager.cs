using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class LoggerManager : ILoggerManager
    {
        public void Logla(string mesaj)
        {
            ILogger logger = new LogToFile();
            logger.Logla(mesaj);

            logger = new LogToEventViewer();
            logger.Logla(mesaj);
        }
    }

    public class LoggerManager2 : ILoggerManager
    {
        public void Logla(string mesaj)
        {
            ILogger logger = new LogToDatabase();
            logger.Logla(mesaj);

            logger = new LogToFile();
            logger.Logla(mesaj);
        }
    }
}
