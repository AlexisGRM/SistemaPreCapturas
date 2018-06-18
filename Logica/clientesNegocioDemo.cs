using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Datos;

namespace Logica
{
    public class clientesNegocioDemo
    {
        clienteDatosDemo _ClienteDatos = new clienteDatosDemo();

        public bool InsertarCliente(atributosDemo CliNegocio)
        {
            return _ClienteDatos.InsertarCliente(CliNegocio);
        }

        public bool ActualizarCliente(atributosDemo CliNegocio)
        {
            return _ClienteDatos.ActualizarCliente(CliNegocio);
        }

        public bool EliminarCliente(atributosDemo CliNegocio)
        {
            return _ClienteDatos.EliminarCliente(CliNegocio);
        }

        public DataTable ListarClientes(string parametro)
        {
            return _ClienteDatos.ListarClientes(parametro);
        }
        public atributosDemo ConsultarCliente(string codigo)
        {
            return _ClienteDatos.ConsultarCliente(codigo);
        }
    }
}
