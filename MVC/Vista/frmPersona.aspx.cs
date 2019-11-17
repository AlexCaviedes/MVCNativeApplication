using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MVC.Controlador;

namespace MVC.Vista
{
    public partial class frmPersona : System.Web.UI.Page
    {
        ControllerPersona cp = new ControllerPersona();

        protected void Page_Load(object sender, EventArgs e)
        {
            Modificar.Enabled = false;
            DgvDatos.DataSource = cp.listar();
            DgvDatos.DataBind();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            int create=cp.guardar(this);
            if (create >= 1)
            {
                this.Label1.Text = "<div class='alert alert-success text-black'>Datos guardados correctamente</div>";
                ClearCamps();
                DgvDatos.DataSource = cp.listar();
                DgvDatos.DataBind();
            }
            else
            {
                this.Label1.Text = "<div class='alert alert-success text-black'>No se pudo guardar sus datos</div>";
            }
        }

        protected void dgv_Datos(object source, DataGridCommandEventArgs e)
        {
            //Update
            id.Value = e.Item.Cells[0].Text;
            nombre.Value =e.Item.Cells[1].Text;
            apellidos.Value = e.Item.Cells[2].Text;
            telefono.Value = e.Item.Cells[3].Text;
            email.Value = e.Item.Cells[4].Text;
            Modificar.Enabled = true;

        }

        protected void dgv_DatosDelete(object source, DataGridCommandEventArgs e)
        {
            //Delete
            string Id = e.Item.Cells[0].Text;
            int id = Convert.ToInt32(Id);
            int Delete=cp.eliminar(id);
            if (Delete >= 1)
            {    
                this.Label1.Text = "<div class='alert alert-success text-black'>Datos eliminados correctamente</div>";
                DgvDatos.DataSource = cp.listar();
                DgvDatos.DataBind();
            }
            else
            {
                this.Label1.Text = "<div class='alert alert-success text-black'>Datos no eliminado</div>";
            }
        }

        protected void DgvDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            int update = cp.modificar(this);
            if (update >= 1)
            {
                this.Label1.Text = "<div class='alert alert-success text-black'>Datos modificados correctamente</div>";
                ClearCamps();
                DgvDatos.DataSource = cp.listar();
                DgvDatos.DataBind();
            }
            else
            {
                this.Label1.Text = "<div class='alert alert-success text-black'>No se pudo modificar los datos</div>";
            }
        }

        public void ClearCamps()
        {
            id.Value = string.Empty;
            nombre.Value = string.Empty;
            apellidos.Value = string.Empty;
            telefono.Value = string.Empty;
            email.Value = string.Empty;
        }
    }
}