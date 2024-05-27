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
            //Frente
            GL.Vertex3(originX - 6, originY - 5, originZ);
            GL.Vertex3(originX + 6, originY - 5, originZ);
            GL.Vertex3(originX + 6, originY + 4, originZ);
            GL.Vertex3(originX - 6, originY + 4, originZ);
            //Atras
            GL.Vertex3(originX - 6, originY - 5, originZ - 1);
            GL.Vertex3(originX + 6, originY - 5, originZ - 1);
            GL.Vertex3(originX + 6, originY + 4, originZ - 1);
            GL.Vertex3(originX - 6, originY + 4, originZ - 1);

            //Abajo
            GL.Vertex3(originX - 6, originY - 5, originZ);
            GL.Vertex3(originX + 6, originY - 5, originZ);
            GL.Vertex3(originX + 6, originY - 5, originZ - 1);
            GL.Vertex3(originX - 6, originY - 5, originZ - 1);
            //Arriba
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

            DrawFlowerVase(originX, originY+4, originZ, 0.5f, 1.0f, 60, 0.1f, 0.8f, 0.6f, 8);

            GL.End();

            // Restaura el modo de relleno
            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
        }
        private void DrawCircleOnTop(float centerX, float centerY, float centerZ, float radius, int segments)
        {
            GL.Color3(0.0f, 1.0f, 0.0f); // Color verde
            GL.Begin(PrimitiveType.Triangles);

            for (int i = 0; i < segments; i++)
            {
                double theta1 = 2 * Math.PI * i / segments;
                double theta2 = 2 * Math.PI * (i + 1) / segments;

                float x1 = centerX + (float)(radius * Math.Cos(theta1));
                float z1 = centerZ + (float)(radius * Math.Sin(theta1));
                float x2 = centerX + (float)(radius * Math.Cos(theta2));
                float z2 = centerZ + (float)(radius * Math.Sin(theta2));

                // Triángulo formado por el centro del círculo, el punto actual y el siguiente
                GL.Vertex3(centerX, centerY, centerZ);
                GL.Vertex3(x1, centerY, z1);
                GL.Vertex3(x2, centerY, z2);
            }

            GL.End();
        }
        private void DrawCylinder(float centerX, float centerY, float centerZ, float radius, float height, int segments)
        {
            // Dibujar la parte superior del cilindro (un círculo)
            DrawCircleOnTop(centerX, centerY, centerZ, radius, segments);

            // Dibujar la parte lateral del cilindro
            GL.Color3(0.0f, 1.0f, 0.0f); // Color verde
            GL.Begin(PrimitiveType.TriangleStrip);

            for (int i = 0; i <= segments; i++)
            {
                double theta = 2 * Math.PI * i / segments;
                float x = centerX + (float)(radius * Math.Cos(theta));
                float z = centerZ + (float)(radius * Math.Sin(theta));

                // Vértices para la superficie lateral del cilindro
                GL.Vertex3(x, centerY, z); // Vértice en el círculo inferior
                GL.Vertex3(x, centerY + height, z); // Vértice en el círculo superior
            }

            GL.End();

            // Dibujar la parte inferior del cilindro (un círculo)
            DrawCircleOnTop(centerX, centerY + height, centerZ, radius, segments);
        }

        private void DrawPetal(float centerX, float centerY, float centerZ)
        {
            // Dibujar un pétalo como un cono aplanado
            // Puedes ajustar las dimensiones y la orientación según lo necesites

            GL.Color3(1.0f, 0.0f, 0.0f); // Color rojo para el pétalo
            GL.Begin(PrimitiveType.Triangles);

            // Vértices del pétalo
            GL.Vertex3(centerX, centerY, centerZ); // Punto central del pétalo

            // Ajusta estos vértices para formar la forma deseada del pétalo
            GL.Vertex3(centerX + 0.2f, centerY + 0.5f, centerZ);
            GL.Vertex3(centerX - 0.2f, centerY + 0.5f, centerZ);

            GL.End();
        }

        private void DrawFlowerVase(float centerX, float centerY, float centerZ, float vaseRadius, float vaseHeight, int vaseSegments,
                                     float stemRadius, float stemHeight,
                                     float flowerCenterRadius, int petalCount)
        {
            // Dibujar el tallo
            DrawCylinder(centerX, centerY, centerZ, stemRadius, stemHeight, vaseSegments);

            // Calcular la posición del centro de la flor
            float flowerCenterX = centerX;
            float flowerCenterY = centerY + vaseHeight + flowerCenterRadius;
            float flowerCenterZ = centerZ;

            // Dibujar el centro de la flor como un círculo plano amarillo
            GL.Color3(1.0f, 1.0f, 0.0f); // Color amarillo
            GL.Begin(PrimitiveType.TriangleFan);

            GL.Vertex3(flowerCenterX, flowerCenterY, flowerCenterZ); // Centro del círculo

            // Dibujar vértices alrededor del centro para formar el círculo
            for (int i = 0; i <= vaseSegments; i++)
            {
                double theta = 2 * Math.PI * i / vaseSegments;
                float x = flowerCenterX + flowerCenterRadius * (float)Math.Cos(theta);
                float y = flowerCenterY;
                float z = flowerCenterZ + flowerCenterRadius * (float)Math.Sin(theta);
                GL.Vertex3(x, y, z);
            }

            GL.End();

            // Dibujar los pétalos
            float angleIncrement = (float)(2 * Math.PI / petalCount);
            float currentAngle = 0;

            for (int i = 0; i < petalCount; i++)
            {
                float petalX = flowerCenterX + flowerCenterRadius * (float)Math.Cos(currentAngle);
                float petalZ = flowerCenterZ + flowerCenterRadius * (float)Math.Sin(currentAngle);

                DrawPetal(petalX, flowerCenterY, petalZ); // Dibujar un pétalo en la posición calculada

                currentAngle += angleIncrement;
            }
        }

    }
}
