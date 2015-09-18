﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Models {
    class Cliente {

        public int Id { get; set; }
        public int DNI { get; set; }
        public int Telefono { get; set; }
        public int Puntos { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

    }
}