using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KRISA.Modelo.ModuloCamara
{
    public class Video
    {
        public Camara CamaraVideo { set; get; }
        public byte[] Frames { set; get; }
    }
}
