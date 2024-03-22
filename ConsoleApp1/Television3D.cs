using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;

namespace ConsoleApp1
{
    internal class Television3D
    {
        public void Draw()
        {
            // Dibujar las líneas de los vértices en blanco
            GL.Color3(1.0f, 1.0f, 1.0f); // Color blanco
            GL.Begin(PrimitiveType.Lines);

            // Líneas para la pantalla
            GL.Vertex3(-5.5, -3, 0);
            GL.Vertex3(5.5, -3, 0);

            GL.Vertex3(5.5, -3, 0);
            GL.Vertex3(5.5, 3.5, 0);

            GL.Vertex3(5.5, 3.5, 0);
            GL.Vertex3(-5.5, 3.5, 0);

            GL.Vertex3(-5.5, 3.5, 0);
            GL.Vertex3(-5.5, -3, 0);

            // Líneas para los parlantes
            GL.Vertex3(-5, -3.5, 0);
            GL.Vertex3(-1, -3.5, 0);

            GL.Vertex3(-1, -3.5, 0);
            GL.Vertex3(-1, -4.5, 0);

            GL.Vertex3(-1, -4.5, 0);
            GL.Vertex3(-5, -4.5, 0);

            GL.Vertex3(5, -3.5, 0);
            GL.Vertex3(1, -3.5, 0);

            GL.Vertex3(1, -3.5, 0);
            GL.Vertex3(1, -4.5, 0);

            GL.Vertex3(1, -4.5, 0);
            GL.Vertex3(5, -4.5, 0);

            // Líneas para los bordes
            GL.Vertex3(-6, -5, 0);
            GL.Vertex3(6, -5, 0);

            GL.Vertex3(6, -5, 0);
            GL.Vertex3(6, 4, 0);

            GL.Vertex3(6, 4, 0);
            GL.Vertex3(-6, 4, 0);

            GL.Vertex3(-6, 4, 0);
            GL.Vertex3(-6, -5, 0);

            GL.Vertex3(-6, -5, 0);
            GL.Vertex3(6, -5, 0);

            GL.Vertex3(-6, -5, -1);
            GL.Vertex3(6, -5, -1);

            GL.Vertex3(6, -5, -1);
            GL.Vertex3(6, 4, -1);

            GL.Vertex3(6, 4, -1);
            GL.Vertex3(-6, 4, -1);

            GL.Vertex3(-6, 4, -1);
            GL.Vertex3(-6, -5, -1);

            // Líneas para la plataforma
            GL.Vertex3(-1, -5, -0.75);
            GL.Vertex3(1, -5, -0.75);

            GL.Vertex3(1, -5, -0.75);
            GL.Vertex3(1, -6, -0.75);

            GL.Vertex3(1, -6, -0.75);
            GL.Vertex3(-1, -6, -0.75);

            GL.Vertex3(-1, -6, -0.75);
            GL.Vertex3(-1, -5, -0.75);

            GL.Vertex3(-1, -5, -0.25);
            GL.Vertex3(1, -5, -0.25);

            GL.Vertex3(1, -5, -0.25);
            GL.Vertex3(1, -6, -0.25);

            GL.Vertex3(1, -6, -0.25);
            GL.Vertex3(-1, -6, -0.25);

            GL.Vertex3(-1, -6, -0.25);
            GL.Vertex3(-1, -5, -0.25);

            GL.Vertex3(-1, -5, -0.25);
            GL.Vertex3(-1, -5, -0.75);

            GL.Vertex3(1, -5, -0.25);
            GL.Vertex3(1, -5, -0.75);

            GL.Vertex3(1, -6, -0.25);
            GL.Vertex3(1, -6, -0.75);

            GL.Vertex3(-1, -6, -0.25);
            GL.Vertex3(-1, -6, -0.75);

            // Líneas para la parte trasera
            GL.Vertex3(-4, -6, 2);
            GL.Vertex3(4, -6, 2);

            GL.Vertex3(4, -6, 2);
            GL.Vertex3(4, -6, -2);

            GL.Vertex3(4, -6, -2);
            GL.Vertex3(-4, -6, -2);

            GL.Vertex3(-4, -6, -2);
            GL.Vertex3(-4, -6, 2);

            GL.End();

            // Dibujar la televisión en 3D utilizando OpenGL
            GL.Begin(PrimitiveType.Quads);

            // Pantalla
            GL.Color3(0.0f, 0.0f, 0.0f); // Color negro
            GL.Vertex3(-5.5, -3, 0);
            GL.Vertex3(5.5, -3, 0);
            GL.Vertex3(5.5, 3.5, 0);
            GL.Vertex3(-5.5, 3.5, 0);

            //Parlantes
            GL.Color3(0.0f, 0.0f, 0.0f); // Color negro
            GL.Vertex3(-5, -3.5, 0);
            GL.Vertex3(-1, -3.5, 0);
            GL.Vertex3(-1, -4.5, 0);
            GL.Vertex3(-5, -4.5, 0);

            GL.Vertex3(5, -3.5, 0);
            GL.Vertex3(1, -3.5, 0);
            GL.Vertex3(1, -4.5, 0);
            GL.Vertex3(5, -4.5, 0);

            // Borde
            GL.Color3(0.1f, 0.1f, 0.1f); // Color gris oscuro
            GL.Vertex3(-6, -5, 0);
            GL.Vertex3(6, -5, 0);
            GL.Vertex3(6, 4, 0);
            GL.Vertex3(-6, 4, 0);

            GL.Vertex3(-6, -5, -1);
            GL.Vertex3(6, -5, -1);
            GL.Vertex3(6, 4, -1);
            GL.Vertex3(-6, 4, -1);

            GL.Vertex3(-6, -5, 0);
            GL.Vertex3(6, -5, 0);
            GL.Vertex3(6, -5, -1);
            GL.Vertex3(-6, -5, -1);

            GL.Vertex3(-6, 4, 0);
            GL.Vertex3(6, 4, 0);
            GL.Vertex3(6, 4, -1);
            GL.Vertex3(-6, 4, -1);

            GL.Vertex3(-6, -5, -1);
            GL.Vertex3(-6, 4, -1);
            GL.Vertex3(-6, 4, 0);
            GL.Vertex3(-6, -5, 0);

            GL.Vertex3(6, -5, -1);
            GL.Vertex3(6, 4, -1);
            GL.Vertex3(6, 4, 0);
            GL.Vertex3(6, -5, 0);

            // Plataforma
            GL.Vertex3(-1, -5, -0.75);
            GL.Vertex3(1, -5, -0.75);
            GL.Vertex3(1, -6, -0.75);
            GL.Vertex3(-1, -6, -0.75);

            GL.Vertex3(-1, -5, -0.25);
            GL.Vertex3(1, -5, -0.25);
            GL.Vertex3(1, -6, -0.25);
            GL.Vertex3(-1, -6, -0.25);

            GL.Vertex3(-1, -5, -0.25);
            GL.Vertex3(-1, -5, -0.75);
            GL.Vertex3(1, -5, -0.25);
            GL.Vertex3(1, -5, -0.75);

            GL.Vertex3(-1, -6, -0.25);
            GL.Vertex3(-1, -6, -0.75);
            GL.Vertex3(1, -6, -0.25);
            GL.Vertex3(1, -6, -0.75);

            GL.Vertex3(-4, -6, 2); // Esquina inferior izquierda
            GL.Vertex3(4, -6, 2); // Esquina inferior derecha
            GL.Vertex3(4, -6, -2); // Esquina superior derecha
            GL.Vertex3(-4, -6, -2); // Esquina superior izquierda

            GL.End();

            // Restaura el modo de relleno
            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
        }
    }
}
