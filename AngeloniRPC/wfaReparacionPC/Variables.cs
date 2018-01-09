using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace wfaReparacionPC
{
    static class Variables
    {
        //string de conexion a bd
        public static String conexionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ReparacionPC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static SqlConnection conexion = new SqlConnection(conexionString); //conexion a bd
    }
}
