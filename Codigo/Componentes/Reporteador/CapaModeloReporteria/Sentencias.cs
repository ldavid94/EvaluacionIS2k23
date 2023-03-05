using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModeloReporteria
{
    public class Sentencias
    {
        string tabla_reporteria = "reportes";
        Conexion conexion = new Conexion();

        
        public void ModificarReporte(string ruta, string nombre_archivo, string aplicacion, string estado, string id)
        {
            //aqui con los datos recibidos le mandamos la instruccion a la base de datos para poder lo modificar lo buscamos por id
            string sql = "UPDATE" + tabla_reporteria + "SET" +
                         "ruta = '" + ruta + "'," +
                         "nombre_archivo = '" + nombre_archivo + "'," +
                         "aplicacion = '" + aplicacion + "'," +
                         "estado = '" + estado + "' " +
                         "WHERE (idReporte = '" + id + "');";

            //aqui estamos haciendo la comprobacion de que si uvo una coneccion con la base de datos
            try
            {
                OdbcCommand consulta = new OdbcCommand(sql, conexion.conexion());
                consulta.ExecuteNonQuery();
                MessageBox.Show("Modificado");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en CapaModeloReporteria --> Sentencias" + e);
            }


        }
    }
}
