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
    class Class1
    {
        public GameWindow windows;
        private Television3D television3D;
        private float rotationAngle = 0.0f;

        public  Class1(GameWindow windowsInput)
        {
            this.windows= windowsInput;
            television3D = new Television3D(); // Instancia de Television3D

            windows.Load += windows_Load;
            windows.RenderFrame += Windows_RenderFrame;
            windows.UpdateFrame += Windows_UpdateFrame;
            windows.Closing += Windows_Closing;
            windows.KeyDown += Windows_KeyDown;
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
        private void Windows_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Cerrar la aplicación
            windows.Exit();
        }

        private void Windows_UpdateFrame(object sender, FrameEventArgs e)
        {
            
        }

        private void Windows_RenderFrame(object sender, FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Frustum(-1.0, 1.0, -1.0, 1.0, 1.0, 100.0); // Configura la proyección perspectiva
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            // Posiciona y orienta la cámara
            GL.Translate(0.0f, 0.0f, -13.0f); // Mueve la cámara hacia atrás
            GL.Rotate(-5.0f, 1.0f, 0.0f, 0.0f); // Inclina la vista hacia abajo
            GL.Rotate(40.0f + rotationAngle, 0.0f, 1.0f, 0.0f); // Rota la vista hacia un ángulo lateral

            television3D.Draw();
            windows.SwapBuffers();
        }

        void windows_Load(object sender, EventArgs e)
        {
            GL.ClearColor(Color.FromArgb(5, 5, 25));
            GL.Enable(EnableCap.DepthTest); // Habilita el test de profundidad para objetos 3D

        }
    }
}
