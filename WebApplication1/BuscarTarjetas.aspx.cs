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
    public partial class BuscarTarjetas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var listaTarjetas = ControladorTarjeta.BuscarPorCriterios(txtCriterios.Text);
            dgvTarjetas.DataSource = listaTarjetas;
            dgvTarjetas.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = txtCriterios.Text;
                var tarjeta = ControladorTarjeta.BuscarPorCriterios(criterio);
                dgvTarjetas.DataSource = tarjeta;
                dgvTarjetas.DataBind();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                //mensaje.InnerText = ex.Message;
            }
        }

        protected void btnBuscarID_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = txtCriterios.Text;
                var tarjeta = ControladorTarjeta.BuscarID(int.Parse(criterio));
                dgvTarjetas.DataSource = tarjeta;
                dgvTarjetas.DataBind();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                //mensaje.InnerText = ex.Message;
            }
        }

        protected void eliminar_tarjeta(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                int id = int.Parse(btn.CommandArgument);
                Debug.WriteLine(id);
                ControladorTarjeta.EliminarTarjeta(id);
                Response.Redirect("BuscarTarjetas.aspx");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                //mensaje.InnerText = ex.Message;
            }
        }

        protected void modificar_tarjeta(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                int id = Int32.Parse(btn.CommandArgument);
                Response.Redirect("EditarTarjeta.aspx?idTarjeta=" + id, false);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                //mensaje.InnerText = ex.Message;
            }
        }
    }
}