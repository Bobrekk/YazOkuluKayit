using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace YazOkuluKayıt
{
    public partial class Utilisateur1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ogr = new EntityOgrenci();
            ogr.OGRAD = TxtBoxAd.Text;
            ogr.OGRSOYAD = TxtBoxSoyad.Text;
            ogr.OGRNUMARA = TxtBoxNumara.Text;
            ogr.OGRSIFRE = TxtBoxSifre.Text;
            ogr.OGRFOTO = TxtBoxFoto.Text;

            BLLOgrenci.OgrenciEkle(ogr);

        }
    }
}