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
        private float originX, originY, originZ;

        public Television3D(float originX, float originY, float originZ)
        {
            this.originX = originX;
            this.originY = originY;
            this.originZ = originZ;
        }
        public void Draw()
        {
            // Dibujar las líneas de los vértices en blanco
            GL.Color3(1.0f, 1.0f, 1.0f); // Color blanco
            GL.Begin(PrimitiveType.Lines);

            // Líneas para la pantalla
            GL.Vertex3(originX - 5.5, originY - 3, originZ);
            GL.Vertex3(originX + 5.5, originY - 3, originZ);

            GL.Vertex3(originX + 5.5, originY - 3, originZ);
            GL.Vertex3(originX + 5.5, originY + 3.5, originZ);

            GL.Vertex3(originX + 5.5, originY + 3.5, originZ);
            GL.Vertex3(originX - 5.5, originY + 3.5, originZ);

            GL.Vertex3(originX - 5.5, originY + 3.5, originZ);
            GL.Vertex3(originX - 5.5, originY - 3, originZ);

            // Líneas para los parlantes
            GL.Vertex3(originX - 5, originY - 3.5, originZ);
            GL.Vertex3(originX - 1, originY - 3.5, originZ);

            GL.Vertex3(originX - 1, originY - 3.5, originZ);
            GL.Vertex3(originX - 1, originY - 4.5, originZ);

            GL.Vertex3(originX - 1, originY - 4.5, originZ);
            GL.Vertex3(originX - 5, originY - 4.5, originZ);

            GL.Vertex3(originX + 5, originY - 3.5, originZ);
            GL.Vertex3(originX + 1, originY - 3.5, originZ);

            GL.Vertex3(originX + 1, originY - 3.5, originZ);
            GL.Vertex3(originX + 1, originY - 4.5, originZ);

            GL.Vertex3(originX + 1, originY - 4.5, originZ);
            GL.Vertex3(originX + 5, originY - 4.5, originZ);

            // Líneas para los bordes
            GL.Vertex3(originX - 6, originY - 5, originZ);
            GL.Vertex3(originX + 6, originY - 5, originZ);

            GL.Vertex3(originX + 6, originY - 5, originZ);
            GL.Vertex3(originX + 6, originY + 4, originZ);

            GL.Vertex3(originX + 6, originY + 4, originZ);
            GL.Vertex3(originX - 6, originY + 4, originZ);

            GL.Vertex3(originX - 6, originY + 4, originZ);
            GL.Vertex3(originX - 6, originY - 5, originZ);

            GL.Vertex3(originX - 6, originY - 5, originZ);
            GL.Vertex3(originX + 6, originY - 5, originZ);

            GL.Vertex3(originX - 6, originY - 5, originZ - 1);
            GL.Vertex3(originX + 6, originY - 5, originZ - 1);

            GL.Vertex3(originX + 6, originY - 5, originZ - 1);
            GL.Vertex3(originX + 6, originY + 4, originZ - 1);

            GL.Vertex3(originX + 6, originY + 4, originZ - 1);
            GL.Vertex3(originX - 6, originY + 4, originZ - 1);

            GL.Vertex3(originX - 6, originY + 4, originZ - 1);
            GL.Vertex3(originX - 6, originY - 5, originZ - 1);

            // Líneas para la plataforma
            GL.Vertex3(originX - 1, originY - 5, originZ - 0.75);
            GL.Vertex3(originX + 1, originY - 5, originZ - 0.75);

            GL.Vertex3(originX + 1, originY - 5, originZ - 0.75);
            GL.Vertex3(originX + 1, originY - 6, originZ - 0.75);

            GL.Vertex3(originX + 1, originY - 6, originZ - 0.75);
            GL.Vertex3(originX - 1, originY - 6, originZ - 0.75);

            GL.Vertex3(originX - 1, originY - 6, originZ - 0.75);
            GL.Vertex3(originX - 1, originY - 5, originZ - 0.75);

            GL.Vertex3(originX - 1, originY - 5, originZ - 0.25);
            GL.Vertex3(originX + 1, originY - 5, originZ - 0.25);

            GL.Vertex3(originX + 1, originY - 5, originZ - 0.25);
            GL.Vertex3(originX + 1, originY - 6, originZ - 0.25);

            GL.Vertex3(originX + 1, originY - 6, originZ - 0.25);
            GL.Vertex3(originX - 1, originY - 6, originZ - 0.25);

            GL.Vertex3(originX - 1, originY - 6, originZ - 0.25);
            GL.Vertex3(originX - 1, originY - 5, originZ - 0.25);

            GL.Vertex3(originX - 1, originY - 5, originZ - 0.25);
            GL.Vertex3(originX - 1, originY - 5, originZ - 0.75);

            GL.Vertex3(originX + 1, originY - 5, originZ - 0.25);
            GL.Vertex3(originX + 1, originY - 5, originZ - 0.75);

            GL.Vertex3(originX + 1, originY - 6, originZ - 0.25);
            GL.Vertex3(originX + 1, originY - 6, originZ - 0.75);

            GL.Vertex3(originX - 1, originY - 6, originZ - 0.25);
            GL.Vertex3(originX - 1, originY - 6, originZ - 0.75);

            // Líneas para la parte trasera
            GL.Vertex3(originX - 4, originY - 6, originZ + 2);
            GL.Vertex3(originX + 4, originY - 6, originZ + 2);

            GL.Vertex3(originX + 4, originY - 6, originZ + 2);
            GL.Vertex3(originX + 4, originY - 6, originZ - 2);

            GL.Vertex3(originX + 4, originY - 6, originZ - 2);
            GL.Vertex3(originX - 4, originY - 6, originZ - 2);

            GL.Vertex3(originX - 4, originY - 6, originZ - 2);
            GL.Vertex3(originX - 4, originY - 6, originZ + 2);

            GL.End();

            // Dibujar la televisión en 3D utilizando OpenGL
            GL.Begin(PrimitiveType.Quads);

            // Pantalla
            GL.Color3(0.0f, 0.0f, 0.0f); // Color negro
            GL.Vertex3(originX - 5.5, originY - 3, originZ);
            GL.Vertex3(originX + 5.5, originY - 3, originZ);
            GL.Vertex3(originX + 5.5, originY + 3.5, originZ);
            GL.Vertex3(originX - 5.5, originY + 3.5, originZ);

            //Parlantes
            GL.Color3(0.0f, 0.0f, 0.0f); // Color negro
            GL.Vertex3(originX - 5, originY - 3.5, originZ);
            GL.Vertex3(originX - 1, originY - 3.5, originZ);
            GL.Vertex3(originX - 1, originY - 4.5, originZ);
            GL.Vertex3(originX - 5, originY - 4.5, originZ);

            GL.Vertex3(originX + 5, originY - 3.5, originZ);
            GL.Vertex3(originX + 1, originY - 3.5, originZ);
            GL.Vertex3(originX + 1, originY - 4.5, originZ);
            GL.Vertex3(originX + 5, originY - 4.5, originZ);

            // Borde
            GL.Color3(0.1f, 0.1f, 0.1f); // Color gris oscuro
            GL.Vertex3(originX - 6, originY - 5, originZ);
            GL.Vertex3(originX + 6, originY - 5, originZ);
            GL.Vertex3(originX + 6, originY + 4, originZ);
            GL.Vertex3(originX - 6, originY + 4, originZ);

            GL.Vertex3(originX - 6, originY - 5, originZ - 1);
            GL.Vertex3(originX + 6, originY - 5, originZ - 1);
            GL.Vertex3(originX + 6, originY + 4, originZ - 1);
            GL.Vertex3(originX - 6, originY + 4, originZ - 1);

            GL.Vertex3(originX - 6, originY - 5, originZ);
            GL.Vertex3(originX + 6, originY - 5, originZ);
            GL.Vertex3(originX + 6, originY - 5, originZ - 1);
            GL.Vertex3(originX - 6, originY - 5, originZ - 1);

            GL.Vertex3(originX - 6, originY + 4, originZ);
            GL.Vertex3(originX + 6, originY + 4, originZ);
            GL.Vertex3(originX + 6, originY + 4, originZ - 1);
            GL.Vertex3(originX - 6, originY + 4, originZ - 1);

            GL.Vertex3(originX - 6, originY - 5, originZ - 1);
            GL.Vertex3(originX - 6, originY + 4, originZ - 1);
            GL.Vertex3(originX - 6, originY + 4, originZ);
            GL.Vertex3(originX - 6, originY - 5, originZ);

            GL.Vertex3(originX + 6, originY - 5, originZ - 1);
            GL.Vertex3(originX + 6, originY + 4, originZ - 1);
            GL.Vertex3(originX + 6, originY + 4, originZ);
            GL.Vertex3(originX + 6, originY - 5, originZ);

            // Plataforma
            GL.Vertex3(originX - 1, originY - 5, originZ - 0.75);
            GL.Vertex3(originX + 1, originY - 5, originZ - 0.75);
            GL.Vertex3(originX + 1, originY - 6, originZ - 0.75);
            GL.Vertex3(originX - 1, originY - 6, originZ - 0.75);

            GL.Vertex3(originX - 1, originY - 5, originZ - 0.25);
            GL.Vertex3(originX + 1, originY - 5, originZ - 0.25);
            GL.Vertex3(originX + 1, originY - 6, originZ - 0.25);
            GL.Vertex3(originX - 1, originY - 6, originZ - 0.25);

            GL.Vertex3(originX - 1, originY - 5, originZ - 0.25);
            GL.Vertex3(originX - 1, originY - 5, originZ - 0.75);
            GL.Vertex3(originX + 1, originY - 5, originZ - 0.25);
            GL.Vertex3(originX + 1, originY - 5, originZ - 0.75);

            GL.Vertex3(originX - 1, originY - 6, originZ - 0.25);
            GL.Vertex3(originX - 1, originY - 6, originZ - 0.75);
            GL.Vertex3(originX + 1, originY - 6, originZ - 0.25);
            GL.Vertex3(originX + 1, originY - 6, originZ - 0.75);

            // Líneas para la parte trasera
            GL.Vertex3(originX - 4, originY - 6, originZ + 2);
            GL.Vertex3(originX + 4, originY - 6, originZ + 2);
            GL.Vertex3(originX + 4, originY - 6, originZ - 2);
            GL.Vertex3(originX - 4, originY - 6, originZ - 2);

            GL.End();

            // Restaura el modo de relleno
            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
        }
    }
}
