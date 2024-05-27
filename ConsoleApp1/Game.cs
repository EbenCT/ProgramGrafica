using OpenTK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using ConsoleApp1.Tarea3;
using Newtonsoft.Json;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System.Threading.Tasks;
using ConsoleApp1.TareaFinal;

namespace ConsoleApp1
{
    public class Game : GameWindow
    {
        private Television3D television1, television2, television3, television4, television5;
        private float rotationAngle = 0.0f;
        private float angulo = 0.0f;
        private Animacion animacion;
        private bool animacionIniciada = false;
        private bool movimientoManuel = false;

        public Game() : base(800, 600)
        {
            // Leer el archivo
            string jsonText = File.ReadAllText("C:/Users/bokyn/source/repos/ConsoleApp1/ConsoleApp1/Tarea4/escenario1.txt");
            Escenario2 = JsonConvert.DeserializeObject<Escenario>(jsonText);
            // Inicializar la animación
            animacion = new Animacion();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(Color.FromArgb(135, 206, 235));
            GL.Enable(EnableCap.DepthTest); // Profundidad
            ConfigurarAnimacion();
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            rotationAngle += 6f * (float)e.Time; // Rotación

            // Obtener el estado actual del teclado
            var keyboardState = Keyboard.GetState();

            // Detectar si se presiona la tecla "I" para iniciar la animación
            if (!animacionIniciada && keyboardState.IsKeyDown(Key.I))
            {
                ConfigurarAnimacion();
                animacion.Empezar();
                animacionIniciada = true;
            }

            // Detectar si se presiona la tecla "P" para pausar o reanudar la animación
            if (animacionIniciada && keyboardState.IsKeyDown(Key.P))
            {
                animacion.Pausar();
            }

            // Detectar si se presiona la tecla "D" para detener la animación
            if (animacionIniciada && keyboardState.IsKeyDown(Key.D))
            {
                animacion.Detener();
            }

            if (keyboardState.IsKeyDown(Key.J))
            {
                Escenario2.objetos["Pelota"].Trasladar(0.1f, 0, 0); // Mover ligeramente la pelota
                movimientoManuel = true; // Indica que se ha movido manualmente
            }
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.LoadIdentity();

            // Posiciona y orienta la cámara
            GL.Translate(0.0f, 0.0f, -15.0f); // Mueve la cámara hacia atrás

            Escenario2.Dibujar();

            SwapBuffers();
        }

        protected override void OnResize(EventArgs e)
        {
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Frustum(-1.0, 1.0, -1.0, 1.0, 1.0, 100.0); // Proyección perspectiva
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            base.OnResize(e);
        }

        private void ConfigurarAnimacion()
        {
            // Acción de caída y subida combinadas
            Action caidaYSubida = () =>
            {
                float x = -10.0f; // Posición inicial en x
                float y = 3.0f;   // Posición inicial en y
                float tiempo = 0.0f;
                float velocidadInicialY = -10.0f; // Velocidad inicial en el eje Y, mayor para una curva más pronunciada
                float aceleracionGravitacional = -20.0f; // Aceleración debida a la gravedad, mayor para una curva más pronunciada
                float velocidadSubidaY = 20.0f; // Velocidad de subida en el eje Y (aumentada para una subida más rápida)
                float velocidadX = 1.0f; // Velocidad en el eje X durante la subida

                while (tiempo <= 7.0f) // Duración total de la caída y la subida
                {
                    if (movimientoManuel) break; // Si se ha movido manualmente, salir del ciclo

                    // Caída
                    if (tiempo <= 5.0f) // Duración de la caída
                    {
                        float nuevaPosY = y + velocidadInicialY * tiempo + 0.5f * aceleracionGravitacional * tiempo * tiempo;

                        // Limitar la caída hasta el punto -6
                        if (nuevaPosY < -6)
                        {
                            nuevaPosY = -6;
                        }

                        float nuevaPosX = x + 4.0f * tiempo;

                        // Actualizar posición de la pelota
                        Escenario2.objetos["Pelota"].Trasladar(nuevaPosX - x, nuevaPosY - y, 0);
                        Escenario2.objetos["Pelota"].Rotar("z", 10f);
                    }
                    // Subida
                    else if (tiempo <= 7.0f) // Duración de la subida
                    {
                        float nuevaPosY = -6 + velocidadSubidaY * (tiempo - 5.0f);

                        // Limitar la posición Y a 0
                        if (nuevaPosY > 0)
                        {
                            nuevaPosY = 0;
                        }

                        // Limitar la posición X a -3
                        float nuevaPosX = x + velocidadX * (tiempo - 5.0f);
                        if (nuevaPosX > -3)
                        {
                            nuevaPosX = -3;
                        }

                        // Actualizar la posición de la pelota
                        Escenario2.objetos["Pelota"].Trasladar(nuevaPosX - x, nuevaPosY - y, 0);
                        Escenario2.objetos["Pelota"].Rotar("z", 10f);
                    }

                    // Incrementar el tiempo
                    tiempo += 0.05f; // Incremento de tiempo más pequeño para una trayectoria más suave
                    Thread.Sleep(50); // Pequeño retraso para simular el paso del tiempo

                    // Detener la animación cuando se mueva manualmente o termine la duración
                    if (movimientoManuel || tiempo > 7.0f)
                    {
                        break;
                    }
                }
            };

            // Añadir la acción combinada a la animación
            animacion.AñadirTransformacion(new List<object> { caidaYSubida }, 500);  // Duración total de 7 segundos
        }

    }
}
