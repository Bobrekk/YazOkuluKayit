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
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci p)
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Ogr (ograd,ogrsoyad,ogrnumara,ogrfoto,ogrsıfre) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@p1", p.OGRAD);
            komut.Parameters.AddWithValue("@p2", p.OGRSOYAD);
            komut.Parameters.AddWithValue("@p3", p.OGRNUMARA);
            komut.Parameters.AddWithValue("@p4", p.OGRFOTO);
            komut.Parameters.AddWithValue("@p5", p.OGRSIFRE);
            return komut.ExecuteNonQuery();
        } 

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Ogr", Baglanti.bgl);
            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                EntityOgrenci ogr = new EntityOgrenci();
                ogr.OGRID = Convert.ToInt32(oku["OGRID"].ToString());
                ogr.OGRAD = oku["OGRAD"].ToString();
                ogr.OGRSOYAD = oku["OGRSOYAD"].ToString();
                ogr.OGRNUMARA = oku["OGRNUMARA"].ToString();
                ogr.OGRFOTO = oku["OGRFOTO"].ToString();
                ogr.OGRSIFRE = oku["OGRSIFRE"].ToString();
                ogr.OGRBAKIYE = Convert.ToDouble(oku["OGRBAKIYE"].ToString());

                degerler.Add(ogr);
            }

            oku.Close();
            return degerler;
        }

        public static bool OgrenciSil(int p)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Ogr where OGRID=@p1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", p);
            return komut.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Ogr where OGRID=@p1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                EntityOgrenci ogr = new EntityOgrenci();
                ogr.OGRID = Convert.ToInt32(oku["OGRID"].ToString());
                ogr.OGRAD = oku["OGRAD"].ToString();
                ogr.OGRSOYAD = oku["OGRSOYAD"].ToString();
                ogr.OGRNUMARA = oku["OGRNUMARA"].ToString();
                ogr.OGRFOTO = oku["OGRFOTO"].ToString();
                ogr.OGRSIFRE = oku["OGRSIFRE"].ToString();
                ogr.OGRBAKIYE = Convert.ToDouble(oku["OGRBAKIYE"].ToString());

                degerler.Add(ogr);
            }

            oku.Close();
            return degerler;
        }

        public static bool OgrenciGuncelle(EntityOgrenci p)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Ogr Set OGRAD=@p1, OGRSOYAD=@p2, OGRNUMARA=@p3, OGRFOTO=@p4, OGRSIFRE=@p5 WHERE OGRID=@p6", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", p.OGRAD);
            komut.Parameters.AddWithValue("@p2", p.OGRSOYAD);
            komut.Parameters.AddWithValue("@p3", p.OGRNUMARA);
            komut.Parameters.AddWithValue("@p4", p.OGRFOTO);
            komut.Parameters.AddWithValue("@p5", p.OGRSIFRE);
            komut.Parameters.AddWithValue("@p6", p.OGRID);

            return komut.ExecuteNonQuery() > 0;
        }
    }
}
