﻿using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using ConsoleApp1.Tarea3;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    public class Game : GameWindow
    {
        private Escenario Escenario1;
        private float rotationAngle = 0.0f;

        public Game() : base(800, 600) // Constructor que define el tamaño de la ventana
        {
            Escenario1=new Escenario(0.0f,0.0f,0.0f);
            Objeto tele1=new Objeto(0.0f, 0.0f, 0.0f);
            Objeto florero1 = new Objeto(0.0f, 4.0f, -0.5f);
            Objeto parlante1 = new Objeto(-11.0f, -7.0f, +0.5f);
            Objeto parlante2 = new Objeto(9.0f, -7.0f, +0.5f);
            //Partes de la tele
            Parte pantalla = new Parte();
            Parte cuerpo = new Parte();
            Parte bases = new Parte();
            Parte plataforma = new Parte();
            //Partes del florero
            Parte tierra = new Parte();
            Parte maseta = new Parte();
            Parte flor = new Parte();
            //Partes del parlante
            Parte frente = new Parte();
            Parte caja = new Parte();
            //Caras
            Cara frenteTv = new Cara();
            Cara CuerpoTv = new Cara();
            Cara BaseTV = new Cara();
            Cara plataformaTV = new Cara();
            Cara tierraF = new Cara();
            Cara macetaF = new Cara();
            Cara florF = new Cara();
            Cara bocinas = new Cara();
            Cara cuerpoP = new Cara();

            //Armar el escenario
            Escenario1.AgregarObjeto("Tele1", tele1);
            Escenario1.AgregarObjeto("Florero1", florero1);
            Escenario1.AgregarObjeto("Parlante1", parlante1);
            Escenario1.AgregarObjeto("Parlante2", parlante2);

            //Ensamblar Tele
            tele1.AgregarParte("pantalla", pantalla);
            tele1.AgregarParte("cuerpo", cuerpo);
            tele1.AgregarParte("base", bases);
            tele1.AgregarParte("plataforma", plataforma);

            //Ensamblar florero
            florero1.AgregarParte("tierra", tierra);
            florero1.AgregarParte("maseta", maseta);
            florero1.AgregarParte("flor", flor);

            //Ensamblar parlante
            parlante1.AgregarParte("bocinas", frente);
            parlante1.AgregarParte("cuerpo", caja);
            parlante2.AgregarParte("bocinas", frente);
            parlante2.AgregarParte("cuerpo", caja);

            //Ensamblar partes
            pantalla.AgregarCara("frente", frenteTv);
            cuerpo.AgregarCara("cuerpo", CuerpoTv);
            bases.AgregarCara("base", BaseTV);
            plataforma.AgregarCara("plataforma", plataformaTV);
            tierra.AgregarCara("tierra", tierraF);
            maseta.AgregarCara("maseta", macetaF);
            flor.AgregarCara("flor", florF);
            frente.AgregarCara("frente", bocinas);
            caja.AgregarCara("cuerpo", cuerpoP);
            
            //Vertices
            Vertice[] v1 = {
                new Vertice(- 5.5, - 3.0, 0.0),
                new Vertice(5.5, -3, 0),
                new Vertice(5.5, -3, 0),
                new Vertice(5.5, 3.5, 0),
                new Vertice(5.5, 3.5, 0),
                new Vertice(-5.5, 3.5, 0),
                new Vertice(- 5.5, - 3.0, 0.0),
                new Vertice(-5.5, 3.5, 0),
            };
            frenteTv.LoadVertices(v1);

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
            CuerpoTv.LoadVertices(v2);

            Vertice[] v3 = {
                new Vertice(-1, -5, -0.75),
                new Vertice(1, -5, -0.75),
                new Vertice(1, -6, -0.75),
                new Vertice(-1, -6, -0.75),

                new Vertice(-1, -5, -0.25),
                new Vertice(1, -5, -0.25),
                new Vertice(1, -6, -0.25),
                new Vertice(-1, -6, -0.25),

                new Vertice(-1, -5, -0.25),
                new Vertice(-1, -5, -0.75),
                new Vertice(1, -5, -0.25),
                new Vertice(1, -5, -0.75),

                new Vertice(-1, -6, -0.25),
                new Vertice(-1, -6, -0.75),
                new Vertice(1, -6, -0.25),
                new Vertice(1, -6, -0.75),

                new Vertice(-1, -5, -0.25),
                new Vertice(-1, -6, -0.25),
                new Vertice(1, -6, -0.25),
                new Vertice(1, -5, -0.25),
                new Vertice(-1, -5, -0.75),
                new Vertice(-1, -6, -0.75),
                new Vertice(1, -6, -0.75),
                new Vertice(1, -5, -0.75)
            };
            BaseTV.LoadVertices(v3);

            Vertice[] v4 ={
                new Vertice(-4, -6, 2), // Esquina inferior izquierda
                new Vertice(4, -6, 2),
                new Vertice(4, -6, 2), // Esquina inferior derecha
                new Vertice(4, -6, -2),// Esquina inferior derecha
                new Vertice(4, -6, -2), // Esquina superior derecha
                new Vertice(-4, -6, -2),
                new Vertice(-4, -6, 2),
                new Vertice(-4, -6, -2),// Esquina superior izquierda
            };
            plataformaTV.LoadVertices(v4);

            Vertice[] f1 =
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
            tierraF.LoadVertices(f1);

            Vertice[] f2 =
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
            macetaF.LoadVertices(f2);

            Vertice[] f3 =
            {
                //Hoja1
                new Vertice(0.5f, 2f, 0f),    // A
                new Vertice(0.2, 2f, -0.5),  // B
                new Vertice(0.5f, 2f, 0f),    // A
                new Vertice(0.2, 2f, 0.5),  // B

                new Vertice(0.5f, 2f, 0f),    // A
                new Vertice(1f, 4f, 0f),    // A

                new Vertice(0.2, 2f, -0.5),  // B
                new Vertice(0.5, 3f, -0.7),  // B

                new Vertice(0.5, 3f, -0.7),  // B
                new Vertice(1f, 4f, 0f),    // A

                new Vertice(0.2, 2f, 0.5),  // B
                new Vertice(0.5, 3f, 0.7),  // B

                new Vertice(0.5, 3f, 0.7),  // B
                new Vertice(1f, 4f, 0f),    // A

                //Hoja2
                new Vertice(-0.5f, 2f, 0f),    // A
                new Vertice(-0.2, 2f, -0.5),  // B
                new Vertice(-0.5f, 2f, 0f),    // A
                new Vertice(-0.2, 2f, 0.5),  // B

                new Vertice(-0.5f, 2f, 0f),    // A
                new Vertice(-1f, 4f, 0f),    // A

                new Vertice(-0.2, 2f, -0.5),  // B
                new Vertice(-0.5, 3f, -0.7),  // B

                new Vertice(-0.5, 3f, -0.7),  // B
                new Vertice(-1f, 4f, 0f),    // A

                new Vertice(-0.2, 2f, 0.5),  // B
                new Vertice(-0.5, 3f, 0.7),  // B

                new Vertice(-0.5, 3f, 0.7),  // B
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
            florF.LoadVertices(f3);

            Vertice[] p1 =
            {
                new Vertice(0.0,0.0,0.0),
                new Vertice(0.0,7.0,0.0),
                new Vertice(0.0,0.0,0.0),
                new Vertice(3.0,0.0,0.0),
                new Vertice(3.0,0.0,0.0),
                new Vertice(3.0,7.0,0.0),
                new Vertice(3.0,7.0,0.0),
                new Vertice(0.0,7.0,0.0),

                new Vertice(0.3, 0.3, 0.0),
                new Vertice(0.3, 6.7, 0.0),
                new Vertice(0.3, 0.3, 0.0),
                new Vertice(2.7, 0.3, 0.0),
                new Vertice(2.7, 0.3, 0.0),
                new Vertice(2.7, 6.7, 0.0),
                new Vertice(2.7, 6.7, 0.0),
                new Vertice(0.3, 6.7, 0.0),

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
            bocinas.LoadVertices(p1);

            Vertice[] p2 =
            {
                new Vertice(0.0, 0.0, -2.0),
                new Vertice(0.0,0.0,0.0),
                new Vertice(0.0, 7.0, -2.0),
                new Vertice(0.0,7.0,0.0),
                new Vertice(0.0, 0.0, -2.0),
                new Vertice(0.0,0.0,0.0),
                new Vertice(3.0, 0.0, -2.0),
                new Vertice(3.0,0.0,0.0),
                new Vertice(3.0, 0.0, -2.0),
                new Vertice(3.0,0.0,0.0),
                new Vertice(3.0, 7.0, -2.0),
                new Vertice(3.0,7.0,0.0),
                new Vertice(3.0, 7.0, -2.0),
                new Vertice(3.0,7.0,0.0),
                new Vertice(0.0, 7.0, -2.0),
                new Vertice(0.0,7.0,0.0),
                new Vertice(0.0, 0.0, -2.0),
                new Vertice(0.0, 7.0, -2.0),
                new Vertice(0.0, 0.0, -2.0),
                new Vertice(3.0, 0.0, -2.0),
                new Vertice(3.0, 0.0, -2.0),
                new Vertice(3.0, 7.0, -2.0),
                new Vertice(3.0, 7.0, -2.0),
                new Vertice(0.0, 7.0, -2.0)
            };
            cuerpoP.LoadVertices(p2);
            //Intento de serealizacion
            string output = JsonConvert.SerializeObject(Escenario1);
            Console.WriteLine(output);
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

            Escenario1.Dibujar();

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