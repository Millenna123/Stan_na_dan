using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplikacija_stan_na_dan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void dugme_login_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "" || txt_lozinka.Text == "")
            {
                MessageBox.Show("Unesite podatke");
                return;
            }
            else
            {
                try
                {                    
                    SqlCommand komanda = new SqlCommand("SELECT * FROM Osoba WHERE email = @username", Stan_na_dan.veza);
                    komanda.Parameters.AddWithValue("@username", txt_email.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    int brojac = tabela.Rows.Count;
                    if (brojac == 1)
                    {
                        if (String.Compare(tabela.Rows[0]["lozinka"].ToString(), txt_lozinka.Text) == 0)
                        {
                            MessageBox.Show("Ulogovali ste se!");
                            Program.osoba_id = (int) tabela.Rows[0]["id"];

                            this.Hide();

                            if ((int)tabela.Rows[0]["uloga_id"] == 1)
                            {
                                Clan frm_clan = new Clan();
                                frm_clan.Show();
                            }
                            if ((int)tabela.Rows[0]["uloga_id"] == 2)
                            {
                                Zaposleni frm_zaposleni = new Zaposleni();
                                frm_zaposleni.Show();
                            }                            
                        }
                        else
                        {
                            MessageBox.Show("Pogresna lozinka!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Uneli ste nepostojecu imejl adresu!");
                    }

                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
        }
    }
}
