using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entidades;
using Logica;

namespace CapturaPrecontratos
{
    public partial class InsertarActualizarClientes : System.Web.UI.Page
    {
        clientesNegocioDemo ClientNego = new clientesNegocioDemo();
        atributosDemo ClientEnti = new atributosDemo();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                MostrarDatos();
            }

        }
        private void MostrarDatos()
        {
            try
            {
                string strCD = Session["CodigoCliente"].ToString();
                ClientEnti = ClientNego.ConsultarCliente(strCD);
                {
                    txtCodigo.Text = ClientEnti.codigoCliente;
                    txtNombres.Text = ClientEnti.nombresCliente;
                    txtApellidos.Text = ClientEnti.apellidosCliente;
                    txtCorreo.Text = ClientEnti.correoCliente;
                    btnGrabar.Enabled = false;
                    btnActualizar.Enabled = true;
                    btnCancelar.Enabled = true;
                }
            }
            catch (Exception)
            {
            }
        }
        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text.Trim() != "" && this.txtApellidos.Text.Trim() != ""
               && this.txtNombres.Text.Trim() != "" && this.txtCorreo.Text.Trim() != "")
            {
                try
                {
                    ClientEnti.codigoCliente = txtCodigo.Text;
                    ClientEnti.nombresCliente = txtNombres.Text;
                    ClientEnti.apellidosCliente = txtApellidos.Text;
                    ClientEnti.correoCliente = txtCorreo.Text;
                    ClientEnti.estadoCliente = 1;
                    if (ClientNego.InsertarCliente(ClientEnti) == true)
                    {
                        lblMensaje.Text = "Registro Guardado Correctamente";
                        Response.Redirect("~/ListarClientes.aspx");
                    }
                    else
                    {
                        lblMensaje.Text = "Error de grabación de datos";
                    }
                }
                catch (Exception exc)
                {
                    lblMensaje.Text = exc.Message.ToString();
                }
            }
            else
            {
                lblMensaje.Text = "Todo los Campos son Obligatorios.";
            }
        }
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text.Trim() != "" && this.txtApellidos.Text.Trim() != ""
              && this.txtNombres.Text.Trim() != "" && this.txtCorreo.Text.Trim() != "")
            {
                try
                {

                    ClientEnti.codigoCliente = txtCodigo.Text;
                    ClientEnti.nombresCliente = txtNombres.Text;
                    ClientEnti.apellidosCliente = txtApellidos.Text;
                    ClientEnti.correoCliente = txtCorreo.Text;
                    if (ClientNego.ActualizarCliente(ClientEnti) == true)
                    {
                        lblMensaje.Text = "Registro Actualizado Correctamente";
                        Session.RemoveAll();
                        Response.Redirect("~/ListarClientes.aspx");
                    }
                    else
                    {
                        lblMensaje.Text = "Error de Actualización de datos";
                    }

                }
                catch (Exception exc)
                {
                    lblMensaje.Text = exc.Message.ToString();
                }
            }
            else
            {
                lblMensaje.Text = "Todo los Campos son Obligatorios.";
            }
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("~/ListarClientes.aspx");

        }
    }
}