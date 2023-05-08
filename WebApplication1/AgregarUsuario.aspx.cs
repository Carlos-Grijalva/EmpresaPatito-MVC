using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
using Controlador;
using System.Data.Entity.Validation;

namespace WebApplication1
{
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevosuario = new Usuario();

            nuevosuario.Nombre = txtNombre.Text;
            nuevosuario.ApellidoPaterno = txtPrimerApellido.Text;
            nuevosuario.ApellidoMaterno = txtSegundoApellido.Text;
            nuevosuario.Celular = txtCelular.Text;
            nuevosuario.Email = txtEmail.Text;
            nuevosuario.Contrasena = txtContrasena.Text;

            try
            {
                ControladorUsuario.GuardarUsuario(nuevosuario);
               
                txtNombre.Text = string.Empty;
                txtPrimerApellido.Text = string.Empty;
                txtSegundoApellido.Text = string.Empty;
                txtCelular.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtContrasena.Text = string.Empty;

                mensaje.InnerText = "Guardado Exitosamente";

            }
            catch (Exception ex)
            {

                mensaje.InnerText = ex.Message;
              
            }
        }
    }
}