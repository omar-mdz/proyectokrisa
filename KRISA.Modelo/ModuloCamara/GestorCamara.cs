using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KRISA.Modelo.ModuloCamara
{
    public class GestorCamara
    {

        VideoCaptureDevice videoSource;

        private bool DeviceExist = false;
        private FilterInfoCollection videoDevices;


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
        public String[] ObtenerCamaras()
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;

                String[] nombreCamaras = new String[videoDevices.Count];
                int c = 0;
                foreach (FilterInfo device in videoDevices)
                {
                    nombreCamaras[c] = device.Name;
                    c++;
                }

                return nombreCamaras;
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
                return null;

            }
        }
    }
}
