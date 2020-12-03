using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbázissrendszerek_2_beadandó.Models.Records
{
    class Haz
    {

        private string epitese;
        public string Epitese
        {
            get
            {
                return epitese;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Kérem adjon meg egy értéket a ház építéséhez.");
                }
                epitese = value;
            }
        }

        // Építése pl tégla 
        // Szobák száma pl 2
        // Emelet pl 1
        // Fűtés pl padló
        // Utca ház szám 
        // Város
        // Irányítószám
        // Típus Enum Kertes Társas

    }
}
