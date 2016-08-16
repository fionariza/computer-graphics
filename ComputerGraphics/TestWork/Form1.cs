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

        private void RenderTimer_Tick(object sender, EventArgs e)
        {
            i += 15;
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glLoadIdentity();

            Gl.glColor3f(1.0f, 1.0f, 0);

            Gl.glPushMatrix();
            Gl.glTranslated(2, -1, -19);
            Gl.glRotated(120, 1, -1, 0);

            Glut.glutSolidCylinder(1, 4, 100, 100);

            Gl.glPopMatrix();


            Gl.glLoadIdentity();
            Gl.glColor3f(0, 1.0f, 0);

            Gl.glPushMatrix();
            Gl.glTranslated(0, -1, -6);
            
            Gl.glRotated(i, 1, 1, 1);

            PaintFront();
            PaintBack();
            PaintTop();
            PaintBottom();

            Gl.glPopMatrix();
            Gl.glFlush();






            Gl.glFlush();
            openGlControl.Invalidate();
        }

    }
}
