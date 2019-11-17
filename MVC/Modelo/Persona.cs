using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Modelo
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellidos;
        private string telefono;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
    }
}