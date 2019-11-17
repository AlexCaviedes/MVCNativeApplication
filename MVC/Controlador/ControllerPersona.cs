using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Vista;
using MVC.Modelo;
using System.Web.UI.HtmlControls;

namespace MVC.Controlador
{
    public class ControllerPersona
    {
        Persona p = new Persona();
        DatosPersona dp = new DatosPersona();
        public List<Persona> listar()
        {
            return dp.Read();
        }

        public int guardar(frmPersona vista)
        {
            p.Nombre = ((HtmlInputText)vista.Page.Form.FindControl("nombre")).Value;
            p.Apellidos = ((HtmlInputText)vista.Page.Form.FindControl("apellidos")).Value;
            p.Telefono = ((HtmlInputText)vista.Page.Form.FindControl("telefono")).Value;
            p.Email = ((HtmlInputText)vista.Page.Form.FindControl("email")).Value;
            int create= dp.Create(p);
            return create;
        }

        public int modificar(frmPersona vista)
        {
            p.Id =Convert.ToInt32( ((HtmlInputHidden)vista.Page.FindControl("id")).Value);
            p.Nombre = ((HtmlInputText)vista.Page.Form.FindControl("nombre")).Value;
            p.Apellidos = ((HtmlInputText)vista.Page.Form.FindControl("apellidos")).Value;
            p.Telefono = ((HtmlInputText)vista.Page.Form.FindControl("telefono")).Value;
            p.Email = ((HtmlInputText)vista.Page.Form.FindControl("email")).Value;
            int update = dp.Update(p);
            return update;
        }

        public int eliminar(int id)
        {
            return dp.Delete(id);
        }
    }
}