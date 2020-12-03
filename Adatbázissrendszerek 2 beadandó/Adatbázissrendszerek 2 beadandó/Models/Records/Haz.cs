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

        #region Fűtés

        private string futes;

        public string Futes
        {
            get
            {
                return futes;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Kérem adjon meg egy értéket a ház fűtésének.");
                }
                futes = value;
            }
        }

        #endregion

        #region Város

        private string varos;

        public string Varos
        {
            get
            {
                return varos;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Kérem adjon meg egy értéket a ház városának.");
                }
                 varos = value;
            }
        }

        #endregion

        #region Irányító szám

        private string iszam;

        public string Iszam
        {
            get
            {
                return iszam;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Kérem adjon meg egy értéket a ház irányítószámának.");
                }
                if (value.Length > 4)
                {
                    throw new Iszamnemmegfeleoformatum();
                }
                iszam = value;
            }
        }

        #endregion

        #region Típus
        private string tipus;

        public string Tipus
        {
            get
            {
                return tipus;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Kérem adjon meg egy értéket a ház típusának");
                }
                tipus = value;
            }
        }
        #endregion

    }
}
