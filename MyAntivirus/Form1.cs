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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog explorador = new OpenFileDialog();
            explorador.ShowDialog(this);

            FileInfo archivo = new FileInfo(explorador.FileName);
            lbl_ruta.Text = archivo.FullName;

            Analizador analizador = new Analizador();
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



            } catch (IOException ex)
            {
                lbl_res.Text = ex.Message;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
