using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace ConsoleApp1
{
    public class Game : GameWindow
    {
        private Television3D television1, television2, television3, television4, television5;
        private float rotationAngle = 0.0f;

        public Game() : base(800, 600) // Constructor que define el tamaño de la ventana
        {
            television1 = new Television3D(0.0f, 0.0f, 0.0f); // Origen en (0, 0, 0)
            television2 = new Television3D(13.0f, 0.0f, 0.0f); // Origen en (13, 0, 5)
            television3 = new Television3D(-13.0f, 0.0f, 0.0f); // Origen en (-13, 0, 0)
            television4 = new Television3D(7.0f, 0.0f, -7.0f); // Origen en (6, 0, -7)
            television5 = new Television3D(-7.0f, 0.0f, -7.0f); // Origen en (-6, 0, -7)
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

            rotationAngle += 6.5f * (float)e.Time; // Rotación
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

            television1.Draw();
            television2.Draw();
            television3.Draw();
            television4.Draw();
            television5.Draw();

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