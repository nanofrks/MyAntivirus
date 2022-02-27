using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Extensions.Logging;

namespace MyAntivirus
{
    public partial class frm_antivirus : Form
    {
        Analizador analizador = new Analizador();

        public frm_antivirus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog explorador = new OpenFileDialog();
                explorador.ShowDialog(this);

                FileInfo archivo = new FileInfo(explorador.FileName);
                lbl_ruta.Text = archivo.FullName;

                analizador.cargarVirus();

                string cadena = "";

                try
                {
                    //lectura de bytes seleccionados por el usuario
                    byte[] bytesArchivo = analizador.leerArchivo(archivo);

                    for (int i = 0; i < bytesArchivo.Length; i++)
                    {
                        cadena += bytesArchivo[i] + " ";
                    }

                    txt_secuencia.Text = cadena;

                }
                catch (IOException ex)
                {
                    lbl_res.Text = ex.Message;
                }

            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (analizador.BytesArchivo == null)
            {
                lbl_res.Text = "Debe seleccionar un archivo para poder analizarlo";
            }
            else
            {
                analizador.detectorVirus();
                lbl_res.Text = analizador.Txt_virus();

                analizador.reset();
            }
        }

        private void lbl_res_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ruta_Click(object sender, EventArgs e)
        {

        }
    }
}
