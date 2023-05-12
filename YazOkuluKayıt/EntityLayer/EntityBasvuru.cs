using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvuru
    {
        private int basid;
        private int basogrid;
        private int basdersid;

        public int BASID { get => basid; set => basid = value; }
        public int BASOGRID { get => basogrid; set => basogrid = value; }
        public int BASDERSID { get => basdersid; set => basdersid = value; }
    }
}
