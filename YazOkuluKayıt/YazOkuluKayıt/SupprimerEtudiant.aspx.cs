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
    public partial class SupprimerEtudiant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"]);
            EntityOgrenci ogr = new EntityOgrenci();
            ogr.OGRID = x;
            BLLOgrenci.OgrenciSilBLL(ogr.OGRID);
            Response.Redirect("ListeDeEtudiants.aspx");
        }
    }
}