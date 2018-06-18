using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class conexionDemo
    {
        public string GetConex()
        {
            string strConex = ConfigurationManager.ConnectionStrings["conexionDemo"].ConnectionString;
            if (object.ReferenceEquals(strConex, string.Empty))
            {
                return string.Empty;
            }
            else
            {
                return strConex;
            }
        }

        public string GetConexContrato()
        {
            string strConex = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            if (object.ReferenceEquals(strConex, string.Empty))
            {
                return string.Empty;
            }
            else
            {
                return strConex;
            }
        }
    }
}
