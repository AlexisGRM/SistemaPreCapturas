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
    public class ConexionDatosConsulta
    {
        SqlConnection cnx;
        Atributos mcEntidad = new Atributos();
        conexionDemo MiConexi = new conexionDemo();
        SqlCommand cmd = new SqlCommand();
        bool vexito;
        public ConexionDatosConsulta()
        {
            cnx = new SqlConnection(MiConexi.GetConexContrato());
        }
        public bool InsertarCliente(Atributos mcEntidad)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_insertar";
            try
            {

                cmd.Parameters.Add(new SqlParameter("@idDependencia", SqlDbType.VarChar, 50));
                cmd.Parameters["@idDependencia"].Value = mcEntidad.idDependencia;
                cmd.Parameters.Add(new SqlParameter("@idDepartamento", SqlDbType.VarChar, 100));
                cmd.Parameters["@idDepartamento"].Value = mcEntidad.idDepartamento;
                cmd.Parameters.Add(new SqlParameter("@idUnidadAdmin", SqlDbType.VarChar, 100));
                cmd.Parameters["@idUnidadAdmin"].Value = mcEntidad.unidAdmin;
                cmd.Parameters.Add(new SqlParameter("@idEstatusContrato", SqlDbType.Int));
                cmd.Parameters["@idEstatusContrato"].Value = mcEntidad.idEstatContratServic;
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
        public bool ActualizarCliente(Atributos mcEntidad)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_actualizar";
            try
            {
                cmd.Parameters.Add(new SqlParameter("@idContrato", SqlDbType.VarChar, 5));
                cmd.Parameters["@idContrato"].Value = mcEntidad.idContratoServicio;
                cmd.Parameters.Add(new SqlParameter("@idDependencia", SqlDbType.VarChar, 50));
                cmd.Parameters["@idDependencia"].Value = mcEntidad.idDependencia;
                cmd.Parameters.Add(new SqlParameter("@idDepartamento", SqlDbType.VarChar, 100));
                cmd.Parameters["@idDepartamento"].Value = mcEntidad.idDepartamento;
                cmd.Parameters.Add(new SqlParameter("@idUnidadAdmin", SqlDbType.VarChar, 100));
                cmd.Parameters["@idUnidadAdmin"].Value = mcEntidad.unidAdmin;
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
        public bool EliminarCliente(Atributos mcEntidad)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_eliminar";
            try
            {
                cmd.Parameters.Add(new SqlParameter("@idContrato", SqlDbType.VarChar, 5));
                cmd.Parameters["@idContrato"].Value = mcEntidad.idContratoServicio;
                cmd.Parameters.Add(new SqlParameter("@idEstadoContrato", SqlDbType.Int));
                cmd.Parameters["@idEstadoContrato"].Value = mcEntidad.idEstatContratServic;
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
        public DataTable ListarClientes(string parametro)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "proc_listar";
                cmd.Parameters.Add(new SqlParameter("@idDependencia", parametro));
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "ContratoServicio");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            return (dts.Tables["ContratoServicio"]);
        }
        public Atributos ConsultarCliente(string codigo)
        {
            try
            {
                SqlDataReader dtr;
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "proc_consultar";
                cmd.Parameters.Add(new SqlParameter("@idContrato", SqlDbType.VarChar, 10));
                cmd.Parameters["@idContrato"].Value = codigo;
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    mcEntidad.idContratoServicio = Convert.ToInt16(dtr[0]);
                    mcEntidad.idDependencia = Convert.ToString(dtr[1]);
                    mcEntidad.idDepartamento = Convert.ToString(dtr[2]);
                    mcEntidad.unidAdmin = Convert.ToString(dtr[3]);
                }
                cnx.Close();
                cmd.Parameters.Clear();
                return mcEntidad;
            }
            catch (SqlException)
            {
                throw new Exception();
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
        }
    }
}
