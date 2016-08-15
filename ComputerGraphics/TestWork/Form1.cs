using System;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

            // отчитка окна 
            Gl.glClearColor(255, 255, 255, 1);

            // установка порта вывода в соответствии с размерами элемента 
            Gl.glViewport(0, 0, openGlControl.Width, openGlControl.Height);

            // настройка проекции 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            Glu.gluPerspective(90, (double)openGlControl.Width / openGlControl.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            // настройка параметров OpenGL для визуализации 
            Gl.glEnable(Gl.GL_DEPTH_TEST);

            DrawLine();
        }

        private void DrawCylinder()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glLoadIdentity();
            Gl.glColor3f(1.0f, 1.0f, 0.5f);

            Gl.glPushMatrix();
            Gl.glTranslated(3, 3, -6);
            Gl.glRotated(90, 1, -1, 0);

            Glut.glutWireCylinder(0.5, 6, 100, 100);

            Gl.glPopMatrix();
            Gl.glFlush();
            openGlControl.Invalidate();
        }

        private void DrawLine()
        {
            if ((float)openGlControl.Width <= (float)openGlControl.Height)
            {
                Glu.gluOrtho2D(0.0, 30.0 * (float)openGlControl.Height / (float)openGlControl.Width, 0.0, 30.0);
            }
            else
            {
                Glu.gluOrtho2D(0.0, 30.0 * (float)openGlControl.Width / (float)openGlControl.Height, 0.0, 30.0);
            }

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(255,0,0);

            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glVertex2d(0,0);
            Gl.glVertex2d(200,200);

            Gl.glEnd();
            Gl.glFlush();

            openGlControl.Invalidate();


        }
    }
}
