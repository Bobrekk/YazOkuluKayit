using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private int ogrid;
        private string ograd;
        private string ogrsoyad;
        private string ogrnumara;
        private string ogrfoto;
        private double ogrbakiye;
        private string ogrsifre;

        public int OGRID { get => ogrid; set => ogrid = value; }
        public string OGRAD { get => ograd; set => ograd = value; }
        public string OGRSOYAD { get => ogrsoyad; set => ogrsoyad = value; }
        public string OGRNUMARA { get => ogrnumara; set => ogrnumara = value; }
        public string OGRFOTO { get => ogrfoto; set => ogrfoto = value; }
        public double OGRBAKIYE { get => ogrbakiye; set => ogrbakiye = value; }
        public string OGRSIFRE { get => ogrsifre; set => ogrsifre = value; }
    }
}
