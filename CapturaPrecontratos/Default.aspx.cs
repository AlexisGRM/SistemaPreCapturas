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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        Atributos objAtributos = new Atributos();
        funciones objFunc = new funciones();
        /*byte value1;
        byte value2;
        byte value3;
        byte value4;
        byte value5;
        byte value6;
        byte value7;
        byte value8;*/

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            objAtributos.nombre = txbNombre.Text;
            objAtributos.materno = txbMaterno.Text;
            objAtributos.paterno = txbPaterno.Text;
            DateTime txtMyDate = DateTime.Parse(txbFechaNac.Text);
            objAtributos.fechaNac = txtMyDate;
            objAtributos.rfc = txbRFC.Text;
            objAtributos.lugarNac = Convert.ToInt32(ddlLugarNac.Text);
            objAtributos.nacion = byte.Parse(ddlNacion.Text);
            objAtributos.calle = txbCalle.Text;
            objAtributos.numExter = txbExterior.Text;
            objAtributos.numInter = txbInterior.Text;
            objAtributos.colonia = txbColonia.Text;
            objAtributos.cp = txbCp.Text;
            objAtributos.ciudad = Convert.ToInt32(ddlCiudad.Text);
            objAtributos.genero = ddlGenero.Text;
            objAtributos.curp = txbCurp.Text;
            objAtributos.idEstatus = byte.Parse(ddlStatus.Text);
            objAtributos.usuarioCap = txbUsuarioCap.Text;
            DateTime txtMyDate2 = DateTime.Parse(txbFechaCap.Text);
            objAtributos.fechaCap = txtMyDate2;
            objAtributos.compuCap = txbCompuCap.Text;

            objAtributos.unidAdmin = ddlUnidAdmin.Text;
            objAtributos.ejercicioUnidad = Convert.ToInt16(txbUnidAdminEjerc.Text);
            objAtributos.idDependencia = ddlDepend.Text;
            objAtributos.idDepartamento = ddlDepart.Text;
            objAtributos.idPartida = Convert.ToInt32(ddlPartida.Text);
            objAtributos.ejercicioPartida = Convert.ToInt16(txbEjercicioPart.Text);
            objAtributos.importMnesual = Decimal.Parse(txbImporMens.Text);
            objAtributos.importTotal = Decimal.Parse(txbImporTotal.Text);
            objAtributos.fechaIni = DateTime.Parse(txbFechaIni.Text);
            objAtributos.fechaFin = DateTime.Parse(txbFechaFin.Text);
            objAtributos.OC_IDOcupacion = ddlPuesto.Text;
            objAtributos.ST_IDSubtipo = byte.Parse(ddlDocen.Text);
            objAtributos.activ = txbActivi.Text;
            objAtributos.idSolicitante = Convert.ToInt32(ddlSolic.Text);
            objAtributos.observac = txbObserv.Text;
            objAtributos.usuarioCap = txbUsuarioCap.Text;
            objAtributos.compuCap = txbUsuarioCap.Text;
            objAtributos.idEstatContratServic = Convert.ToInt16(ddlStatus.Text);

            /*if (cbCurriculum.Checked ){ value1 = 1;}
            else{value1 = 9;}
            if (cbCompEstu.Checked) { value2 = 2; }
            else { value2 = 9; }
            if (cbCartaNoAnt.Checked) { value3 = 3; }
            else { value3 = 9; }
            if (cbIdentif.Checked) { value4 = 4; }
            else { value4 = 9; }
            if (cbCartaNoInha.Checked) { value5 = 5; }
            else { value5 = 9; }
            if (cbActaNac.Checked) { value6 = 6; }
            else { value6 = 9; }
            if (cbCurp.Checked) { value7 = 7; }
            else { value7 = 9; }
            if (cbComprobDom.Checked) { value8 = 8; }
            else { value8 = 9; }

            objAtributos.curriculum = value1;
            objAtributos.comprobEstu = value2;
            objAtributos.cartaNoAnte = value3;
            objAtributos.identifi = value4;
            objAtributos.cartaNoInhabi = value5;
            objAtributos.actaNac = value6;
            objAtributos.curp2 = value7;
            objAtributos.comprobDOM = value8;*/


            
            int Solicitud = objFunc.insertDato(objAtributos);
            //int solicitud2 = objFunc.insertContrato(objAtributos);
            //int solicitud3 = objFunc.insertArchivo(objAtributos);
            
            Response.Write(Solicitud.ToString());
            //Response.Write(solicitud2.ToString());
            //Response.Write(solicitud3.ToString());
            Response.Redirect("~/About");
        }

        protected void ddlPartida_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}