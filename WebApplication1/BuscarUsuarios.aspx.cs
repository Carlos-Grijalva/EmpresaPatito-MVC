﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
using Controlador;
using System.Diagnostics;

namespace WebApplication1
{
    public partial class BuscarUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var listaUsuarios = ControladorUsuario.BuscarPorCriterios(txtCriterios.Text);
            dgvUsuarios.DataSource = listaUsuarios;
            dgvUsuarios.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = txtCriterios.Text;
                var usuario = ControladorUsuario.BuscarPorCriterios(criterio);
                dgvUsuarios.DataSource = usuario;
                dgvUsuarios.DataBind();
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
                var tarjeta = ControladorUsuario.BuscarID(int.Parse(criterio));
                dgvUsuarios.DataSource = tarjeta;
                dgvUsuarios.DataBind();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                //mensaje.InnerText = ex.Message;
            }
        }

        protected void eliminar_usuario(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                int id = int.Parse(btn.CommandArgument);
                Debug.WriteLine(id);
                ControladorUsuario.EliminarUsuario(id);
                Response.Redirect("BuscarUsuarios.aspx");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                mensaje.InnerText = ex.Message;
            }
        }

        protected void modificar_usuario(object sender, EventArgs e)
        {
            
            try
            {
                Button btn = (Button)sender;
                int id = Int32.Parse(btn.CommandArgument);
                Response.Redirect("EditarUsuario.aspx?idUsuario=" + id, false);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                mensaje.InnerText = ex.Message;
            }
        }
    }
}