using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using KRISA.Modelo.ModuloCamara;

namespace KRISA.Datos
{
    public class KrisaDB : System.Data.Entity.DbContext
    {
       public DbSet<Camara> Camaras { set; get; }
    }
}
