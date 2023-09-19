﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterinaria.src.itf
{
    internal class ITF_Reporte
    {
        public string doctor { set; get; } = "";
        public int stay_days { set; get; } = 0;
        public string diagnosis { set; get; } = "";
        public bool is_dead { set; get;} = false;
        public bool is_internship { set; get; } = false;
    }
}