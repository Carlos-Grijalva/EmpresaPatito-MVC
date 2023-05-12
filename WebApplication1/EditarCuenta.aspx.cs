using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class EditarCuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    int idCuenta = int.Parse(Request.QueryString["idCuenta"]);
                    var cuenta = ControladorCuenta.BuscarPorID(idCuenta);
                    saldo.Text = cuenta.Saldo.ToString();
                    numCuenta.Text = cuenta.NumeroCuenta.ToString();
                    idUsuario.DataSource = ControladorUsuario.MostrarIDs();
                    idUsuario.DataBind();
                    idUsuario.SelectedValue = cuenta.idUsuario.ToString();
                    Debug.WriteLine("EditarCuenta Page_Load");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    mensaje.InnerText = ex.Message;
                    Response.Redirect("Principal.aspx", false);
                }
            }

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCuenta = int.Parse(Request.QueryString["idCuenta"]);
                mensaje.InnerText = idCuenta + "";
                var editarcuenta = new Cuenta();
                editarcuenta.idCuenta = idCuenta;
                editarcuenta.idUsuario = int.Parse(idUsuario.SelectedValue);
                editarcuenta.Saldo = int.Parse(saldo.Text);
                editarcuenta.NumeroCuenta = numCuenta.Text;
                ControladorCuenta.ModificarCuenta(editarcuenta);

                Response.Redirect("BuscarCuentas.aspx", false);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                mensaje.InnerText = ex.Message;
            }
        }
    }
}