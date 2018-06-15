using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapturaPrecontratos
{
    public partial class ejemplo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

            //DropDownList4.Visible = true;

        }

        protected void DropDownList3_TextChanged(object sender, EventArgs e)
        {
            ///////////////////

        }

        Atributos obj = new Atributos();

        short ejercicio = 0;
        
        funciones fun = new funciones();
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime ej = DateTime.Parse(FechaInicial.Text);
            ejercicio =(short) ej.Year;
            //objAtributos.nombre = txbNombre.Text;
            obj.paterno = paterno.Text;
            obj.materno = materno.Text;
            obj.nombre = nombres.Text;
            obj.fechaNac = DateTime.Parse(FechaNacimiento.Text);
            obj.genero = DropDownList1.Text;
            obj.lugarNac = int.Parse(lugarNacimiento.Text);
            obj.rfc = rfc.Text;
            obj.curp = curp.Text;
            obj.nacion = byte.Parse(Nacionalidades.Text);
            obj.calle = calle.Text;
            obj.numExter = exterior.Text;
            obj.numInter = interior.Text;
            obj.colonia = colonia.Text;
            obj.ciudad = int.Parse(DDLMunicipio.Text);
            obj.cp = cp.Text;
            obj.compuCap = pccapturador.Text;
            obj.usuarioCap = capturador.Text;
            DateTime localDate = DateTime.Now;
            obj.fechaCap = localDate;

            //contratos
            obj.idDependencia = dependencia.Text;
            obj.idDepartamento = departamento.Text;
            obj.idPartida = int.Parse(partidaCodigo.Text);
            obj.ejercicioPartida = ejercicio;
            obj.unidAdmin = unidadAdministrativa.Text;
            obj.ejercicioUnidad = ejercicio;
            obj.idSolicitante = int.Parse(solicitante.Text);
            obj.OC_IDOcupacion = ocupacion.Text;
            obj.importTotal = decimal.Parse(importeTotal.Text);
            obj.importMnesual = decimal.Parse(ImporteMensual.Text);
            obj.fechaIni = DateTime.Parse(FechaInicial.Text);
            obj.fechaFin = DateTime.Parse(FechaFinal.Text);
            obj.idEstatContratServic = short.Parse(estatusContrato.Text);
            obj.activ = actividades.Text;
            obj.observac = observaciones.Text;

            int Solicitud = fun.insertPreContrato(obj);
         
            Response.Write(Solicitud.ToString());
            
            Response.Redirect("~/About");
            
        }

        protected void ImporteMensual_TextChanged(object sender, EventArgs e)
        {
            DateTime fi = DateTime.Parse(FechaInicial.Text);
            DateTime ff = DateTime.Parse(FechaFinal.Text);
            int inporte = int.Parse(ImporteMensual.Text);

            int fim = fi.Month;
            int ffm = ff.Month;
            int total = inporte * ( ffm - fim);
            importeTotal.Text = total.ToString();


            //
        }
    }
}