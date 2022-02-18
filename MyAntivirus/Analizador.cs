using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MyAntivirus
{
    class Analizador
    {
        private FileInfo archivo;
        private byte[] bytesArchivo; //vector que contiene los bytes del archivo

        public Analizador(FileInfo archivo, byte[] bytesArchivo)
        {
            this.archivo = archivo;
            this.bytesArchivo = bytesArchivo;
        }

        /// <summary>
        /// contiene todos los virus conocidos
        /// </summary>
        public void cargarVirus()
        {

            Virus usama = new Virus("usama", new byte[] { 15, 30, 15, 49 });
            Virus amtrax = new Virus("amtrax",new byte[] { 72, 72, 15, 29 });
            Virus ebola = new Virus("ebola", new byte[] { 29, 32, 53, 29 });
            Virus ah1n1 = new Virus("ah1n1", new byte[] { 72, 32, 32, 20 });
            Virus covid19 = new Virus("covid19", new byte[] { 30, 25, 20, 19 });

        }

        public byte[] leerArchivo()
        {
            string ruta = this.archivo.FullName;
            bytesArchivo = File.ReadAllBytes(ruta);
            return bytesArchivo;
            throw new IOException();
        }

    }
}
