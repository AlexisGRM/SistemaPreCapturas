using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Logica;

namespace CapturaPrecontratos
{
    public partial class ActualizarDatos : System.Web.UI.Page
    {
        funciones ClientNego = new funciones();
        Atributos ClientEnti = new Atributos();
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
                string strCD = Session["idContratoServicio"].ToString();
                ClientEnti = ClientNego.ConsultarCliente(strCD);
                {
                    txtIdContrato.Text = ClientEnti.idContratoServicio.ToString();
                    txtIdDependencia.Text = ClientEnti.idDependencia;
                    txtIdDepartamento.Text = ClientEnti.idDepartamento;
                    txtUnidadAdmin.Text = ClientEnti.unidAdmin;
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
            if (this.txtIdDependencia.Text.Trim() != ""
               && this.txtIdDepartamento.Text.Trim() != "" && this.txtUnidadAdmin.Text.Trim() != "")
            {
                try
                {

                    ClientEnti.idDependencia = txtIdDependencia.Text;
                    ClientEnti.idDepartamento = txtIdDepartamento.Text;
                    ClientEnti.unidAdmin = txtUnidadAdmin.Text;
                    ClientEnti.idEstatContratServic = 3;
                    if (ClientNego.InsertarCliente(ClientEnti) == true)
                    {
                        lblMensaje.Text = "Registro Guardado Correctamente";
                        Response.Redirect("~/About");
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
            if (this.txtIdContrato.Text.Trim() != ""
               && this.txtIdDependencia.Text.Trim() != "" 
               && this.txtIdDepartamento.Text.Trim() != ""
               && this.txtUnidadAdmin.Text.Trim() != "")
            {
                try
                {

                    ClientEnti.idContratoServicio = int.Parse(txtIdContrato.Text);
                    ClientEnti.idDependencia = txtIdDependencia.Text;
                    ClientEnti.idDepartamento = txtIdDepartamento.Text;
                    ClientEnti.unidAdmin = txtUnidadAdmin.Text;

                    if (ClientNego.ActualizarCliente(ClientEnti) == true)
                    {
                        lblMensaje.Text = "Registro Actualizado Correctamente";
                        Session.RemoveAll();
                        Response.Redirect("~/About");
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
            Response.Redirect("~/About");

        }

    }
    
}