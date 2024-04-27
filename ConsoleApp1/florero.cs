using OpenTK.Graphics.OpenGL; // Importa la clase GL desde la biblioteca OpenTK.Graphics.OpenGL
using System; // Importa el espacio de nombres System

namespace ConsoleApp1 // Define un nuevo espacio de nombres ConsoleApp1
{
    internal class FlowerPot3D // Define una clase interna llamada FlowerPot3D
    {
        private float originX, originY, originZ; // Declara variables para almacenar las coordenadas de origen del florero
        private float radius, height; // Declara variables para almacenar el radio y la altura del florero

        // Constructor de la clase FlowerPot3D que inicializa las coordenadas de origen, el radio y la altura del florero
        public FlowerPot3D(float originX, float originY, float originZ, float radius, float height)
        {
            this.originX = originX; // Asigna el valor de originX al atributo originX de la clase
            this.originY = originY; // Asigna el valor de originY al atributo originY de la clase
            this.originZ = originZ; // Asigna el valor de originZ al atributo originZ de la clase
            this.radius = radius; // Asigna el valor de radius al atributo radius de la clase
            this.height = height; // Asigna el valor de height al atributo height de la clase
        }

        // Método para dibujar el florero en 3D
        public void Draw()
        {
            GL.Begin(PrimitiveType.Quads); // Inicia el dibujo de un grupo de cuadriláteros

            // Base del florero
            GL.Color3(0.5f, 0.35f, 0.05f); // Establece el color de la base del florero como marrón
            DrawCylinder(originX, originY, originZ, radius, height); // Dibuja el cilindro que representa la base del florero

            // Tierra en el florero
            GL.Color3(0.2f, 0.8f, 0.2f); // Establece el color de la tierra en el florero como verde claro
            DrawDisk(originX, originY, originZ, radius); // Dibuja el disco que representa la tierra en el florero

            // Círculo sobre la plana
            float circleCenterX = (originX + originX + 6) / 2; // Centra el círculo en el plano horizontal
            float circleCenterY = originY + 4;
            float circleRadius = 6f; // Diámetro del círculo igual al ancho de la figura
            DrawDisk(circleCenterX, circleCenterY, originZ - 1, circleRadius);

            GL.End(); // Finaliza el dibujo de los cuadriláteros
        }

        // Método privado para dibujar un cilindro en 3D
        private void DrawCylinder(float x, float y, float z, float radius, float height)
        {
            int sides = 20; // Número de lados para la aproximación del cilindro

            // Calcula la mitad de la altura para posicionar el cilindro horizontalmente
            float halfHeight = height / 2;

            // Itera sobre los lados del cilindro
            for (int i = 0; i < sides; i++)
            {
                float angle0 = (float)(i * 2 * Math.PI / sides); // Calcula el ángulo inicial del lado actual
                float angle1 = (float)((i + 1) * 2 * Math.PI / sides); // Calcula el ángulo final del lado actual

                // Calcula las coordenadas de los puntos en el lado actual del cilindro
                float x0 = x + radius * (float)Math.Cos(angle0);
                float y0 = y + radius * (float)Math.Sin(angle0);
                float x1 = x + radius * (float)Math.Cos(angle1);
                float y1 = y + radius * (float)Math.Sin(angle1);

                // Dibuja el lado del cilindro horizontalmente
                GL.Vertex3(x0, y0, z - halfHeight); // Resta la mitad de la altura para mantener el cilindro horizontal
                GL.Vertex3(x1, y1, z - halfHeight); // Resta la mitad de la altura para mantener el cilindro horizontal
                GL.Vertex3(x1, y1, z + halfHeight); // Suma la mitad de la altura para mantener el cilindro horizontal
                GL.Vertex3(x0, y0, z + halfHeight); // Suma la mitad de la altura para mantener el cilindro horizontal
            }
        }


        // Método privado para dibujar un disco en 3D
        private void DrawDisk(float x, float y, float z, float radius)
        {
            int sides = 20; // Número de lados para la aproximación del disco

            // Itera sobre los lados del disco
            for (int i = 0; i < sides; i++)
            {
                float angle0 = (float)(i * 2 * Math.PI / sides); // Calcula el ángulo inicial del lado actual del disco
                float angle1 = (float)((i + 1) * 2 * Math.PI / sides); // Calcula el ángulo final del lado actual del disco

                // Calcula las coordenadas de los puntos en el lado actual del disco
                float x0 = x + radius * (float)Math.Cos(angle0);
                float y0 = y + radius * (float)Math.Sin(angle0);
                float x1 = x + radius * (float)Math.Cos(angle1);
                float y1 = y + radius * (float)Math.Sin(angle1);

                // Dibuja el lado del disco
                GL.Vertex3(x0, y0, z);
                GL.Vertex3(x1, y1, z);
                GL.Vertex3(x, y, z);
            }
        }
    }
}
