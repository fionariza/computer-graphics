using System;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace TestWork
{
    public partial class TestForm : Form
    {
        private int _angle = 0;
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

        private void Render(Color3F color, Rotated rotated, Translated translated, Action renderingAction)
        {
            if (renderingAction == null)
                throw new ArgumentNullException("renderingAction");
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
            _angle += 15;
            int mode = Gl.GL_LINE_LOOP; 
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

                });

            Render(Color3F.GetColor3F(0, 0, 1f),
                Rotated.GetRotated(120, 0, 1, 1),
                Translated.GetTranslated(0, -1.5f, -6),
                () => Glut.glutSolidCylinder(0.5, 4, 15, 15));

            openGlControl.Invalidate();

        }

    }
}

