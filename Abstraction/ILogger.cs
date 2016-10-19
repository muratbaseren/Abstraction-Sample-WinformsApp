using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public interface ILogger
    {
        void Logla(string mesaj);
    }

    public interface ILoggerManager
    {
        void Logla(string mesaj);
    }
}
