using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbázissrendszerek_2_beadandó.Exceptions
{
    public class TulsokemeletException : Exception
    {
        public TulsokemeletException()
        {
        }

        public TulsokemeletException(string message)
            : base(message)
        {
            message = "Az emeletek száma túl sok.";
        }
    }
}
