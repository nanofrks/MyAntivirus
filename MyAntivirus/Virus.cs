﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyAntivirus
{
    class Virus
    {
        private string nombreVirus; //contiene el nombre del virus
        private byte [] secuenciaVirus; //contiene la secuencia de bytes del virus

        public Virus(string nombreVirus, byte[] secuenciaVirus)
        {
            this.nombreVirus = nombreVirus;
            this.secuenciaVirus = secuenciaVirus;
        }
    } 
}
