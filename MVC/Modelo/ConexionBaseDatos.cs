using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace MVC.Modelo
{
    public class ConexionBaseDatos
    {
        private static SqlConnection conex;
        private ConexionBaseDatos()
        {

        }

        public static SqlConnection GetConnection()
        {
            if (conex == null)
            {
                conex = new SqlConnection(Properties.Settings.Default.cadena);
                conex.Open();
            }
            return conex;
        }
    }
}