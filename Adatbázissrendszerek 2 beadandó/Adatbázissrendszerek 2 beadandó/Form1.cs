﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cb_tipus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_tipus_DropDown(object sender, EventArgs e)
        {
            cb_tipus.Items.Clear();
            cb_tipus.Items.Add(Tipus.Emeletesház);
            cb_tipus.Items.Add(Tipus.Kertesház);
            cb_tipus.Items.Add(Tipus.Társasház);

        }
        
        private void btn_Beszuras_Click(object sender, EventArgs e)
        {
            Haz haz = new Haz(
                tb_epitese,
                tb_szszam,
                tb_emelet,
                tb_futes,
                tb_varos,
                tb_iszam,
                cb_tipus
                );
        }
    }
}
