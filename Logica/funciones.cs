﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Datos;
using System.Data.SqlClient;


namespace Logica
{
    public class funciones
    {
        ConexionDatos obj = new ConexionDatos();
        ConexionDatosUpdate objUpdate = new ConexionDatosUpdate();

        public int insertDato(Atributos solicitud)
        {

            return obj.insert(solicitud);
        }
        public bool ActualizarCliente(Atributos CliNegocio)
        {
            return objUpdate.ActualizarCliente(CliNegocio);
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
