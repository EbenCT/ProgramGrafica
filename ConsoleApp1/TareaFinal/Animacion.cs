using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.TareaFinal
{
    public class Animacion
    {
        public List<Transformacion> transformaciones { get; set; }
        private Thread hiloEjecucion;
        private bool enPausa;
        private bool detener;

        public Animacion()
        {
            transformaciones = new List<Transformacion>();
            hiloEjecucion = null;
            enPausa = false;
            detener = false;
        }

        public Animacion(Animacion animacion)
        {
            transformaciones = new List<Transformacion>();
            foreach (Transformacion transf in animacion.transformaciones)
            {
                transformaciones.Add(transf);
            }
            hiloEjecucion = null;
            enPausa = false;
            detener = false;
        }

        public void AñadirTransformacion(List<object> transformacion, int duracion)
        {
            transformaciones.Add(new Transformacion(transformacion, duracion));
        }

        public void Empezar()
        {
            if (hiloEjecucion == null || !hiloEjecucion.IsAlive)
            {
                enPausa = false;
                detener = false;
                hiloEjecucion = new Thread(EjecutarTransformaciones);
                hiloEjecucion.Start();
            }
            else if (enPausa)
            {
                enPausa = false;
            }
        }

        public void Pausar()
        {
            enPausa = !enPausa;
        }

        public void Detener()
        {
            detener = true;
        }

        private void EjecutarTransformaciones()
        {
            foreach (Transformacion transformacion in transformaciones)
            {
                int tiempoRestante = transformacion.duracion;

                while (tiempoRestante > 0)
                {
                    if (detener)
                    {
                        return;
                    }

                    if (!enPausa)
                    {
                        // Ejecutar la transformación
                        for (int i = 0; i < transformacion.objeto.Count; i++)
                        {
                            object obj = transformacion.objeto[i];
                            obj.GetType().GetMethod("Invoke").Invoke(obj, null);
                        }
                        tiempoRestante--;
                    }
                    
                }
            }
        }
    }

}
