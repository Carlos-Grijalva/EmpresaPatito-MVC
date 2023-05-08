using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador;
using Modelo;

namespace WebApplication1
{
    public partial class EditarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                int idUsuario = int.Parse(Request.QueryString["idUsuario"]);
                var usuario = ControladorUsuario.BuscarPorID(idUsuario);
                Debug.WriteLine(usuario.Nombre);
                txtNombre.Text = usuario.Nombre;
                txtPrimerApellido.Text = usuario.ApellidoPaterno;
                txtSegundoApellido.Text = usuario.ApellidoMaterno;
                txtEmail.Text = usuario.Email;
                txtCelular.Text = usuario.Celular;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                mensaje.InnerText = ex.Message;
                Response.Redirect("Principal.aspx", false);
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                int idUsuario = Int32.Parse(Request.QueryString["idUsuario"]);
                //mensaje.InnerText = idUsuario + "";
                //var editarusuario = new Usuario();
                //editarusuario.idUsuario = idUsuario;
                //editarusuario.Nombre = txtNombre.Text;
                //editarusuario.ApellidoPaterno = txtPrimerApellido.Text;
                //editarusuario.ApellidoMaterno = txtSegundoApellido.Text;
                //editarusuario.Email = txtEmail.Text;
                //editarusuario.Celular = txtCelular.Text;

                ModeloUsuario.ModificarUsuario(
                    idUsuario,
                    txtNombre.Text,
                    txtPrimerApellido.Text,
                    txtSegundoApellido.Text,
                    txtEmail.Text,
                    txtCelular.Text
                );

                Debug.WriteLine("PAso?");
                Response.Redirect("BuscarUsuarios.aspx", false);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                mensaje.InnerText = ex.Message;
            }
        }
    }
}