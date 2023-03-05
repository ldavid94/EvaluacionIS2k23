using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.ComponentModel;
using System.Windows.Forms;


namespace CapaVistaReporteria
{
    public partial class Inicio : Form
    {
        CapaControladorReporteria.Controlador controlador = new CapaControladorReporteria.Controlador();
        public Inicio()
        {
            
        }

        

        private void btn_examinar_Click(object sender, EventArgs e)
        {
                 
            OpenFileDialog v1 = new OpenFileDialog();
            v1.Filter = "All files (*.*)|*.*";
            if (v1.ShowDialog() == DialogResult.OK)
            {
                txt_ruta.Text = v1.FileName;
                string[] separatingStrings = { "\\" };
                string text = txt_ruta.Text;
                string[] words = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                string db = "";
                Boolean ruta = false;
                for (int i = 0; i < words.Length; i++)
                {
                    if (ruta)
                    {
                        if (i < words.Length - 1)
                        {
                            db += words[i] + '\\';
                        }
                        else
                        {
                            db += words[i];
                        }
                    }
                    if (words[i].Equals("Reportes"))
                    {
                        ruta = true;
                    }
                }
                txt_ruta.Text = db;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_ver_reporte_Click(object sender, EventArgs e)
        {
        }
        void GridFill()
        {

        }


        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            
        }

        void Clear()
        {
            
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabla_registro_DoubleClick(object sender, EventArgs e)
        {
            //se habilita la funcion de modificar y eliminar para el reporte seleccionado 
            if (tbl_regreporteria.CurrentRow.Index != -1)
            {

                btn_guardar.Enabled = false;
                btn_modificar.Enabled = true;
                btn_eliminar.Enabled = true;

                idReporte.Text = tbl_regreporteria.CurrentRow.Cells[0].Value.ToString();
                txt_ruta.Text = tbl_regreporteria.CurrentRow.Cells[1].Value.ToString();
                txt_nombre.Text = tbl_regreporteria.CurrentRow.Cells[2].Value.ToString();
                txt_aplicacion.Text = tbl_regreporteria.CurrentRow.Cells[3].Value.ToString();
                txt_estado.Text = tbl_regreporteria.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            //aqui recibimos los nuevos datos en los diferente txtbox y se lo mandamos a la funcion ModReporteador que esta en controlador.cs
           controlador.ModReporteria(txt_ruta.Text, txt_nombre.Text, txt_aplicacion.Text,txt_estado.Text, idReporte.Text);
        }

        private void cargarCategorias()
        {
            
        }
    }
}
