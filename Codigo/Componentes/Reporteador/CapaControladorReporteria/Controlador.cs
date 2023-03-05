using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaControladorReporteria
{
    public class Controlador
    {

        CapaModeloReporteria.Sentencias sentencias = new CapaModeloReporteria.Sentencias();

        public void ModReporteria(string ruta, string nombre_archivo, string aplicacion, string estado, string id)
        {
            //esta variables nos sirven para que la ruta no salga con vasura
            string exc = @"\\";
            string orgn = @"\";
            ruta = ruta.Replace(orgn, exc);
            //aqui con los datos que recibimos de la capavista a hora la mandamos a la funicon ModificarReporte en sentencias.cs
            sentencias.ModificarReporte(ruta, nombre_archivo, aplicacion, estado, id);
        }
    }
}
