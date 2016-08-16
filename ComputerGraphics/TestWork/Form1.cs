using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace TestWork
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            openGlControl.InitializeContexts();
        }

        private void InitGl()
        {
            // инициализация Glut 
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

            // очистка окна 
            Gl.glClearColor(255, 255, 255, 1);

            // установка порта вывода в соответствии с размерами элемента openGlControl 
            Gl.glViewport(0, 0, openGlControl.Width, openGlControl.Height);

            // настройка проекции 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)openGlControl.Width / (float)openGlControl.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            // настройка параметров OpenGL для визуализации 
            //Gl.glEnable(Gl.GL_DEPTH_TEST);
            //Gl.glEnable(Gl.GL_LIGHTING);
            //Gl.glEnable(Gl.GL_LIGHT0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitGl();

            RenderTimer.Start();
        }

        private int i = 0;

        private void PaintFront()
        {
            Gl.glBegin(Gl.GL_LINE_LOOP);

            Gl.glVertex3d(0, 0, 0);
            Gl.glVertex3d(0, 2, 0);
            Gl.glVertex3d(2, 2, 0);
            Gl.glVertex3d(2, 0, 0);

            Gl.glEnd();
        }

        private void PaintBack()
        {
            Gl.glBegin(Gl.GL_LINE_LOOP);

            Gl.glVertex3d(0, 0, 2);
            Gl.glVertex3d(0, 2, 2);
            Gl.glVertex3d(2, 2, 2);
            Gl.glVertex3d(2, 0, 2);

            Gl.glEnd();
        }

        private void PaintTop()
        {
            Gl.glBegin(Gl.GL_LINE_LOOP);

            Gl.glVertex3d(0, 2, 0);
            Gl.glVertex3d(0, 2, 2);
            Gl.glVertex3d(2, 2, 2);
            Gl.glVertex3d(2, 2, 0);

            Gl.glEnd();
        }

        private void PaintBottom()
        {
            Gl.glBegin(Gl.GL_LINE_LOOP);

            Gl.glVertex3d(0, 0, 0);
            Gl.glVertex3d(0, 0, 2);
            Gl.glVertex3d(2, 0, 2);
            Gl.glVertex3d(2, 0, 0);

            Gl.glEnd();
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

                Gl.glTexCoord2d(tx, 1);
                Gl.glVertex3d(x + x2, y + height, z + z2);

                // next position
                var x3 = x2;
                x2 = c * x2 - s * z2;
                z2 = s * x3 + c * z2;
            }
            Gl.glEnd();
        }

        private void Render(Color3F color, Rotated rotated, Translated translated, Action renderingAction)
        {
            Gl.glLoadIdentity();
            Gl.glColor3f(color.Red, color.Green, color.Blue);
            Gl.glPushMatrix();
            Gl.glTranslated(translated.X,translated.Y, translated.Z);
            Gl.glRotated(rotated.Angle, rotated.X, rotated.Y, rotated.Z);

            renderingAction.Invoke();

            Gl.glPopMatrix();
            Gl.glFlush();
        }

        private void RenderTimer_Tick(object sender, EventArgs e)
        {
            i += 15;
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Render(Color3F.GetColor3F(0, 1.0f, -6), Rotated.GetRotated(i, 1, 1, 1), Translated.GetTranslated(0, -1, -6),
                () =>
                {
                    PaintFront();
                    PaintTop();
                    PaintBottom();
                });

            Render(Color3F.GetColor3F(0, 0, 1f), Rotated.GetRotated(120, 0, 1, 1), Translated.GetTranslated(0, -1, -6),
            () =>
            {
                DrawCylinder(0.3, 20, 0, 0, 0, 2);
            });


            Render(Color3F.GetColor3F(0, 1.0f, -6), Rotated.GetRotated(i, 1, 1, 1), Translated.GetTranslated(0, -1, -6), PaintBack);
            //Gl.glLoadIdentity();

            //Gl.glColor3f(0, 0, 1);

            //Gl.glPushMatrix();
            //Gl.glTranslated(0, -1, -6);
            //// Gl.glRotated(120, 0, 1, 1);

            ////Gl.glBegin(Gl.GL_LINE_STRIP);

            ////DrawCylinder(0.3, 20, 0, 0, -8, 2);

            //// Gl.glEnd();

            //Gl.glPopMatrix();
            //Gl.glFlush();

            //


            //Gl.glLoadIdentity();
            //Gl.glColor3f(0, 1.0f, 0);
            //Gl.glPushMatrix();
            //Gl.glTranslated(0, -1, -6);
            //Gl.glRotated(i, 1, 1, 1);

            //PaintFront();
            //PaintBack();
            //PaintTop();
            //PaintBottom();

            //Gl.glPopMatrix();




            //Gl.glFlush();




            openGlControl.Invalidate();

        }

    }
}

public struct Color3F
{
    public Color3F(float red, float green, float blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    public float Red { get; private set; }
    public float Green { get; private set; }
    public float Blue { get; private set; }

    public static Color3F GetColor3F(float red, float green, float blue)
    {
        return new Color3F(red, green, blue);
    }
}

public struct Rotated
{
    public Rotated(float angle, float x, float y, float z)
    {
        Angle = angle;
        X = x;
        Y = y;
        Z = z;
    }
    public float Angle { get; private set; }

    public float X { get; private set; }
    public float Y { get; private set; }
    public float Z { get; private set; }

    public static Rotated GetRotated(float angle, float x, float y, float z)
    {
        return new Rotated(angle,x, y, z);
    }
}

public struct Translated
{
    public Translated(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public float X { get; private set; }
    public float Y { get; private set; }
    public float Z { get; private set; }

    public static Translated GetTranslated(float x, float y, float z)
    {
        return new Translated(x, y, z);
    }

}