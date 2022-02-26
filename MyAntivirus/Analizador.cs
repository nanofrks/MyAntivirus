using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MyAntivirus
{
    class Analizador
    {
        private FileInfo archivo;
        private byte[] bytesArchivo = null; //vector que contiene los bytes del archivo
        List<Virus> listaVirus = new List<Virus>(5);


        public Analizador(FileInfo archivo)
        {
            this.archivo = archivo;
            string ruta = archivo.FullName;
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

            listaVirus.Add(usama);
            listaVirus.Add(amtrax);
            listaVirus.Add(ebola);
            listaVirus.Add(ah1n1);
            listaVirus.Add(covid19);

        }

        public byte[] leerArchivo()
        {
            string ruta = this.archivo.FullName;
            bytesArchivo = File.ReadAllBytes(ruta);
            return bytesArchivo;
            throw new IOException();
        }

        public void detectorVirus()
        {
            for (int i = 0; i < bytesArchivo.Length - 3; i++)
            {
                //q0
                //Detectar "USAMA"
                if(bytesArchivo[i] == listaVirus[0].getSecuenciaVirus()[0] 
                    && bytesArchivo[i+1] == listaVirus[0].getSecuenciaVirus()[1]
                    && bytesArchivo[i+2] == listaVirus[0].getSecuenciaVirus()[2]
                    && bytesArchivo[i + 3] == listaVirus[0].getSecuenciaVirus()[3])
                {
                    Console.WriteLine("encontrado USAMA");
                }

            }
        }

    }
}
