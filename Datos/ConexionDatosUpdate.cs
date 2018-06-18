using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class ConexionDatosUpdate
    {
        SqlConnection cnx;
        Atributos mcEntidad = new Atributos();
        conexionDemo MiConexi = new conexionDemo();
        SqlCommand cmd = new SqlCommand();
        bool vexito;
        public ConexionDatosUpdate()
        {
            cnx = new SqlConnection(MiConexi.GetConexContrato());
        }
        public bool ActualizarCliente(Atributos mcEntidad)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdatePrecontrato";
            try
            {
             

                cmd.Parameters.Add(new SqlParameter("@idContratoServicio", SqlDbType.VarChar, 100));
                cmd.Parameters["@idContratoServicio"].Value = mcEntidad.idContratoServicio;

                cmd.Parameters.Add(new SqlParameter("@dependencia", SqlDbType.VarChar, 100));
                cmd.Parameters["@dependencia"].Value = mcEntidad.idDependencia;

                cmd.Parameters.Add(new SqlParameter("@departamento", SqlDbType.VarChar, 100));
                cmd.Parameters["@departamento"].Value = mcEntidad.idDepartamento;

                cmd.Parameters.Add(new SqlParameter("@partida", SqlDbType.VarChar, 100));
                cmd.Parameters["@partida"].Value = mcEntidad.idPartida;

                cmd.Parameters.Add(new SqlParameter("@ejercicioPartida", SqlDbType.VarChar, 100));
                cmd.Parameters["@ejercicioPartida"].Value = mcEntidad.ejercicioPartida;

                cmd.Parameters.Add(new SqlParameter("@unidadAdministrativa", SqlDbType.VarChar, 100));
                cmd.Parameters["@unidadAdministrativa"].Value = mcEntidad.unidAdmin;

                cmd.Parameters.Add(new SqlParameter("@ejercioUnidad", SqlDbType.VarChar, 100));
                cmd.Parameters["@ejercioUnidad"].Value = mcEntidad.ejercicioUnidad;

                cmd.Parameters.Add(new SqlParameter("@solicitante", SqlDbType.VarChar, 100));
                cmd.Parameters["@solicitante"].Value = mcEntidad.idSolicitante;

                cmd.Parameters.Add(new SqlParameter("@Ocupacion", SqlDbType.VarChar, 100));
                cmd.Parameters["@Ocupacion"].Value = mcEntidad.OC_IDOcupacion;

                cmd.Parameters.Add(new SqlParameter("@prestadorServicios", SqlDbType.VarChar, 100));
                cmd.Parameters["@prestadorServicios"].Value = mcEntidad.idPrestServic;

                cmd.Parameters.Add(new SqlParameter("@ImporteTotal", SqlDbType.VarChar, 100));
                cmd.Parameters["@ImporteTotal"].Value = mcEntidad.importTotal;

                cmd.Parameters.Add(new SqlParameter("@ImporteMensual", SqlDbType.VarChar, 100));
                cmd.Parameters["@ImporteMensual"].Value = mcEntidad.importMnesual;

                cmd.Parameters.Add(new SqlParameter("@FechaInicial", SqlDbType.VarChar, 100));
                cmd.Parameters["@FechaInicial"].Value = mcEntidad.fechaIni;

                cmd.Parameters.Add(new SqlParameter("@FechaFinal", SqlDbType.VarChar, 100));
                cmd.Parameters["@FechaFinal"].Value = mcEntidad.fechaFin;

                cmd.Parameters.Add(new SqlParameter("@idEstatusContratoServicios", SqlDbType.VarChar, 100));
                cmd.Parameters["@idEstatusContratoServicios"].Value = mcEntidad.idEstatContratServic;

                cmd.Parameters.Add(new SqlParameter("@usuarioCap", SqlDbType.VarChar, 100));
                cmd.Parameters["@usuarioCap"].Value = mcEntidad.usuarioCap;

                cmd.Parameters.Add(new SqlParameter("@compuCap", SqlDbType.VarChar, 100));
                cmd.Parameters["@compuCap"].Value = mcEntidad.compuCap;

                cmd.Parameters.Add(new SqlParameter("@fechaCap", SqlDbType.VarChar, 100));
                cmd.Parameters["@fechaCap"].Value = mcEntidad.fechaCap;

                cmd.Parameters.Add(new SqlParameter("@Actividades", SqlDbType.VarChar, 100));
                cmd.Parameters["@Actividades"].Value = mcEntidad.activ;

                cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar, 100));
                cmd.Parameters["@Observaciones"].Value = mcEntidad.observac;

                cmd.Parameters.Add(new SqlParameter("@ST_IDSubTipo", SqlDbType.VarChar, 100));
                cmd.Parameters["@ST_IDSubTipo"].Value = mcEntidad.ST_IDSubtipo;

                cnx.Open();
                cmd.ExecuteNonQuery();
                vexito = true;
            }
            catch (SqlException)
            {
                vexito = false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return vexito;
        }
    }
}
