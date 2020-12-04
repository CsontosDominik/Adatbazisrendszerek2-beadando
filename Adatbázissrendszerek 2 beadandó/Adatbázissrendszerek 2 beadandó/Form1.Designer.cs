namespace Adatbázissrendszerek_2_beadandó
{
    partial class haz_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_epitese = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_szszam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_emelet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_futes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_varos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_iszam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Beszuras = new System.Windows.Forms.Button();
            this.cb_tipus = new System.Windows.Forms.ComboBox();
            this.btn_Torles = new System.Windows.Forms.Button();
            this.lb_utca = new System.Windows.Forms.Label();
            this.tb_utca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 204);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // tb_epitese
            // 
            this.tb_epitese.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_epitese.Location = new System.Drawing.Point(81, 268);
            this.tb_epitese.Name = "tb_epitese";
            this.tb_epitese.Size = new System.Drawing.Size(100, 22);
            this.tb_epitese.TabIndex = 2;
            this.tb_epitese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_epitese.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(300, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ház adatai:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Építése:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(187, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Szobák száma";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_szszam
            // 
            this.tb_szszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_szszam.Location = new System.Drawing.Point(304, 268);
            this.tb_szszam.Name = "tb_szszam";
            this.tb_szszam.Size = new System.Drawing.Size(100, 22);
            this.tb_szszam.TabIndex = 5;
            this.tb_szszam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_szszam.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(415, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Emelet:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_emelet
            // 
            this.tb_emelet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_emelet.Location = new System.Drawing.Point(487, 268);
            this.tb_emelet.Name = "tb_emelet";
            this.tb_emelet.Size = new System.Drawing.Size(100, 22);
            this.tb_emelet.TabIndex = 7;
            this.tb_emelet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_emelet.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(611, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fűtés";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_futes
            // 
            this.tb_futes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_futes.Location = new System.Drawing.Point(688, 268);
            this.tb_futes.Name = "tb_futes";
            this.tb_futes.Size = new System.Drawing.Size(100, 22);
            this.tb_futes.TabIndex = 9;
            this.tb_futes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_futes.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(9, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Város:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_varos
            // 
            this.tb_varos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_varos.Location = new System.Drawing.Point(81, 309);
            this.tb_varos.Name = "tb_varos";
            this.tb_varos.Size = new System.Drawing.Size(100, 22);
            this.tb_varos.TabIndex = 11;
            this.tb_varos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_varos.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(187, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Írányító szám";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_iszam
            // 
            this.tb_iszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_iszam.Location = new System.Drawing.Point(304, 312);
            this.tb_iszam.Name = "tb_iszam";
            this.tb_iszam.Size = new System.Drawing.Size(100, 22);
            this.tb_iszam.TabIndex = 13;
            this.tb_iszam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_iszam.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(9, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Típus:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Beszuras
            // 
            this.btn_Beszuras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Beszuras.Location = new System.Drawing.Point(427, 341);
            this.btn_Beszuras.Name = "btn_Beszuras";
            this.btn_Beszuras.Size = new System.Drawing.Size(160, 28);
            this.btn_Beszuras.TabIndex = 17;
            this.btn_Beszuras.Text = "Beszúrás";
            this.btn_Beszuras.UseVisualStyleBackColor = true;
            this.btn_Beszuras.Click += new System.EventHandler(this.btn_Beszuras_Click);
            // 
            // cb_tipus
            // 
            this.cb_tipus.FormattingEnabled = true;
            this.cb_tipus.Location = new System.Drawing.Point(60, 341);
            this.cb_tipus.Name = "cb_tipus";
            this.cb_tipus.Size = new System.Drawing.Size(121, 21);
            this.cb_tipus.TabIndex = 18;
            this.cb_tipus.DropDown += new System.EventHandler(this.cb_tipus_DropDown);
            this.cb_tipus.SelectedIndexChanged += new System.EventHandler(this.cb_tipus_SelectedIndexChanged);
            // 
            // btn_Torles
            // 
            this.btn_Torles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Torles.Location = new System.Drawing.Point(614, 343);
            this.btn_Torles.Name = "btn_Torles";
            this.btn_Torles.Size = new System.Drawing.Size(174, 25);
            this.btn_Torles.TabIndex = 19;
            this.btn_Torles.Text = "Törlés";
            this.btn_Torles.UseVisualStyleBackColor = true;
            this.btn_Torles.Click += new System.EventHandler(this.btn_Torles_Click);
            // 
            // lb_utca
            // 
            this.lb_utca.AutoSize = true;
            this.lb_utca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_utca.Location = new System.Drawing.Point(187, 346);
            this.lb_utca.Name = "lb_utca";
            this.lb_utca.Size = new System.Drawing.Size(111, 16);
            this.lb_utca.TabIndex = 21;
            this.lb_utca.Text = "Utca. házszám";
            this.lb_utca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_utca
            // 
            this.tb_utca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_utca.Location = new System.Drawing.Point(304, 346);
            this.tb_utca.Name = "tb_utca";
            this.tb_utca.Size = new System.Drawing.Size(100, 22);
            this.tb_utca.TabIndex = 20;
            this.tb_utca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_utca.UseWaitCursor = true;
            // 
            // haz_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.lb_utca);
            this.Controls.Add(this.tb_utca);
            this.Controls.Add(this.btn_Torles);
            this.Controls.Add(this.cb_tipus);
            this.Controls.Add(this.btn_Beszuras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_iszam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_varos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_futes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_emelet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_szszam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_epitese);
            this.Controls.Add(this.dataGridView1);
            this.Name = "haz_form";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_epitese;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_szszam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_emelet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_futes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_varos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_iszam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Beszuras;
        private System.Windows.Forms.ComboBox cb_tipus;
        private System.Windows.Forms.Button btn_Torles;
        private System.Windows.Forms.Label lb_utca;
        private System.Windows.Forms.TextBox tb_utca;
    }
}

