using ConsoleApp1.Tarea3;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Modelos3D
    {
        //Vertices de la television
        public static List<Cara> getTvVertices()
        {
            List<Cara> carasTv = new List<Cara>();

            Cara pantalla=new Cara();
            Vertice[] v1 = {
                new Vertice(- 5.5f, - 3.0f, 0.0f),
                new Vertice(5.5f, -3, 0f),
                new Vertice(5.5f, -3, 0f),
                new Vertice(5.5f, 3.5f, 0f),
                new Vertice(5.5f, 3.5f, 0f),
                new Vertice(-5.5f, 3.5f, 0f),
                new Vertice(- 5.5f, - 3.0f, 0.0f),
                new Vertice(-5.5f, 3.5f, 0f),
            };
            Cara Cuerpo = new Cara();
            Vertice[] v2 = {
                new Vertice(-6, -5, 0),
                new Vertice(6, -5, 0),
                new Vertice(6, 4, 0),
                new Vertice(-6, 4, 0),

                new Vertice(-6, -5, 0),
                new Vertice(-6, -5, -1),
                new Vertice(6, -5, 0),
                new Vertice(6, -5, -1),

                new Vertice(6, 4, 0),
                new Vertice(6, 4, -1),
                new Vertice(-6, 4, 0),
                new Vertice(-6, 4, -1),

                new Vertice(-6, -5, -1),
                new Vertice(6, -5, -1),
                new Vertice(6, 4, -1),
                new Vertice(-6, 4, -1),

                new Vertice(-6, -5, 0),
                new Vertice(6, -5, 0),
                new Vertice(6, -5, -1),
                new Vertice(-6, -5, -1),

                new Vertice(-6, 4, 0),
                new Vertice(6, 4, 0),
                new Vertice(6, 4, -1),
                new Vertice(-6, 4, -1),

                new Vertice(-6, -5, -1),
                new Vertice(-6, 4, -1),
                new Vertice(-6, 4, 0),
                new Vertice(-6, -5, 0),

                new Vertice(6, -5, -1),
                new Vertice(6, 4, -1),
                new Vertice(6, 4, 0),
                new Vertice(6, -5, 0),

            };
            Cara Base = new Cara();
            Vertice[] v3 = {
                new Vertice(-1, -5, -0.75f),
                new Vertice(1, -5, -0.75f),
                new Vertice(1, -6, -0.75f),
                new Vertice(-1, -6, -0.75f),

                new Vertice(-1, -5, -0.25f),
                new Vertice(1, -5, -0.25f),
                new Vertice(1, -6, -0.25f),
                new Vertice(-1, -6, -0.25f),

                new Vertice(-1, -5, -0.25f),
                new Vertice(-1, -5, -0.75f),
                new Vertice(1, -5, -0.25f),
                new Vertice(1, -5, -0.75f),

                new Vertice(-1, -6, -0.25f),
                new Vertice(-1, -6, -0.75f),
                new Vertice(1, -6, -0.25f),
                new Vertice(1, -6, -0.75f),

                new Vertice(-1, -5, -0.25f),
                new Vertice(-1, -6, -0.25f),
                new Vertice(1, -6, -0.25f),
                new Vertice(1, -5, -0.25f),
                new Vertice(-1, -5, -0.75f),
                new Vertice(-1, -6, -0.75f),
                new Vertice(1, -6, -0.75f),
                new Vertice(1, -5, -0.75f)
            };
            Cara plataforma = new Cara();
            Vertice[] v4 =
            {
                new Vertice(-4, -6, 2), // Esquina inferior izquierda
                new Vertice(4, -6, 2),
                new Vertice(4, -6, 2), // Esquina inferior derecha
                new Vertice(4, -6, -2),// Esquina inferior derecha
                new Vertice(4, -6, -2), // Esquina superior derecha
                new Vertice(-4, -6, -2),
                new Vertice(-4, -6, 2),
                new Vertice(-4, -6, -2),// Esquina superior izquierda
            };

            pantalla.LoadVertices(v1);
            Cuerpo.LoadVertices(v2);
            Base.LoadVertices(v3);
            plataforma.LoadVertices(v4);
            carasTv.Add(pantalla);
            carasTv.Add(Cuerpo);
            carasTv.Add(Base);
            carasTv.Add(plataforma);
            
            return carasTv;
        }
        public static List<Cara> getFloreroVertices()
        {
            List<Cara> carasFlorero = new List<Cara>();

            Cara Florero = new Cara();
            Vertice[] v1 =
            {
                //base
                new Vertice(-0.5f, 0f, 0f),
                new Vertice(-0.25f, 0f, -0.5f),

                new Vertice(-0.5f, 0f, 0f),
                new Vertice(-0.25f, 0f, 0.5f),

                new Vertice(-0.25f, 0f, 0.5f),
                new Vertice(0.25f, 0f, 0.5f),

                new Vertice(0.25f, 0f, 0.5f),
                new Vertice(0.5f, 0f, 0f),

                new Vertice(0.5f, 0f, 0f),
                new Vertice(0.25f, 0f, -0.5f),

                new Vertice(0.25f, 0f, -0.5f),
                new Vertice(-0.25f, 0f, -0.5f),

                //lados
                new Vertice(-0.25f, 0f, -0.5f),
                new Vertice(-0.5f, 2f, -1f),

                new Vertice(-0.5f, 0f, 0f),
                new Vertice(-1f, 2f, 0f),

                new Vertice(-0.25f, 0f, 0.5f),
                new Vertice(-0.5f, 2f, 1f),

                new Vertice(0.25f, 0f, 0.5f),
                new Vertice(0.5f, 2f, 1f),

                new Vertice(0.5f, 0f, 0f),
                new Vertice(1f, 2f, 0f),

                new Vertice(0.25f, 0f, -0.5f),
                new Vertice(0.5f, 2f, -1f),

                //superior
                new Vertice(-1f, 2f, 0f),
                new Vertice(-0.5f, 2f, -1f),

                new Vertice(-0.5f, 2f, -1f),
                new Vertice(0.5f, 2f, -1f),

                new Vertice(0.5f, 2f, -1f),
                new Vertice(1f, 2f, 0f),

                new Vertice(1f, 2f, 0f),
                new Vertice(0.5f, 2f, 1f),

                new Vertice(0.5f, 2f, 1f),
                new Vertice(-0.5f, 2f, 1f),

                new Vertice(-1f, 2f, 0f),
                new Vertice(-0.5f, 2f, 1f),
            };
            Cara tierra= new Cara();
            Vertice[] v2 =
            {
                new Vertice(-0.75f, 2f, 0f),    // A
                new Vertice(-0.375f, 2f, -0.866f),  // B

                new Vertice(-0.375f, 2f, -0.866f),  // B
                new Vertice(0.375f, 2f, -0.866f),   // C

                new Vertice(0.375f, 2f, -0.866f),   // C
                new Vertice(0.75f, 2f, 0f),    // D
                new Vertice(0.375f, 2f, 0.866f),    // E

                new Vertice(0.75f, 2f, 0f),    // D
                new Vertice(0.375f, 2f, 0.866f),    // E

                new Vertice(-0.375f, 2f, 0.866f),   // F

                new Vertice(-0.375f, 2f, 0.866f),   // F
                new Vertice(-0.75f, 2f, 0f),    // A
            };
            Cara flor = new Cara();
            Vertice[] v3 =
            {
                //Hoja1
                new Vertice(0.5f, 2f, 0f),    // A
                new Vertice(0.2f, 2f, -0.5f),  // B
                new Vertice(0.5f, 2f, 0f),    // A
                new Vertice(0.2f, 2f, 0.5f),  // B

                new Vertice(0.5f, 2f, 0f),    // A
                new Vertice(1f, 4f, 0f),    // A

                new Vertice(0.2f, 2f, -0.5f),  // B
                new Vertice(0.5f, 3f, -0.7f),  // B

                new Vertice(0.5f, 3f, -0.7f),  // B
                new Vertice(1f, 4f, 0f),    // A

                new Vertice(0.2f, 2f, 0.5f),  // B
                new Vertice(0.5f, 3f, 0.7f),  // B

                new Vertice(0.5f, 3f, 0.7f),  // B
                new Vertice(1f, 4f, 0f),    // A

                //Hoja2
                new Vertice(-0.5f, 2f, 0f),    // A
                new Vertice(-0.2f, 2f, -0.5f),  // B
                new Vertice(-0.5f, 2f, 0f),    // A
                new Vertice(-0.2f, 2f, 0.5f),  // B

                new Vertice(-0.5f, 2f, 0f),    // A
                new Vertice(-1f, 4f, 0f),    // A

                new Vertice(-0.2f, 2f, -0.5f),  // B
                new Vertice(-0.5f, 3f, -0.7f),  // B

                new Vertice(-0.5f, 3f, -0.7f),  // B
                new Vertice(-1f, 4f, 0f),    // A

                new Vertice(-0.2f, 2f, 0.5f),  // B
                new Vertice(-0.5f, 3f, 0.7f),  // B

                new Vertice(-0.5f, 3f, 0.7f),  // B
                new Vertice(-1f, 4f, 0f),    // A

                //flor
                new Vertice(-0.3f, 5f, 0f),    // A
                new Vertice(-0.1f, 5f, -0.2f),  // B

                new Vertice(-0.1f, 5f, -0.2f),  // B
                new Vertice(0.1f, 5f, -0.2f),   // C

                new Vertice(0.1f, 5f, -0.2f),   // C
                new Vertice(0.3f, 5f, 0f),    // D
                new Vertice(0.1f, 5f, 0.2f),    // E

                new Vertice(0.3f, 5f, 0f),    // D
                new Vertice(0.1f, 5f, 0.2f),    // E

                new Vertice(-0.1f, 5f, 0.2f),   // F

                new Vertice(-0.1f, 5f, 0.2f),   // F
                new Vertice(-0.3f, 5f, 0f),    // A

                //flor petalos
                new Vertice(-0.75f, 5f, 0f),    // A
                new Vertice(-0.375f, 5f, -0.866f),  // B

                new Vertice(-0.375f, 5f, -0.866f),  // B
                new Vertice(0.375f, 5f, -0.866f),   // C

                new Vertice(0.375f, 5f, -0.866f),   // C
                new Vertice(0.75f, 5f, 0f),    // D
                new Vertice(0.375f, 5f, 0.866f),    // E

                new Vertice(0.75f, 5f, 0f),    // D
                new Vertice(0.375f, 5f, 0.866f),    // E

                new Vertice(-0.375f, 5f, 0.866f),   // F

                new Vertice(-0.375f, 5f, 0.866f),   // F
                new Vertice(-0.75f, 5f, 0f),    // A

                //Tallo
                new Vertice(-0.15f, 2f, 0f),    // A
                new Vertice(-0.05f, 2f, -0.1f),  // B

                new Vertice(-0.05f, 2f, -0.1f),  // B
                new Vertice(0.05f, 2f, -0.1f),   // C

                new Vertice(0.05f, 2f, -0.1f),   // C
                new Vertice(0.15f, 2f, 0f),    // D
                new Vertice(0.05f, 2f, 0.1f),    // E

                new Vertice(0.15f, 2f, 0f),    // D
                new Vertice(0.05f, 2f, 0.1f),    // E

                new Vertice(-0.05f, 2f, 0.1f),   // F

                new Vertice(-0.05f, 2f, 0.1f),   // F
                new Vertice(-0.15f, 2f, 0f),    // A

                new Vertice(-0.15f, 2f, 0f),    // A

                new Vertice(-0.15f, 5f, 0f),    // A'
                new Vertice(-0.05f, 2f, -0.1f),  // B
                new Vertice(-0.05f, 5f, -0.1f),  // B'
                new Vertice(0.05f, 2f, -0.1f),   // C
                new Vertice(0.05f, 5f, -0.1f),   // C'
                new Vertice(0.15f, 2f, 0f),      // D
                new Vertice(0.15f, 5f, 0f),      // D'
                new Vertice(0.05f, 2f, 0.1f),    // E
                new Vertice(0.05f, 5f, 0.1f),    // E'
                new Vertice(-0.05f, 2f, 0.1f),   // F
                new Vertice(-0.05f, 5f, 0.1f),   // F'

                new Vertice(-0.15f, 5f, 0f),    // A
                new Vertice(-0.05f, 5f, -0.1f),  // B

                new Vertice(-0.05f, 5f, -0.1f),  // B
                new Vertice(0.05f, 5f, -0.1f),   // C

                new Vertice(0.05f, 5f, -0.1f),   // C
                new Vertice(0.15f, 5f, 0f),    // D
                new Vertice(0.05f, 5f, 0.1f),    // E

                new Vertice(0.15f, 5f, 0f),    // D
                new Vertice(0.05f, 5f, 0.1f),    // E

                new Vertice(-0.05f, 5f, 0.1f),   // F

                new Vertice(-0.05f, 5f, 0.1f),   // F
                new Vertice(-0.15f, 5f, 0f),    // A
            };
            tierra.LoadVertices(v2);
            Florero.LoadVertices(v1);
            flor.LoadVertices(v3);

            carasFlorero.Add(tierra);
            carasFlorero.Add(Florero);
            carasFlorero.Add(flor);

            return carasFlorero;
        }

        public static List<Cara> getParlanteVertices()
        {
            List<Cara> carasParlante = new List<Cara>();

            Cara frente = new Cara();
            Vertice[] v1 =
            {
                new Vertice(0.0f,0.0f,0.0f),
                new Vertice(0.0f,7.0f,0.0f),
                new Vertice(0.0f,0.0f,0.0f),
                new Vertice(3.0f,0.0f,0.0f),
                new Vertice(3.0f,0.0f,0.0f),
                new Vertice(3.0f,7.0f,0.0f),
                new Vertice(3.0f,7.0f,0.0f),
                new Vertice(0.0f,7.0f,0.0f),

                new Vertice(0.3f, 0.3f, 0.0f),
                new Vertice(0.3f, 6.7f, 0.0f),
                new Vertice(0.3f, 0.3f, 0.0f),
                new Vertice(2.7f, 0.3f, 0.0f),
                new Vertice(2.7f, 0.3f, 0.0f),
                new Vertice(2.7f, 6.7f, 0.0f),
                new Vertice(2.7f, 6.7f, 0.0f),
                new Vertice(0.3f, 6.7f, 0.0f),

                //Bocinas
                new Vertice(0.7f, 4.8f, 0.0f),    // A
                new Vertice(1.5f, 4.1f, 0.0f),    // B
                new Vertice(1.5f, 4.1f, 0.0f),    // B
                new Vertice(2.3f, 4.8f, 0.0f),    // C
                new Vertice(2.3f, 4.8f, 0.0f),    // C
                new Vertice(2.3f, 5.8f, 0.0f),    // D
                new Vertice(2.3f, 5.8f, 0.0f),    // D
                new Vertice(1.5f, 6.5f, 0.0f),    // E
                new Vertice(1.5f, 6.5f, 0.0f),    // E
                new Vertice(0.7f, 5.8f, 0.0f),    // F
                new Vertice(0.7f, 4.8f, 0.0f),    // A
                new Vertice(0.7f, 5.8f, 0.0f),     // F

                new Vertice(1.2f, 5.2f, -0.2f),    // A
                new Vertice(1.5f, 4.9f, -0.2f),    // B
                new Vertice(1.5f, 4.9f, -0.2f),    // B
                new Vertice(1.8f, 5.2f, -0.2f),    // C
                new Vertice(1.8f, 5.2f, -0.2f),    // C
                new Vertice(1.8f, 5.5f, -0.2f),    // D
                new Vertice(1.8f, 5.5f, -0.2f),    // D
                new Vertice(1.5f, 5.8f, -0.2f),    // E
                new Vertice(1.5f, 5.8f, -0.2f),    // E
                new Vertice(1.2f, 5.5f, -0.2f),    // F
                new Vertice(1.2f, 5.2f, -0.2f),    // A
                new Vertice(1.2f, 5.5f, -0.2f),     // F

                // Primer conjunto
                new Vertice(0.7f, 1.8f, 0.0f),    // A
                new Vertice(1.5f, 1.1f, 0.0f),    // B
                new Vertice(1.5f, 1.1f, 0.0f),    // B
                new Vertice(2.3f, 1.8f, 0.0f),    // C
                new Vertice(2.3f, 1.8f, 0.0f),    // C
                new Vertice(2.3f, 2.8f, 0.0f),    // D
                new Vertice(2.3f, 2.8f, 0.0f),    // D
                new Vertice(1.5f, 3.5f, 0.0f),    // E
                new Vertice(1.5f, 3.5f, 0.0f),    // E
                new Vertice(0.7f, 2.8f, 0.0f),    // F
                new Vertice(0.7f, 1.8f, 0.0f),    // A
                new Vertice(0.7f, 2.8f, 0.0f),     // F

                // Segundo conjunto
                new Vertice(1.2f, 2.2f, -0.2f),    // A
                new Vertice(1.5f, 1.9f, -0.2f),    // B
                new Vertice(1.5f, 1.9f, -0.2f),    // B
                new Vertice(1.8f, 2.2f, -0.2f),    // C
                new Vertice(1.8f, 2.2f, -0.2f),    // C
                new Vertice(1.8f, 2.5f, -0.2f),    // D
                new Vertice(1.8f, 2.5f, -0.2f),    // D
                new Vertice(1.5f, 2.8f, -0.2f),    // E
                new Vertice(1.5f, 2.8f, -0.2f),    // E
                new Vertice(1.2f, 2.5f, -0.2f),    // F
                new Vertice(1.2f, 2.2f, -0.2f),    // A
                new Vertice(1.2f, 2.5f, -0.2f)     // F

            };
            Cara cuerpo = new Cara();
            Vertice[] v2 =
            {
                new Vertice(0.0f, 0.0f, -2.0f),
                new Vertice(0.0f,0.0f,0.0f),
                new Vertice(0.0f, 7.0f, -2.0f),
                new Vertice(0.0f,7.0f,0.0f),
                new Vertice(0.0f, 0.0f, -2.0f),
                new Vertice(0.0f,0.0f,0.0f),
                new Vertice(3.0f, 0.0f, -2.0f),
                new Vertice(3.0f,0.0f,0.0f),
                new Vertice(3.0f, 0.0f, -2.0f),
                new Vertice(3.0f,0.0f,0.0f),
                new Vertice(3.0f, 7.0f, -2.0f),
                new Vertice(3.0f,7.0f,0.0f),
                new Vertice(3.0f, 7.0f, -2.0f),
                new Vertice(3.0f,7.0f,0.0f),
                new Vertice(0.0f, 7.0f, -2.0f),
                new Vertice(0.0f,7.0f,0.0f),
                new Vertice(0.0f, 0.0f, -2.0f),
                new Vertice(0.0f, 7.0f, -2.0f),
                new Vertice(0.0f, 0.0f, -2.0f),
                new Vertice(3.0f, 0.0f, -2.0f),
                new Vertice(3.0f, 0.0f, -2.0f),
                new Vertice(3.0f, 7.0f, -2.0f),
                new Vertice(3.0f, 7.0f, -2.0f),
                new Vertice(0.0f, 7.0f, -2.0f)
            };

            frente.LoadVertices(v1);
            cuerpo.LoadVertices(v2);
            carasParlante.Add(frente);
            carasParlante.Add(cuerpo);

            return carasParlante;
        }
    }
}
