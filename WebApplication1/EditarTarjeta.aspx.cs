using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class EditarTarjeta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    int idTarjeta = int.Parse(Request.QueryString["idTarjeta"]);
                    var tarjeta = ControladorTarjeta.BuscarPorID(idTarjeta);

                    idCuenta.DataSource = ControladorCuenta.MostrarIDs();
                    idCuenta.DataBind();
                    idCuenta.SelectedValue = tarjeta.idCuenta.ToString();
                    nomEntidad.Text = tarjeta.nombreEntidad;
                    numTarjeta.Text = tarjeta.numeroTarjeta.ToString();
                    fechaCadu.SelectedDate = ((DateTime)tarjeta.fechaCaducidad).Date;
                    fechaCadu.VisibleDate = fechaCadu.SelectedDate;
                    marca.Text = tarjeta.marca.ToString();
                    cvv.Text = tarjeta.cvv.ToString();

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
                int idTarjeta = int.Parse(Request.QueryString["idTarjeta"]);
                mensaje.InnerText = idTarjeta + "";
                var editartarjeta = new Tarjeta();
                editartarjeta.idTarjeta = idTarjeta;
                editartarjeta.idCuenta = int.Parse(idCuenta.SelectedValue);
                editartarjeta.nombreEntidad = nomEntidad.Text;
                editartarjeta.numeroTarjeta = numTarjeta.Text;
                editartarjeta.fechaCaducidad = fechaCadu.SelectedDate;
                editartarjeta.marca = marca.Text;
                editartarjeta.cvv = int.Parse(cvv.Text);

                ControladorTarjeta.ModificarTarjeta(editartarjeta);

                Response.Redirect("BuscarTarjetas.aspx", false);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                mensaje.InnerText = ex.Message;
            }
        }
    }
}