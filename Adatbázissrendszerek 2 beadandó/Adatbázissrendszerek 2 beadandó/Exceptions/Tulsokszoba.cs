using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbázissrendszerek_2_beadandó.Exceptions
{
    public class TulsokszobaszamException : Exception
    {
        public TulsokszobaszamException()
        {
        }

        public TulsokszobaszamException(string message)
            : base(message)
        {
            message = "A szobák száma túl sok.";
        }
    }
}
