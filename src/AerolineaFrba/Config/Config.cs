﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Config {
    
    public static class DBConfig {

        static public string direccion = @"PABLO-NOTEBOOK\SQLSERVER2012"; 
        static public string database = "GD2C2015";
        static public string username = "gd";
        static public string password = "gd2015";

    }

    public static class SystemConfig {

        static public DateTime systemDate = new DateTime(2015, 12, 25);

    }

}
