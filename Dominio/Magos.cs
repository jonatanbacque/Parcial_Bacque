﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Magos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Casas casas { get; set; }
    }
}
