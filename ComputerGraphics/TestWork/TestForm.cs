using System;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace TestWork
{
    public partial class TestForm : Form
    {
        private int _angle = 0;
        private Random _random;
        public TestForm()
        {
            InitializeComponent();
            openGlControl.InitializeContexts();
        }

        private void InitGl()
        {
            // ініціалізація Glut 
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

            // очистка вікна 
            Gl.glClearColor(255, 255, 255, 1);

            // установка порта виводу в залежності від розмірів openGlControl 
            Gl.glViewport(0, 0, openGlControl.Width, openGlControl.Height);

            // налаштування проекции 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)openGlControl.Width / (float)openGlControl.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            // налаштування параметрів OpenGL для візуалізації 
            Gl.glEnable(Gl.GL_DEPTH_TEST);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _random = new Random();
            InitGl();

            RenderTimer.Start();
        }



        private void PaintFront(int mode)
        {
            Gl.glBegin(mode);

            Gl.glVertex3d(0, 0, 0);
            Gl.glVertex3d(0, 2, 0);
            Gl.glVertex3d(2, 2, 0);
            Gl.glVertex3d(2, 0, 0);

            Gl.glEnd();
        }

        private void PaintBack(int mode)
        {
            Gl.glBegin(mode);

            Gl.glVertex3d(0, 0, 2);
            Gl.glVertex3d(0, 2, 2);
            Gl.glVertex3d(2, 2, 2);
            Gl.glVertex3d(2, 0, 2);

            Gl.glEnd();
        }

        private void PaintTop(int mode)
        {
            Gl.glBegin(mode);

            Gl.glVertex3d(0, 2, 0);
            Gl.glVertex3d(0, 2, 2);
            Gl.glVertex3d(2, 2, 2);
            Gl.glVertex3d(2, 2, 0);

            Gl.glEnd();
        }

        private void PaintBottom(int mode)
        {
            Gl.glBegin(mode);

            Gl.glVertex3d(0, 0, 0);
            Gl.glVertex3d(0, 0, 2);
            Gl.glVertex3d(2, 0, 2);
            Gl.glVertex3d(2, 0, 0);

            Gl.glEnd();
        }

        private void PaintRight(int mode)
        {
            Gl.glBegin(mode);

            Gl.glVertex3d(2, 2, 0);
            Gl.glVertex3d(2, 2, 2);
            Gl.glVertex3d(2, 0, 2);
            Gl.glVertex3d(2, 0, 0);

            Gl.glEnd();
        }

        private void PaintLeft(int mode)
        {
            Gl.glBegin(mode);

            Gl.glVertex3d(0, 2, 0);
            Gl.glVertex3d(0, 2, 2);
            Gl.glVertex3d(0, 0, 2);
            Gl.glVertex3d(0, 0, 0);

            Gl.glEnd();
        }

        private void Render(Color3F color, Rotated rotated, Translated translated, Action renderingAction)
        {
            if (renderingAction == null)
                throw new ArgumentNullException("renderingAction");

            Gl.glLoadIdentity();
            Gl.glColor3f(color.Red, color.Green, color.Blue);
            Gl.glPushMatrix();
            Gl.glTranslated(translated.X, translated.Y, translated.Z);
            Gl.glRotated(rotated.Angle, rotated.X, rotated.Y, rotated.Z);

            renderingAction.Invoke();

            Gl.glPopMatrix();
            Gl.glFlush();
        }

        private void DrawCylinder(double radius, double sides, float x, float y, float z, int height)
        {

            // draws a cylinder 'height' high on the y axis at x,y,z position
            var theta = 2 * Math.PI / sides;

            var c = Math.Cos(theta);
            var s = Math.Sin(theta);
            // coordinates on top of the circle, on xz plane
            double x2 = radius;
            double z2 = 0f;
            // make the strip
            Gl.glBegin(Gl.GL_TRIANGLE_STRIP);

            for (var i = 0; i <= sides; i++)
            {
                // texture coord
                var tx = i / sides;
                // normal
                var nf = 1 / Math.Sqrt(x2 * x2 + z2 * z2);
                var xn = x2 * nf;
                var zn = z2 * nf;
                Gl.glNormal3d(xn, 0, zn);
                Gl.glTexCoord2d(tx, 0);

                Gl.glVertex3d(x + x2, y, z + z2);
                Gl.glNormal3d(xn, 0, zn);

                Gl.glColor3d(_random.NextDouble(), _random.NextDouble(), _random.NextDouble());
                Gl.glTexCoord2d(tx, 1);
                Gl.glVertex3d(x + x2, y + height, z + z2);

                // next position
                var x3 = x2;
                x2 = c * x2 - s * z2;
                z2 = s * x3 + c * z2;
            }

            Gl.glEnd();
        }

        private void RenderTimer_Tick(object sender, EventArgs e)
        {
            _angle += 15;
            int mode = Gl.GL_LINE_LOOP;
           // int mode = Gl.GL_QUADS;
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Render(Color3F.GetColor3F(0, 1.0f, -6),
                Rotated.GetRotated(_angle, 1, 1, 1),
                Translated.GetTranslated(0, -1, -6),
                () =>
                {
                    PaintFront(mode);
                    PaintTop(mode);
                    PaintBack(mode);
                    PaintBottom(mode);
                    PaintLeft(mode);
                    PaintRight(mode);
                });

            Render(Color3F.GetColor3F(0, 0, 1f), Rotated.GetRotated(270, 0, 1, 1), Translated.GetTranslated(-0.5f, -1, -6),
                () =>
                {
                    DrawCylinder(0.3, 20, 0, 0, 0, 4);
                });

            //Render(Color3F.GetColor3F(1f, 0, 0),
            //    Rotated.GetRotated(120, 0, 1, 1),
            //    Translated.GetTranslated(0, -1.5f, -6),
            //    () => Glut.glutSolidCylinder(0.5, 4, 15, 15));


            openGlControl.Invalidate();

        }

    }
}

