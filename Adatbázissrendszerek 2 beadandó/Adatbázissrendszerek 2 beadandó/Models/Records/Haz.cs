using Adatbázissrendszerek_2_beadandó.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbázissrendszerek_2_beadandó.Models.Records
{
    class Haz
    {
        #region Építése
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
        #endregion

        #region Szobákszáma
        private string szobakszama;
        public string Szobakszama
        {
            get
            {
                return szobakszama;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Kérem adja meg a szobák számát");
                }
                if (value.Length > 3)
                {
                    throw new TulsokszobaszamException();
                }
            }
        }
        #endregion

        #region Emelet
        private string emelet;
        public string Emelet
        {
            get
            {
                return emelet;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Kérem adjon meg egy értéket a ház emeletének.");
                }
                if (value.Length > 3)
                {
                    throw new TulsokemeletException();
                }
                emelet = value;
            }
        }
        #endregion


        // Fűtés pl padló
        // Utca ház szám 
        // Város
        // Irányítószám
        // Típus Enum Kertes Társas

    }
}
