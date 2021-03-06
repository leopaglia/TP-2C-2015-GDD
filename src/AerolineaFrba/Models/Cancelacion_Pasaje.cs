﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AerolineaFrba.Services;

namespace AerolineaFrba.Models {
    class Cancelacion_Pasaje {

        public int Id { get; set; }

        public int Cancelacion_Id { get; set; }
        public int Pasaje_Id { get; set; }

        private Cancelacion _cancelacion = null;
        public Cancelacion Cancelacion {
            get {
                if (_cancelacion != null) {
                    return _cancelacion;
                }
                else {
                    DAO.connect();
                    Cancelacion cancelacion = DAO.selectOne<Cancelacion>(new[] { "id = " + this.Cancelacion_Id });
                    DAO.closeConnection();
                    return cancelacion;
                }
            }
        }

        private Pasaje _pasaje = null;
        public Pasaje Pasaje {
            get {
                if (_pasaje != null) {
                    return _pasaje;
                }
                else {
                    DAO.connect();
                    Pasaje pasaje = DAO.selectOne<Pasaje>(new[] { "id = " + this.Pasaje_Id });
                    DAO.closeConnection();
                    return pasaje;
                }
            }
        }

        public static string TableName = "BIEN_MIGRADO_RAFA.Cancelacion_Pasaje";

    }
}
