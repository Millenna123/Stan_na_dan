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
    public partial class Zaposleni : Form
    {
        int id = 0;
        DataTable rezervacije;

        public Zaposleni()
        {
            InitializeComponent();
        }

        private void Zaposleni_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Zaposleni_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from osoba where id = " + Program.osoba_id, Stan_na_dan.veza);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            txt_email.Text = tabela.Rows[0]["email"].ToString();
            txt_ime.Text = tabela.Rows[0]["ime"].ToString();
            txt_prezime.Text = tabela.Rows[0]["prezime"].ToString();

            adapter = new SqlDataAdapter("select id, adresa from stan", Stan_na_dan.veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
            cmb_stan.DataSource = tabela;
            cmb_stan.ValueMember = "id";
            cmb_stan.DisplayMember = "adresa";
            cmb_stan.SelectedIndex = -1;

            adapter = new SqlDataAdapter("select id, email from osoba where uloga_id = 1", Stan_na_dan.veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
            cmb_clan.DataSource = tabela;
            cmb_clan.ValueMember = "id";
            cmb_clan.DisplayMember = "email";
            cmb_clan.SelectedIndex = -1;

            grid_popuni();
        }

        private void grid_popuni()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select rezervacija.id, Osoba.email, rezervacija.osoba_id, stan.adresa, stan.broj_stana, stan.broj_kreveta, rezervacija.stan_id, datum_pocetak, datum_kraj from rezervacija join osoba on osoba.id = rezervacija.osoba_id join stan on stan.id = rezervacija.stan_id", Stan_na_dan.veza);
            rezervacije = new DataTable();
            adapter.Fill(rezervacije);
            dataGridView1.DataSource = rezervacije;
            dataGridView1.Columns["osoba_id"].Visible = false;
            dataGridView1.Columns["stan_id"].Visible = false;
            dataGridView1.Columns["id"].Visible = false;            
        }

        private void cmb_stan_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_stan.IsHandleCreated && cmb_stan.Focused)
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from stan where id = " + cmb_stan.SelectedValue, Stan_na_dan.veza);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);

                txt_adresa.Text = tabela.Rows[0]["adresa"].ToString();
                txt_brojstana.Text = tabela.Rows[0]["broj_stana"].ToString();
                txt_brojkreveta.Text = tabela.Rows[0]["broj_kreveta"].ToString();

                adapter = new SqlDataAdapter("select * from cena where stan_id = " + cmb_stan.SelectedValue + " and datum = '" + dolazak.Value.ToString("yyyy-MM-dd") + "'", Stan_na_dan.veza);
                tabela = new DataTable();
                adapter.Fill(tabela);

                if (tabela.Rows.Count > 0)
                {
                    txt_cena.Text = tabela.Rows[0]["cena_po_danu"].ToString();
                }
                else
                {
                    txt_cena.Text = "";
                }
            }
        }

        private void dolazak_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("select * from cena where stan_id = " + cmb_stan.SelectedValue + " and datum = '" + dolazak.Value.ToString("yyyy-MM-dd") + "'");
            SqlDataAdapter adapter = new SqlDataAdapter("select * from cena where stan_id = " + cmb_stan.SelectedValue + " and datum = '" + dolazak.Value.ToString("yyyy-MM-dd") + "'", Stan_na_dan.veza);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);

            if (tabela.Rows.Count > 0)
            {
                txt_cena.Text = tabela.Rows[0]["cena_po_danu"].ToString();
            }
            else
            {
                txt_cena.Text = "";
            }
        }

        private void odlazak_ValueChanged(object sender, EventArgs e)
        {
            if (odlazak.IsHandleCreated && odlazak.Focused)
            {
                SqlCommand komanda = new SqlCommand("SELECT DATEDIFF(d, '" + dolazak.Value.ToString("yyyy-MM-dd") + "', '" + odlazak.Value.ToString("yyyy-MM-dd") + "');", Stan_na_dan.veza);
                SqlConnection veza = Stan_na_dan.veza;

                veza.Open();
                int brojdana = (int)komanda.ExecuteScalar();
                veza.Close();

                if (brojdana <= 0)
                {
                    MessageBox.Show("Vremena nisu dobro uneta!");
                }
                else
                {
                    if (brojdana >= 10)
                    {
                        MessageBox.Show("Ne mozete rezervisati na toliko vremena!");
                    }
                    else
                    {
                        txt_brojdana.Text = Convert.ToString(brojdana);
                        txt_ukupno.Text = Convert.ToString(Convert.ToInt32(txt_cena.Text) * Convert.ToInt32(txt_brojdana.Text));
                    }
                }
            }
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            if (cmb_stan.SelectedIndex == -1 || cmb_clan.SelectedIndex == -1)
            {
                MessageBox.Show("Niste uneli podatke");
            }
            else
            {
                int rez = Stan_na_dan.rezervacija_dodaj((int) cmb_clan.SelectedValue, (int)cmb_stan.SelectedValue, dolazak.Value, odlazak.Value);
                if (rez == -2)
                {
                    MessageBox.Show("Vec imate rezervaciju!");
                }
                else
                {
                    if (rez == -1)
                    {
                        MessageBox.Show("Vec postoji rezervacija!");
                    }
                }
                grid_popuni();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                postavi(e.RowIndex);
                id = (int)rezervacije.Rows[e.RowIndex]["id"];
            }
        }

        private void postavi(int broj_sloga)
        {
            cmb_stan.SelectedValue = rezervacije.Rows[broj_sloga]["stan_id"];
            cmb_clan.SelectedValue = rezervacije.Rows[broj_sloga]["osoba_id"];
            txt_adresa.Text = rezervacije.Rows[broj_sloga]["adresa"].ToString();
            txt_brojstana.Text = rezervacije.Rows[broj_sloga]["broj_stana"].ToString();
            txt_brojkreveta.Text = rezervacije.Rows[broj_sloga]["broj_kreveta"].ToString();
            dolazak.Value = (DateTime)rezervacije.Rows[broj_sloga]["datum_pocetak"];
            odlazak.Value = (DateTime)rezervacije.Rows[broj_sloga]["datum_kraj"];

            SqlDataAdapter adapter = new SqlDataAdapter("select * from cena where stan_id = " + cmb_stan.SelectedValue + " and datum = '" + dolazak.Value.ToString("yyyy-MM-dd") + "'", Stan_na_dan.veza);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);

            if (tabela.Rows.Count > 0)
            {
                txt_cena.Text = tabela.Rows[0]["cena_po_danu"].ToString();
            }
            else
            {
                txt_cena.Text = "";
            }

            SqlCommand komanda = new SqlCommand("SELECT DATEDIFF(d, '" + dolazak.Value.ToString("yyyy-MM-dd") + "', '" + odlazak.Value.ToString("yyyy-MM-dd") + "');", Stan_na_dan.veza);
            SqlConnection veza = Stan_na_dan.veza;

            veza.Open();
            int brojdana = (int)komanda.ExecuteScalar();
            veza.Close();

            if (brojdana <= 0)
            {
                MessageBox.Show("Vremena nisu dobro uneta!");
            }
            else
            {
                if (brojdana >= 10)
                {
                    MessageBox.Show("Ne mozete rezervisati na toliko vremena!");
                }
                else
                {
                    txt_brojdana.Text = Convert.ToString(brojdana);
                    txt_ukupno.Text = Convert.ToString(Convert.ToInt32(txt_cena.Text) * Convert.ToInt32(txt_brojdana.Text));
                }
            }
        }

        private void btn_obrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Stan_na_dan.veza;
            SqlCommand komanda = new SqlCommand("DELETE FROM rezervacija where id = " + id, veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                grid_popuni();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }
    }
}
