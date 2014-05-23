using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KRISA.Modelo.ModuloCamara
{
    public class Camara
    {
        public int ID { set; get; }
        public string Nombre { set; get; }
        public string Dispositivo { set; get; }
        public bool isActivo{ set; get; }
    }
}
