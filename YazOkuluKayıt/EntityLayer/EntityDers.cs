﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDers
    {
        private int dersid;
        private string dersad;
        private int min;
        private int max;

        public int DERSID { get => dersid; set => dersid = value; }
        public string DERSAD { get => dersad; set => dersad = value; }
        public int MIN { get => min; set => min = value; }
        public int MAX { get => max; set => max = value; }
    }
}
