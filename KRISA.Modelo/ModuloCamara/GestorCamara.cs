using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KRISA.Modelo.ModuloCamara
{
    public class GestorCamara
    {
        // Agregar una cámara a la base de datos del sistema
        public void Agregar(Camara camara)
        {
            
        }
        /* Pone inactiva una cámara en la base de datos
         * del sistema
         * 
         */
        public void Suspender(Camara camara)
        {
        }


        /*
         *  Comprueba que exista una cámara en el sistema
         */
        public bool Verificar(Camara camara)
        {
            return true;
        }

        /* 
         * Busca una cámara en la base de datos del sistema
         * 
         */
        public Camara Buscar(int id)
        {
            return null;
        }

        public Camara Buscar(string nombre)
        {
            return null;
        }


        /*
         * Obtiene la lista de dispositivos de video 
         * conectados al equipo
         */
        public List<Camara> ObtenerCamaras()
        {
            throw new NotImplementedException();
        }
    }
}
