using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using KRISA.Modelo.ModuloCamara;

namespace KRISA.Datos.ModuloCamara
{
    public class CamaraDB
    {
        private KrisaDB db;

        public CamaraDB()
        {
            db = new KrisaDB();
        }

        public void Agregar(Camara camara)
        {
            if(Verificar(camara)){
                db.Camaras.Add(camara);
                db.SaveChanges();
            }

        }
        public void Suspender(Camara camara)
        {
            Camara camaraSuspendida = Buscar(camara);
            if (camaraSuspendida != null)
            {

                camaraSuspendida.isActivo = false;
                db.SaveChanges();
            }
        }

        public List<Camara> RecuperarTodas()
        {
            List<Camara> resultado;
            return  resultado = (from cam in db.Camaras select cam).ToList<Camara>();
        }

        public Camara Buscar(Camara camara)
        {
            var resultado = from cam in db.Camaras where cam == camara select cam;
            Camara camaraEncontrada = resultado.First(); 
            return camaraEncontrada;
        }

        public Camara Buscar(int idCamara)
        {
            var resultado = from cam in db.Camaras where cam.ID == idCamara select cam;
            Camara camaraEncontrada = resultado.First();
            return camaraEncontrada;
        }


        public Camara Buscar(string nombreCamara)
        {
            var resultado = from cam in db.Camaras where cam.Nombre == nombreCamara select cam;
            Camara camaraEncontrada = resultado.First();
            return camaraEncontrada;
        }

        public void Actualizar(Camara camara)
        {
            Camara camaraActualizada = Buscar(camara);
            if (camaraActualizada != null)
            {
                camaraActualizada = camara;
                db.SaveChanges();
            }
        }

        public bool Verificar(Camara camara)
        {
            var resultado = from cam in db.Camaras where cam.Nombre == camara.Nombre select cam;
            return resultado.Count<Camara>() == 0 ? false : true;
        }
    }
}
