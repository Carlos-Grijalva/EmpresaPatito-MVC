using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
using Controlador;

namespace WebApplication1
{
    public partial class AgregarTarjeta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevatarjeta = new Tarjeta();

            try
            {
                nuevatarjeta.idCuenta = Int32.Parse(idCuenta.Text);
                nuevatarjeta.nombreEntidad = nomEntidad.Text;
                nuevatarjeta.numeroTarjeta = numTarjeta.Text;
                //DateTime fecha = new DateTime(fechaCadu.text);
                nuevatarjeta.fechaCaducidad = fechaCadu.SelectedDate;
                nuevatarjeta.marca = marca.Text;
                nuevatarjeta.cvv = Int32.Parse(cvv.Text);

                ControladorTarjeta.guardarTarjeta(nuevatarjeta);

                idCuenta.Text = string.Empty;
                nomEntidad.Text = string.Empty;
                numTarjeta.Text = string.Empty;
                fechaCadu.SelectedDate = DateTime.Now;
                marca.Text = string.Empty;
                cvv.Text = string.Empty;

                mensaje.InnerText = "Guardado Exitosamente";

            }
            catch (Exception ex)
            {

                mensaje.InnerText = ex.Message;

            }
        }
    }
}