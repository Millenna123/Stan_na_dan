using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Aplikacija_stan_na_dan
{
    class Stan_na_dan
    {
        static public string cs = ConfigurationManager.ConnectionStrings["home"].ConnectionString;
        static public SqlConnection veza = new SqlConnection(cs);

        static public int rezervacija_dodaj(int osoba_id, int stan_id, DateTime datum_pocetak, DateTime datum_kraj)
        {
                          
                SqlCommand komanda = new SqlCommand();
                komanda.Connection = veza;
                komanda.CommandType = CommandType.StoredProcedure;
                komanda.CommandText = "rezervacija_dodaj";

                komanda.Parameters.Add(new SqlParameter("@osoba_id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, osoba_id));
                komanda.Parameters.Add(new SqlParameter("@stan_id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, stan_id));
                komanda.Parameters.Add(new SqlParameter("@datum_pocetak", SqlDbType.Date, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, datum_pocetak));
                komanda.Parameters.Add(new SqlParameter("@datum_kraj", SqlDbType.Date, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, datum_kraj));
                komanda.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));

                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                int ret;
                ret = (int) komanda.Parameters["@RETURN_VALUE"].Value;

            return ret;
            
        }

        static public int cena_dodaj(int stan_id, DateTime datum, int cena_po_danu)
        {

            SqlCommand komanda = new SqlCommand();
            komanda.Connection = veza;
            komanda.CommandType = CommandType.StoredProcedure;
            komanda.CommandText = "cena_dodaj";

            komanda.Parameters.Add(new SqlParameter("@stan_id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, stan_id));
            komanda.Parameters.Add(new SqlParameter("@datum", SqlDbType.Date, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, datum));
            komanda.Parameters.Add(new SqlParameter("@cena_po_danu", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, cena_po_danu));
            komanda.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));

            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();

            int ret;
            ret = (int)komanda.Parameters["@RETURN_VALUE"].Value;

            return ret;

        }
    }
}
