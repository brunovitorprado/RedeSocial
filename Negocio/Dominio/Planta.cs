﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Dominio
{
    public class Planta
    {
        public int id { get; set; }
        public string Nome { get; set; }

        public int HortaId { get; set; }
        public virtual Horta horta { get; set; }
    }
}
