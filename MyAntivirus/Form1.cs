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
        Analizador analizador;

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
            analizador = new Analizador(archivo);

            try
            {
                //lectura de bytes seleccionados por el usuario
                bytesArchivo = analizador.leerArchivo();
                lbl_ruta.Text = archivo.FullName;

            } catch(IOException ex)
            {
             //logger que no sé poner (preguntarle al profe)
            }

            string cadena = "";
            for(int i = 0; i< bytesArchivo.Length; i++)
            {
                cadena += bytesArchivo[i] + " ";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
