using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_de_best_Fit
{
    //Clase marco para cada proceso
    public class ClsProceso
    {
        private int tamanio;

        public ClsProceso()
        {
            //Aqui se asigna de manera aleatoria el tamaño del proceso
            Random rnd = new Random();
            tamanio = rnd.Next(1,45);
        }

        public int Tamanio { get { return tamanio; } }
    }
}
