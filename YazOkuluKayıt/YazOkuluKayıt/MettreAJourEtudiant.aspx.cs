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
    public partial class MettreAJour : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
            TxtBoxId.Text = x.ToString();
            TxtBoxId.Enabled = false;
            
            if(Page.IsPostBack == false)
            {
                List<EntityOgrenci> OgrList = BLLOgrenci.BllDetay(x);
                TxtBoxAd.Text = OgrList[0].OGRAD.ToString();
                TxtBoxSoyad.Text = OgrList[0].OGRSOYAD.ToString();
                TxtBoxNumara.Text = OgrList[0].OGRNUMARA.ToString();
                TxtBoxFoto.Text = OgrList[0].OGRFOTO.ToString();
                TxtBoxSifre.Text = OgrList[0].OGRSIFRE.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ogr = new EntityOgrenci();
            ogr.OGRID = Convert.ToInt32(TxtBoxId.Text);
            ogr.OGRAD = TxtBoxAd.Text;
            ogr.OGRSOYAD = TxtBoxSoyad.Text;
            ogr.OGRSIFRE = TxtBoxSifre.Text;
            ogr.OGRNUMARA = TxtBoxNumara.Text;
            ogr.OGRFOTO = TxtBoxFoto.Text;
            BLLOgrenci.OgrenciGuncelleBLL(ogr);
            Response.Redirect("ListeDeEtudiants.aspx");
        }
    }
}