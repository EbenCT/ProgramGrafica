using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using ConsoleApp1.Tarea3;
using Newtonsoft.Json;
using System.IO;
using System.Threading;


namespace ConsoleApp1
{
    public class Game : GameWindow
    {
        private Escenario Escenario1;
        private Escenario Escenario2;
        private float rotationAngle = 0.0f;
        private float angulo = 0.0f;

        public Game() : base(800, 600) // Constructor que define el tamaño de la ventana
        {
           
            // Leer el archivo
            string jsonText = File.ReadAllText("C:/Users/bokyn/source/repos/ConsoleApp1/ConsoleApp1/Tarea4/escenario.txt");
            Escenario2= JsonConvert.DeserializeObject<Escenario>(jsonText);
        }

        private void Windows_KeyDown(object sender, OpenTK.Input.KeyboardKeyEventArgs e)
        {
            // Rotar la vista en función de las teclas de flecha presionadas
            switch (e.Key)
            {
                case OpenTK.Input.Key.Left:
                    rotationAngle -= 5.0f; // Girar hacia la izquierda
                    break;
                case OpenTK.Input.Key.Right:
                    rotationAngle += 5.0f; // Girar hacia la derecha
                    break;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(Color.FromArgb(135, 206, 235));
            GL.Enable(EnableCap.DepthTest); // Profundidad
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            rotationAngle += 6f * (float)e.Time; // Rotación
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Frustum(-1.0, 1.0, -1.0, 1.0, 1.0, 100.0); // Proyección perspectiva
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            // Posiciona y orienta la cámara
            GL.Translate(0.0f, 0.0f, -15.0f); // Mueve la cámara hacia atrás
            GL.Rotate(20.0f, 1.0f, 0.0f, 0.0f); // Inclina la vista hacia abajo
            GL.Rotate(40.0f + rotationAngle, 0.0f, 1.0f, 0.0f); // Rota la vista hacia un ángulo lateral

            //Escenario1.Dibujar();
            Escenario2.Dibujar();
            Escenario2.Rotar("z", angulo);
            //Escenario2.Escalar(0.5f);
            //Escenario2.Trasladar(angulo, 0, 0);

            angulo += 1f;
            if (angulo > 360f) angulo = 0.0f;
            SwapBuffers();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // Ajustar la vista en caso de que se redimensione la ventana
            GL.Viewport(0, 0, Width, Height);
        }
    }
}