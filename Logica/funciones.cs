using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Logica;
using Datos;
using System.Data.SqlClient;


namespace Logica
{
    public class funciones
    {
        ConexionDatos obj = new ConexionDatos();
        ConexionDatosUpdate objUpdate = new ConexionDatosUpdate();
        ConexionDatosConsulta _ClienteDatos = new ConexionDatosConsulta();

        public int insertDato(Atributos solicitud)
        {

            return obj.insert(solicitud);
        }
        public int insertPreContrato(Atributos datos)
        {
            return obj.insertPreContrato(datos);
        }

        /*public bool ActualizarCliente(Atributos CliNegocio)
        {
            return objUpdate.ActualizarCliente(CliNegocio);
        }

        public DataTable ListarClientes(string parametro)
        {
            return objConsulta.ListarClientes(parametro);
        }
        public Atributos ConsultarCliente(string contrato)
        {
            return objConsulta.ConsultarCliente(contrato);
        }*/





        public bool InsertarCliente(Atributos CliNegocio)
        {
            return _ClienteDatos.InsertarCliente(CliNegocio);
        }

        public bool ActualizarCliente(Atributos CliNegocio)
        {
            return _ClienteDatos.ActualizarCliente(CliNegocio);
        }

        public bool EliminarCliente(Atributos CliNegocio)
        {
            return _ClienteDatos.EliminarCliente(CliNegocio);
        }

        public DataTable ListarClientes(string parametro)
        {
            return _ClienteDatos.ListarClientes(parametro);
        }
        public Atributos ConsultarCliente(string codigo)
        {
            return _ClienteDatos.ConsultarCliente(codigo);
        }

        /*public int insertContrato(Atributos solicitud2)
        {
            return obj.insertContrato(solicitud2);
        }*/

        /* public int insertArchivo(Atributos solicitud3)
         {
             return obj.InsertArchivo(solicitud3);
         }*/
    }
}
