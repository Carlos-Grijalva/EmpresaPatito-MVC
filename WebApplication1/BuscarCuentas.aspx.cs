using Controlador;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class BuscarCuentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var listaCuentas = ControladorCuenta.BuscarPorCriterios(txtCriterios.Text);
            dgvCuentas.DataSource = listaCuentas;
            dgvCuentas.DataBind();

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = txtCriterios.Text;
                var cuenta = ControladorCuenta.BuscarPorCriterios(criterio);
                dgvCuentas.DataSource = cuenta;
                dgvCuentas.DataBind();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                mensaje.InnerText = ex.Message;
            }
        }

        protected void btnBuscarID_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = txtCriterios.Text;
                var cuenta = ControladorCuenta.BuscarID(int.Parse(criterio));
                dgvCuentas.DataSource = cuenta;
                dgvCuentas.DataBind();
            }
            catch (Exception ex )
            {
                Debug.WriteLine(ex.Message);
                mensaje.InnerText = ex.Message;
            }
        }

        protected void eliminar_cuenta(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                int id = int.Parse(btn.CommandArgument);
                Debug.WriteLine(id);
                ControladorCuenta.EliminarCuenta(id);
                Response.Redirect("BuscarCuentas.aspx");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                mensaje.InnerText = "Es probable que hayan tarjetas ligadas a esta cuenta";
            }
        }

        protected void modificar_cuenta(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                int id = Int32.Parse(btn.CommandArgument);
                Response.Redirect("EditarCuenta.aspx?idCuenta=" + id, false);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                mensaje.InnerText = ex.Message;
            }
        }
    }
}