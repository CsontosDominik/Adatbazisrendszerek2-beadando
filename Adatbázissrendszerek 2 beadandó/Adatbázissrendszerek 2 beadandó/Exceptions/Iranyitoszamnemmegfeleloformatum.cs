using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbázissrendszerek_2_beadandó.Exceptions
{
    public class Iszamnemmegfeleoformatum : Exception
    {
        public Iszamnemmegfeleoformatum()
        {
        }

        public Iszamnemmegfeleoformatum(string message)
            : base(message)
        {
            message = "Az irányítószám nem megfelelő formátumban van megadva.";
        }
    }
}
