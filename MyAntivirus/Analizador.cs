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

        private byte cont_usama = 0, cont_amtrax = 0, cont_ebola = 0, cont_ah1n1 = 0, cont_covid19 = 0;

        public byte[] BytesArchivo { get => bytesArchivo; set => bytesArchivo = value; }

        public Analizador()
        {

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

        public byte[] leerArchivo(FileInfo archivo)
        {
            this.archivo = archivo;
            string path = archivo.FullName;
            BytesArchivo = File.ReadAllBytes(path);
            return BytesArchivo;
            throw new IOException();
        }

        public void detectorVirus()
        {
            for (int i = 0; i < BytesArchivo.Length - 3; i++)
            {
                //Detectar "USAMA"
                if(BytesArchivo[i] == listaVirus[0].getSecuenciaVirus()[0] 
                    && BytesArchivo[i+1] == listaVirus[0].getSecuenciaVirus()[1]
                    && BytesArchivo[i+2] == listaVirus[0].getSecuenciaVirus()[2]
                    && BytesArchivo[i + 3] == listaVirus[0].getSecuenciaVirus()[3])
                {
                    cont_usama++;
                }

                //Detectar "AMTRAX"
                if (BytesArchivo[i] == listaVirus[1].getSecuenciaVirus()[0]
                    && BytesArchivo[i + 1] == listaVirus[1].getSecuenciaVirus()[1]
                    && BytesArchivo[i + 2] == listaVirus[1].getSecuenciaVirus()[2]
                    && BytesArchivo[i + 3] == listaVirus[1].getSecuenciaVirus()[3])
                {
                    cont_amtrax++;
                }

                //Detectar "éBola"
                if (BytesArchivo[i] == listaVirus[2].getSecuenciaVirus()[0]
                    && BytesArchivo[i + 1] == listaVirus[2].getSecuenciaVirus()[1]
                    && BytesArchivo[i + 2] == listaVirus[2].getSecuenciaVirus()[2]
                    && BytesArchivo[i + 3] == listaVirus[2].getSecuenciaVirus()[3])
                {
                    cont_ebola++;
                }

                //Detectar "Ah1N1"
                if (BytesArchivo[i] == listaVirus[3].getSecuenciaVirus()[0]
                    && BytesArchivo[i + 1] == listaVirus[3].getSecuenciaVirus()[1]
                    && BytesArchivo[i + 2] == listaVirus[3].getSecuenciaVirus()[2]
                    && BytesArchivo[i + 3] == listaVirus[3].getSecuenciaVirus()[3])
                {
                    cont_ah1n1++;
                }

                //Detectar "Covid19"
                if (BytesArchivo[i] == listaVirus[4].getSecuenciaVirus()[0]
                    && BytesArchivo[i + 1] == listaVirus[4].getSecuenciaVirus()[1]
                    && BytesArchivo[i + 2] == listaVirus[4].getSecuenciaVirus()[2]
                    && BytesArchivo[i + 3] == listaVirus[4].getSecuenciaVirus()[3])
                {
                    cont_covid19++;
                }

            }
        }

        /// <summary>
        /// Construye un mensaje para ser mostrado por pantalla
        /// </summary>
        /// <returns><Textoinformativo>
        public string Txt_virus()
        {
            string msg="";

            if (cont_usama>=1||cont_amtrax>= 1||cont_ebola>= 1||cont_ah1n1 >= 1|| cont_covid19 >= 1)
            {
                msg = "Encontrado:\n";

                if (cont_usama >= 1)
                {
                    msg += cont_usama + " Secuencias de Usama\n";
                }

                if (cont_amtrax >= 1)
                {
                    msg += cont_amtrax + " Secuencias de Amtrax\n";
                }

                if (cont_ebola >= 1)
                {
                    msg += cont_ebola +" Secuencias de éBola\n";
                }

                if (cont_ah1n1 >= 1)
                {
                    msg += cont_ah1n1 + " Secuencias de Ah1N1\n";
                }

                if (cont_covid19 >= 1)
                {
                    msg += cont_covid19 + " Secuencias de Covid19\n";
                }
            }
            else
            {
                msg = "No se encontró ninguna secuencia de virus";
            }
            return msg;
        }

        public void reset()
        {
            cont_usama = 0;cont_amtrax = 0;cont_ebola = 0;cont_ah1n1 = 0;cont_covid19 = 0;
        }

    }
}
