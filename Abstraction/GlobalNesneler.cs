using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public static class GlobalNesneler
    {
        public static ILogger Logger = new LogToDatabase();
        public static ILoggerManager LoggerManager = new LoggerManager2();

    }
}
