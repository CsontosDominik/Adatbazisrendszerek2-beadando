using Adatbázissrendszerek_2_beadandó.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adatbázissrendszerek_2_beadandó.Models.Records
{
    class Haz
    {
        #region Knstruktorok

        public Haz()
        {
        }
        public Haz(string epitese, string szszam, string emelet, string futes, string varos, string iszam, string tipus, string hszam)
        {
            this.Epitese = (epitese);
            this.Szobakszama = (szszam);
            this.Emelet = (emelet);
            this.Futes = (futes);
            this.Varos = (varos);
            this.Iszam = (iszam);
            this.Tipus = (tipus);
            this.Hszam = (hszam);
        }
        public Haz(TextBox epitese, TextBox szszam, TextBox emelet, TextBox futes, TextBox varos, TextBox iszam, ComboBox tipus, TextBox hszam)
        {
            this.Epitese = (epitese.Text);
            this.Szobakszama = (szszam.Text);
            this.Emelet = (emelet.Text);
            this.Futes = (futes.Text);
            this.Varos = (varos.Text);
            this.Iszam = (iszam.Text);
            this.Tipus = (tipus.Text);
            this.Hszam = (hszam.Text);
        }
        #endregion

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
                szobakszama = value;
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

        #region Utca házszám
        private string hszam;
        public string Hszam
        {
            get
            {
                return hszam;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Kérem adjon meg egy értéket a ház utcájának és számának.");
                }
                hszam = value;
            }
        }
        #endregion
    }
}
