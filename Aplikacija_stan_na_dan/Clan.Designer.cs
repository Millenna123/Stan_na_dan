
namespace Aplikacija_stan_na_dan
{
    partial class Clan
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
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.txt_cena = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dolazak = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_stan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.odlazak = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_adresa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_brojstana = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_brojkreveta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_brojdana = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ukupno = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 402);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1274, 114);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dodaj.Location = new System.Drawing.Point(231, 204);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(198, 34);
            this.btn_dodaj.TabIndex = 61;
            this.btn_dodaj.Text = "Резервиши";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // txt_cena
            // 
            this.txt_cena.Enabled = false;
            this.txt_cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cena.Location = new System.Drawing.Point(802, 240);
            this.txt_cena.Name = "txt_cena";
            this.txt_cena.Size = new System.Drawing.Size(167, 30);
            this.txt_cena.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(658, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 25);
            this.label11.TabIndex = 57;
            this.label11.Text = "Цена по дану:";
            // 
            // dolazak
            // 
            this.dolazak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolazak.Location = new System.Drawing.Point(802, 168);
            this.dolazak.Name = "dolazak";
            this.dolazak.Size = new System.Drawing.Size(332, 30);
            this.dolazak.TabIndex = 52;
            this.dolazak.ValueChanged += new System.EventHandler(this.dolazak_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(696, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "Долазак:";
            // 
            // cmb_stan
            // 
            this.cmb_stan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_stan.FormattingEnabled = true;
            this.cmb_stan.Location = new System.Drawing.Point(802, 20);
            this.cmb_stan.Name = "cmb_stan";
            this.cmb_stan.Size = new System.Drawing.Size(359, 33);
            this.cmb_stan.TabIndex = 48;
            this.cmb_stan.SelectedValueChanged += new System.EventHandler(this.cmb_stan_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(731, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "Стан:";
            // 
            // txt_prezime
            // 
            this.txt_prezime.Enabled = false;
            this.txt_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prezime.Location = new System.Drawing.Point(258, 114);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(267, 30);
            this.txt_prezime.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Презиме:";
            // 
            // txt_ime
            // 
            this.txt_ime.Enabled = false;
            this.txt_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ime.Location = new System.Drawing.Point(258, 67);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(267, 30);
            this.txt_ime.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Име:";
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(258, 19);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(267, 30);
            this.txt_email.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Имејл:";
            // 
            // odlazak
            // 
            this.odlazak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odlazak.Location = new System.Drawing.Point(802, 204);
            this.odlazak.Name = "odlazak";
            this.odlazak.Size = new System.Drawing.Size(332, 30);
            this.odlazak.TabIndex = 64;
            this.odlazak.ValueChanged += new System.EventHandler(this.odlazak_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(698, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 63;
            this.label4.Text = "Одлазак:";
            // 
            // txt_adresa
            // 
            this.txt_adresa.Enabled = false;
            this.txt_adresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adresa.Location = new System.Drawing.Point(802, 59);
            this.txt_adresa.Name = "txt_adresa";
            this.txt_adresa.Size = new System.Drawing.Size(267, 30);
            this.txt_adresa.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(710, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 65;
            this.label7.Text = "Адреса:";
            // 
            // txt_brojstana
            // 
            this.txt_brojstana.Enabled = false;
            this.txt_brojstana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_brojstana.Location = new System.Drawing.Point(802, 95);
            this.txt_brojstana.Name = "txt_brojstana";
            this.txt_brojstana.Size = new System.Drawing.Size(267, 30);
            this.txt_brojstana.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(681, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 67;
            this.label8.Text = "Број стана:";
            // 
            // txt_brojkreveta
            // 
            this.txt_brojkreveta.Enabled = false;
            this.txt_brojkreveta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_brojkreveta.Location = new System.Drawing.Point(802, 132);
            this.txt_brojkreveta.Name = "txt_brojkreveta";
            this.txt_brojkreveta.Size = new System.Drawing.Size(267, 30);
            this.txt_brojkreveta.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(659, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 25);
            this.label9.TabIndex = 69;
            this.label9.Text = "Број кревета:";
            // 
            // txt_brojdana
            // 
            this.txt_brojdana.Enabled = false;
            this.txt_brojdana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_brojdana.Location = new System.Drawing.Point(802, 277);
            this.txt_brojdana.Name = "txt_brojdana";
            this.txt_brojdana.Size = new System.Drawing.Size(167, 30);
            this.txt_brojdana.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(691, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 25);
            this.label10.TabIndex = 71;
            this.label10.Text = "Број дана:";
            // 
            // txt_ukupno
            // 
            this.txt_ukupno.Enabled = false;
            this.txt_ukupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ukupno.Location = new System.Drawing.Point(801, 313);
            this.txt_ukupno.Name = "txt_ukupno";
            this.txt_ukupno.Size = new System.Drawing.Size(167, 30);
            this.txt_ukupno.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(713, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 25);
            this.label12.TabIndex = 73;
            this.label12.Text = "Укупно:";
            // 
            // Clan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 528);
            this.Controls.Add(this.txt_ukupno);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_brojdana);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_brojkreveta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_brojstana);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_adresa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.odlazak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.txt_cena);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dolazak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_stan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label1);
            this.Name = "Clan";
            this.Text = "Clan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Clan_FormClosed);
            this.Load += new System.EventHandler(this.Clan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.TextBox txt_cena;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dolazak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_stan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker odlazak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_adresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_brojstana;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_brojkreveta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_brojdana;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_ukupno;
        private System.Windows.Forms.Label label12;
    }
}