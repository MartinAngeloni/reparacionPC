using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace wfaReparacionPC
{
    static class DAOComputadora
    {

        public static SqlDataAdapter sqaComputadora = new SqlDataAdapter("select * from", Variables.conexion);

        public static DataTable computadora = new DataTable();

        public static SqlDataAdapter sqaComputadoraSinReparar = new SqlDataAdapter("select CO.codigo_computadora as ID, CO.tipo as Computadora, CO.marca as Marca, CO.modelo as Modelo, CL.nombre as Nombre, CL.apellido as Apellido from Reparacion R inner join Computadora CO on R.codigo_computadora = CO.codigo_computadora inner join Cliente CL on CO.dni = CL.dni", Variables.conexion);

        public static DataTable computadoraSinReparar = new DataTable();

        //rellena dataTable computadoras sin reparacion
        public static void obtenerComputadoraSinReparar()
        {
            computadoraSinReparar = new DataTable();
            sqaComputadoraSinReparar.Fill(computadoraSinReparar);
        }

        public static void obtenerComputadora()
        {
            computadora = new DataTable();
            sqaComputadora.Fill(computadora); //rellenamos dataTable computadora
        }

    }
}
