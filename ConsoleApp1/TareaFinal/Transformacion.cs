using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TareaFinal
{
    public class Transformacion
    {
        public List<object> objeto { get; set; }
        public int duracion { get; set; }

        public Transformacion(List<object> transformaciones, int duracionSegundos)
        {
            objeto = transformaciones;
            duracion = duracionSegundos;
        }

        public Transformacion()
        {
            this.objeto = new List<object>();
            this.duracion = 0;
        }
    }
}
