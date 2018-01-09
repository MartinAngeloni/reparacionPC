using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace wfaReparacionPC
{
    static class DAOCliente
    {

        //para rellenar un dataTable
        static SqlDataAdapter sqaCliente = new SqlDataAdapter("select * from", Variables.conexion);

        static DataTable cliente = new DataTable(); 


        public static void obtenerClientes()
        {
            cliente = new DataTable();
            sqaCliente.Fill(cliente); //rellenamos dataTable
        }

        public static void crearCliente()
        {
            new SqlCommandBuilder(sqaCliente);
            sqaCliente.Update(cliente);
        }


    }
}
