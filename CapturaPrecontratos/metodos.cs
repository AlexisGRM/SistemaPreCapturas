using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CapturaPrecontratos
{
    public class metodos
    {

        public static string ConexionSql = ConfigurationManager.ConnectionStrings["PrecontratosConnectionString"].ToString();

        //SqlConnection sqlConect = new SqlConnection(ConexionSql);
        SqlConnection sqlConn = new SqlConnection(ConexionSql);
        public DataSet CargarMunicipios()
        {

            SqlCommand cmd = new SqlCommand("spGetMunicipios", sqlConn);
            cmd.CommandType = CommandType.StoredProcedure;
            //SqlDataReader render = cmd.ExecuteReader();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
    }
}