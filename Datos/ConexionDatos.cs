using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class ConexionDatos
    {
        //public static string ConexionSql = ConfigurationManager.ConnectionStrings["Conexion"].ToString();
        public static string ConexionSql1 = ConfigurationManager.ConnectionStrings["PrecontratosConnectionString"].ToString();

        //SqlConnection sqlConect = new SqlConnection(ConexionSql);
        SqlConnection sqlConect = new SqlConnection(ConexionSql1);

        public int ejemplo (int dato)
        {
            return 4;
        }


        public int insert(Atributos dato)
        {

            SqlCommand cmd = new SqlCommand("spInsert", sqlConect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@paterno", dato.paterno);
            cmd.Parameters.AddWithValue("@materno", dato.materno);
            cmd.Parameters.AddWithValue("@nombre", dato.nombre);
            cmd.Parameters.AddWithValue("@fechaNac", dato.fechaNac);
            cmd.Parameters.AddWithValue("@lugarNac", dato.lugarNac);
            cmd.Parameters.AddWithValue("@rfc", dato.rfc);
            cmd.Parameters.AddWithValue("@Nacion", dato.nacion);
            cmd.Parameters.AddWithValue("@calle", dato.calle);
            cmd.Parameters.AddWithValue("@numExter", dato.numExter);
            cmd.Parameters.AddWithValue("@numInter", dato.numInter);
            cmd.Parameters.AddWithValue("@colonia", dato.colonia);
            cmd.Parameters.AddWithValue("@ciudad", dato.ciudad);
            cmd.Parameters.AddWithValue("@cp", dato.cp);
            cmd.Parameters.AddWithValue("@idEstPres", dato.idEstatus);
            cmd.Parameters.AddWithValue("@fechaCap", dato.fechaCap);
            cmd.Parameters.AddWithValue("@usuarioCap", dato.usuarioCap);
            cmd.Parameters.AddWithValue("@compuCap", dato.compuCap);
            cmd.Parameters.AddWithValue("@genero", dato.genero);
            cmd.Parameters.AddWithValue("@curp", dato.curp);

            cmd.Parameters.AddWithValue("@dependencia", dato.idDependencia);
            cmd.Parameters.AddWithValue("@departamento", dato.idDepartamento);
            cmd.Parameters.AddWithValue("@partida", dato.idPartida);
            cmd.Parameters.AddWithValue("@ejercicioPartida", dato.ejercicioPartida);
            cmd.Parameters.AddWithValue("@unidadAdministrativa", dato.unidAdmin);
            cmd.Parameters.AddWithValue("@ejercioUnidad", dato.ejercicioUnidad);
            cmd.Parameters.AddWithValue("@solicitante", dato.idSolicitante);
            cmd.Parameters.AddWithValue("@Ocupacion", dato.OC_IDOcupacion);
            cmd.Parameters.AddWithValue("@ImporteTotal", dato.importTotal);
            cmd.Parameters.AddWithValue("@ImporteMensual", dato.importMnesual);
            cmd.Parameters.AddWithValue("@FechaInicial", dato.fechaIni);
            cmd.Parameters.AddWithValue("@FechaFinal", dato.fechaFin);
            cmd.Parameters.AddWithValue("@idEstatusContratoServicios", dato.idEstatus);///
            cmd.Parameters.AddWithValue("@UsuarioCaptura", dato.usuarioCap);///
            cmd.Parameters.AddWithValue("@ComputadoraCaptura", dato.compuCap);///
            cmd.Parameters.AddWithValue("@Actividades", dato.activ);
            cmd.Parameters.AddWithValue("@Observaciones", dato.observac);
            cmd.Parameters.AddWithValue("@ST_IDSubTipo", dato.ST_IDSubtipo);


            sqlConect.Open();
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            sqlConect.Close();
            return id;

        }
        public int insertPreContrato(Atributos datos)
        {
            DateTime hoy = DateTime.Today;
            SqlCommand cmd = new SqlCommand("spInsertPrecontrato", sqlConect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@paterno", datos.paterno);
            cmd.Parameters.AddWithValue("@materno", datos.materno);
            cmd.Parameters.AddWithValue("@nombre", datos.nombre);
            cmd.Parameters.AddWithValue("@fechaNac", datos.fechaNac);
            cmd.Parameters.AddWithValue("@lugarNac", datos.lugarNac);
            cmd.Parameters.AddWithValue("@rfc", datos.rfc);
            cmd.Parameters.AddWithValue("@Nacion", datos.nacion);
            cmd.Parameters.AddWithValue("@calle", datos.calle);
            cmd.Parameters.AddWithValue("@numExter", datos.numExter);
            cmd.Parameters.AddWithValue("@numInter", datos.numInter);
            cmd.Parameters.AddWithValue("@colonia", datos.colonia);
            cmd.Parameters.AddWithValue("@ciudad", datos.ciudad);
            cmd.Parameters.AddWithValue("@cp", datos.cp);
            //cmd.Parameters.AddWithValue("@idEstPres", datos.idEstatus);
            cmd.Parameters.AddWithValue("@fechaCap", hoy);
            cmd.Parameters.AddWithValue("@usuarioCap", datos.usuarioCap);
            cmd.Parameters.AddWithValue("@compuCap", datos.compuCap);
            cmd.Parameters.AddWithValue("@genero", datos.genero);
            cmd.Parameters.AddWithValue("@curp", datos.curp);

            cmd.Parameters.AddWithValue("@dependencia", datos.idDependencia);
            cmd.Parameters.AddWithValue("@departamento", datos.idDepartamento);
            cmd.Parameters.AddWithValue("@partida", datos.idPartida);
            cmd.Parameters.AddWithValue("@ejercicioPartida", datos.ejercicioPartida);
            cmd.Parameters.AddWithValue("@unidadAdministrativa", datos.unidAdmin);
            cmd.Parameters.AddWithValue("@ejercioUnidad", datos.ejercicioUnidad);
            cmd.Parameters.AddWithValue("@solicitante", datos.idSolicitante);
            cmd.Parameters.AddWithValue("@Ocupacion", datos.OC_IDOcupacion);
            cmd.Parameters.AddWithValue("@ImporteTotal", datos.importTotal);
            cmd.Parameters.AddWithValue("@ImporteMensual", datos.importMnesual);
            cmd.Parameters.AddWithValue("@FechaInicial", datos.fechaIni);
            cmd.Parameters.AddWithValue("@FechaFinal", datos.fechaFin);
            cmd.Parameters.AddWithValue("@idEstatusContratoServicios", datos.idEstatContratServic);///
            //cmd.Parameters.AddWithValue("@idEstatus", datos.idEstatus);///
            cmd.Parameters.AddWithValue("@Actividades", datos.activ);
            cmd.Parameters.AddWithValue("@Observaciones", datos.observac);
            cmd.Parameters.AddWithValue("@ST_IDSubTipo", datos.ST_IDSubtipo);
            sqlConect.Open();
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            sqlConect.Close();
            return id;
        }
        public int insertContrato(Atributos dato)
        {
            SqlCommand cmd = new SqlCommand("spSelectUnidadAdmin", sqlConect);
            cmd.CommandType = CommandType.StoredProcedure;

                       
            sqlConect.Open();
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            sqlConect.Close();
            return id;
        }

        public static string ConexionSql = ConfigurationManager.ConnectionStrings["PrecontratosConnectionString"].ToString();

        //SqlConnection sqlConect = new SqlConnection(ConexionSql);
        SqlConnection sqlConn = new SqlConnection(ConexionSql);
        public DataSet CargarMunicipios(int estado)
        {

            SqlCommand cmd = new SqlCommand("spGetMunicipios", sqlConn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@estado", estado);
            //SqlDataReader render = cmd.ExecuteReader();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        /*public int InsertArchivo(Atributos dato)
        {

            SqlCommand cmd = new SqlCommand("spInsertArchivo",sqlConect);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@curriculum",dato.curriculum);
            cmd.Parameters.AddWithValue("@comprobEstu", dato.comprobEstu);
            cmd.Parameters.AddWithValue("@cartaNoAnte", dato.cartaNoAnte);
            cmd.Parameters.AddWithValue("@identifi", dato.identifi);
            cmd.Parameters.AddWithValue("@cartaNoInhabi", dato.cartaNoInhabi);
            cmd.Parameters.AddWithValue("@actaNac", dato.actaNac);
            cmd.Parameters.AddWithValue("@curp", dato.curp2);
            cmd.Parameters.AddWithValue("@comprobDOM", dato.comprobDOM);



            sqlConect.Open();
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            sqlConect.Close();
            return id;
        }*/
    }
}
