using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Adatbázissrendszerek_2_beadandó.Models.Records;
using Adatbázissrendszerek_2_beadandó.Models.Manager;


namespace Adatbázissrendszerek_2_beadandó
{
    public partial class haz_form : Form
    {
        static List<Haz> temp= new List<Haz>();
        HazakTabla ht = new HazakTabla();
        //public DataTable dt = new DataTable();
        public haz_form()
        {
            InitializeComponent();
        }
        
        #region
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void cb_tipus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Típusok
        private void cb_tipus_DropDown(object sender, EventArgs e)
        {
            cb_tipus.Items.Clear();
            cb_tipus.Items.Add(Tipus.Emeletesház);
            cb_tipus.Items.Add(Tipus.Kertesház);
            cb_tipus.Items.Add(Tipus.Társasház);

        }
        #endregion

        #region Beszúrás
        private void btn_Beszuras_Click(object sender, EventArgs e)
        {
            try
            {
                Haz haz = new Haz(
               tb_epitese,
               tb_szszam,
               tb_emelet,
               tb_futes,
               tb_varos,
               tb_iszam,
               cb_tipus,
               tb_utca
               );
                bool ex = ht.Checkiszam(haz.Iszam);
                if (!ex)
                {
                    throw new Exception("Az irányítószám nem feleltt meg a szerver oldli kritériumoknak");
                }
                ht.Insert(haz);
                dataGridView1.Rows.Clear();
                //DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                //row.Cells[0].Value = "első oszlop";
                //row.Cells[1].Value = "második oszlop";
                //dataGridView1.Rows.Add(row);
                temp.Clear();
                temp = ht.Select();
                for (int i = 0; i < temp.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = temp[i].Epitese;
                    dataGridView1.Rows[i].Cells[1].Value = temp[i].Szobakszama;
                    dataGridView1.Rows[i].Cells[2].Value = temp[i].Emelet;
                    dataGridView1.Rows[i].Cells[3].Value = temp[i].Futes;
                    dataGridView1.Rows[i].Cells[4].Value = temp[i].Varos;
                    dataGridView1.Rows[i].Cells[5].Value = temp[i].Iszam;
                    dataGridView1.Rows[i].Cells[6].Value = temp[i].Tipus;
                    dataGridView1.Rows[i].Cells[7].Value = temp[i].Hszam;
                }
                tb_epitese.Clear();
                tb_szszam.Clear();
                tb_emelet.Clear();
                tb_futes.Clear();
                tb_varos.Clear();
                tb_iszam.Clear();
                tb_utca.Clear();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);   
            }
        }

        #endregion

        #region Törlés
        private void btn_Torles_Click(object sender, EventArgs e)
        {
            int help = dataGridView1.CurrentCell.RowIndex;
            Haz torlendo = new Haz(dataGridView1.Rows[help].Cells[0].Value.ToString(),
                                   dataGridView1.Rows[help].Cells[1].Value.ToString(),
                                   dataGridView1.Rows[help].Cells[2].Value.ToString(),
                                   dataGridView1.Rows[help].Cells[3].Value.ToString(),
                                   dataGridView1.Rows[help].Cells[4].Value.ToString(),
                                   dataGridView1.Rows[help].Cells[5].Value.ToString(),
                                   dataGridView1.Rows[help].Cells[6].Value.ToString(),
                                   dataGridView1.Rows[help].Cells[7].Value.ToString());
            ht.Del(torlendo);
            temp.Clear();
            temp = ht.Select();
            for (int i = 0; i < temp.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = temp[i].Epitese;
                dataGridView1.Rows[i].Cells[1].Value = temp[i].Szobakszama;
                dataGridView1.Rows[i].Cells[2].Value = temp[i].Emelet;
                dataGridView1.Rows[i].Cells[3].Value = temp[i].Futes;
                dataGridView1.Rows[i].Cells[4].Value = temp[i].Varos;
                dataGridView1.Rows[i].Cells[5].Value = temp[i].Iszam;
                dataGridView1.Rows[i].Cells[6].Value = temp[i].Tipus;
                dataGridView1.Rows[i].Cells[7].Value = temp[i].Hszam;
            }
        }
        #endregion

        #region 
        private void Form1_Activated(object sender, EventArgs e)
        {

        }
        private void hiba_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
    }
}
