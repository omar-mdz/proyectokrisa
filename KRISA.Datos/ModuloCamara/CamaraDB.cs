using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using KRISA.Modelo.ModuloCamara;

namespace KRISA.Datos.ModuloCamara
{
    public class CamaraDB : DbContext
    {
        DbSet<Camara> Camaras { set; get; }

        public void Agregar(Camara camara)
        {
            Camaras.Add(camara);
        }
        public void Suspender(Camara camara)
        {

        }

        public List<Camara> RecuperarTodas()
        {
            //return camaras = from cam in Camaras select cam;
            return null;
        }

        public Camara Buscar(Camara camara)
        {
            // var camaraEncontrada = from cam in Camaras where cam.Nombre == camara.Nombre select cam;
            //return camaraEncontrada;
            return null;
        }

        public Camara Buscar(int idCamara)
        {
            return null;
        }


        public Camara Buscar(string nombreCamara)
        {
            return null;
        }

        public void Actualizar(Camara camara)
        {
        }
    }
}
