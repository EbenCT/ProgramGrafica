using Newtonsoft.Json;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ConsoleApp1.Tarea3
{
    internal class Objeto
    {
        [JsonProperty(Order = 1)]
        public Vertice CentroDeMasa { get; private set; }
        [JsonProperty(Order = 2)]
        public Dictionary<string, Parte> partes;
        //private float originX, originY, originZ;
        public Objeto(Vertice centro)
        {
            partes = new Dictionary<string, Parte>();
            CentroDeMasa = centro;
        }

        public void AgregarParte(string nombre, Parte parte)
        {
            partes.Add(nombre, parte);
        }

        public void Trasladar(float x, float y, float z)
        {
            foreach (Parte parte in partes.Values)
            {
                parte.Trasladar(x, y, z);
            }
        }
        public void Escalar(float n)
        {
            foreach (Parte parte in partes.Values)
            {
                parte.Escalar(n);
            }
        }
        public void Rotar(string eje, float angulo)
        {
            foreach (Parte parte in partes.Values)
            {
                parte.Rotar(eje, angulo);
            }
        }
        public void Dibujar()
        {
            foreach (Parte parte in partes.Values)
            {
                parte.Trasladar(CentroDeMasa.X, CentroDeMasa.Y, CentroDeMasa.Z);
                parte.Dibujar();
            }
        }
    }
}
