using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace MVC.Modelo
{
    public class DatosPersona
    {
        public List<Persona> Read()
        {
            SqlConnection conex = ConexionBaseDatos.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("pa_cargar", conex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return (from DataRow row in dt.Rows
                    select new Persona()
                    {
                       Id=Convert.ToInt32(row["id"]),
                       Nombre=Convert.ToString(row["nombre"]),
                       Apellidos=Convert.ToString(row["apellido"]),
                       Telefono=Convert.ToString(row["telefono"]),
                       Email=Convert.ToString(row["email"])
                    }).ToList();
        }

        public int Create(Persona p)
        {
            SqlConnection conex = ConexionBaseDatos.GetConnection();
            SqlCommand cm = new SqlCommand("pa_insertar", conex);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@nombre", p.Nombre);
            cm.Parameters.AddWithValue("@apellido", p.Apellidos);
            cm.Parameters.AddWithValue("@telefono", p.Telefono);
            cm.Parameters.AddWithValue("@email",p.Email);
            int create = cm.ExecuteNonQuery();
            return create;
        }
        public int Update(Persona p)
        {
            SqlConnection conex = ConexionBaseDatos.GetConnection();
            SqlCommand cm = new SqlCommand("pa_actualizar", conex);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@id", p.Id);
            cm.Parameters.AddWithValue("@nombre", p.Nombre);
            cm.Parameters.AddWithValue("@apellido", p.Apellidos);
            cm.Parameters.AddWithValue("@telefono", p.Telefono);
            cm.Parameters.AddWithValue("@email", p.Email);
            int update=cm.ExecuteNonQuery();
            return update;
        }

        public int Delete(int id)
        {
            SqlConnection conex = ConexionBaseDatos.GetConnection();
            SqlCommand cm = new SqlCommand("pa_eliminar", conex);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
            int delete = cm.ExecuteNonQuery();
            return delete;
        }
    }
}