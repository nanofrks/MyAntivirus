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
            byte[] bytesArchivo = null;
            Analizador analizador = new Analizador(archivo);
            analizador.cargarVirus();

            try
            {
                //lectura de bytes seleccionados por el usuario
                bytesArchivo = analizador.leerArchivo();
                lbl_ruta.Text = archivo.FullName;

            } catch(IOException ex)
            {
                lbl_res.Text = ex.Message;
            }

            string cadena = "";
            for(int i = 0; i< bytesArchivo.Length; i++)
            {
                cadena += bytesArchivo[i] + " ";
            }
            if (cadena == "")
            {
                txt_secuencia.Text = bytesArchivo.Length.ToString();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
