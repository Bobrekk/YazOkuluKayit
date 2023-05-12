using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Ders", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                EntityDers ders = new EntityDers();
                ders.DERSID = Convert.ToInt32(oku["DERSID"].ToString());
                ders.DERSAD = oku["DERSAD"].ToString();
                ders.MIN = Convert.ToInt32(oku["DERSMINKONT"].ToString());
                ders.MAX = Convert.ToInt32(oku["DERSMAXKONT"].ToString());
                degerler.Add(ders);
            }

            oku.Close();
            return degerler;
        }

        public static int TalepEkle(EntityBasvuru p)
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_BasvuruForm (OGRENCIID,DERSID) values (@p1,@p2)", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", p.BASOGRID);
            komut.Parameters.AddWithValue("@p2", p.BASDERSID);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();

        }
    }
}
