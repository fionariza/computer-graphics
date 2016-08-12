using System;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace ComputerGraphics
{
    public partial class Form1 : Form
    {
        private int transX;
        private int transY = 4;
        private int transZ = -6;

        public int TransX
        {
            get { return transX;}
            set
            {
                transX = value;
                transX_label.Text = "Trans X: " + value;
                Draw();
            }
        }
        public int TransY
        {
            get { return transY; }
            set
            {
                transY = value;
                transY_label.Text = "Trans Y: " + value;
                Draw();
            }
        }
        public int TransZ
        {
            get { return transZ; }
            set
            {
                transZ = value;
                transZ_label.Text = "Trans Z: " + value;
                Draw();
            }
        }

        private int persFovY;
        public int PerspectiveFovY
        {
            get { return persFovY; }
            set
            {
                persFovY = value;
                persFovY_lbl.Text = "Pers fovY: " + value;
                Draw();
            }
        }


        private float aspectRatio;
        public float PerspectiveAspectRatio
        {
            get { return aspectRatio; }
            set
            {
                aspectRatio = value;
                persAspectRatio_lbl.Text = "Pers aspect ratio: " + value;
                Draw();
            }
        }

        private float perpectiveZNear;
        public float PerpectiveZNear
        {
            get { return perpectiveZNear; }
            set
            {
                perpectiveZNear = value;
                persZNear_lbl.Text = "Pers zNear: " + value;
                Draw();
            }
        }

        private int perpectiveZFar;
        public int PerpectiveZFar
        {
            get { return perpectiveZFar; }
            set
            {
                perpectiveZFar = value;
                persZFar_lbl.Text = "Pers zFar: " + value;
                Draw();
            }
        }

        private float rotatedAngle;
        public float RotatedAngle
        {
            get { return rotatedAngle; }
            set
            {
                rotatedAngle = value;
                rotatedAngle_lbl.Text = "Rotated angle: " + value;
                Draw();
            }
        }

        private float rotatedX;
        public float RotatedX
        {
            get { return rotatedX; }
            set
            {
                rotatedX = value;
                rotatedX_lbl.Text = "Rotated X: " + value;
                Draw();
            }
        }

        private float rotatedY;
        public float RotatedY
        {
            get { return rotatedY; }
            set
            {
                rotatedY = value;
                rotatedY_lbl.Text = "Rotated Y: " + value;
                Draw();
            }
        }

        private float rotatedZ;
        public float RotatedZ
        {
            get { return rotatedZ; }
            set
            {
                rotatedZ = value;
                rotatedZ_lbl.Text = "Rotated Z: " + value;
                Draw();
            }
        }

        public Form1()
        {
            InitializeComponent();
            openGlControl.InitializeContexts();
            transX = 0;
            transY = 4;
            transZ = -6;

            persFovY = 90;
            aspectRatio = (float) openGlControl.Width/(float) openGlControl.Height;
            perpectiveZNear = 0.1f;
            perpectiveZFar = 200;

            rotatedAngle = 45;
            rotatedX = 1;
            rotatedY = 0;
            rotatedZ = 0;

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

        }

        private void Draw()
        {
            // отчитка окна 
            Gl.glClearColor(255, 255, 255, 1);

            // установка порта вывода в соответствии с размерами элемента 
            Gl.glViewport(0, 0, openGlControl.Width, openGlControl.Height);

            // настройка проекции 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            Glu.gluPerspective(PerspectiveFovY, PerspectiveAspectRatio,PerpectiveZNear, PerpectiveZFar);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            // настройка параметров OpenGL для визуализации 
            Gl.glEnable(Gl.GL_DEPTH_TEST);

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glLoadIdentity();
            Gl.glColor3f(1.0f, 0, 0);

            Gl.glPushMatrix();
            Gl.glTranslated(TransX, TransY, TransZ);
            Gl.glRotated(RotatedAngle, RotatedX, RotatedY, RotatedZ);
            
            Glut.glutWireCylinder(1, 5, 100, 100);

            Gl.glPopMatrix();
            Gl.glFlush();
            openGlControl.Invalidate();
        }


        private void translatedX_Plus_Click(object sender, EventArgs e)
        {
            ++TransX;
        }

        private void translatedY_Plus_Click(object sender, EventArgs e)
        {
            ++TransY;
        }

        private void translatedZ_Plus_Click(object sender, EventArgs e)
        {
           ++TransZ;
        }

        private void transX_Minus_Click(object sender, EventArgs e)
        {
            --TransX;
        }

        private void transY_Minus_Click(object sender, EventArgs e)
        {
            --TransY;
        }

        private void transZ_Minus_Click(object sender, EventArgs e)
        {
            --TransZ;
        }

        private void persFovY_Plus_Click(object sender, EventArgs e)
        {
            ++PerspectiveFovY;
        }

        private void persFovY_Minus_Click(object sender, EventArgs e)
        {
           --PerspectiveFovY;
        }

        private void persAspectRatio_Plus_Click(object sender, EventArgs e)
        {
            ++PerspectiveAspectRatio;
        }

        private void persAspectRatio_Minus_Click(object sender, EventArgs e)
        {
            --PerspectiveAspectRatio;
        }

        private void persZNear_Plus_Click(object sender, EventArgs e)
        {
            PerpectiveZNear += 0.1f;
        }

        private void persZNear_Minus_Click(object sender, EventArgs e)
        {
            perpectiveZNear -= 0.1f;
        }

        private void persZFar_Plus_Click(object sender, EventArgs e)
        {
            PerpectiveZFar += 200;
        }

        private void persZFar_minus_Click(object sender, EventArgs e)
        {
            PerpectiveZFar -= 200;
        }

        private void rotatedAngle_Plus_Click(object sender, EventArgs e)
        {
            RotatedAngle += 1;
        }

        private void rotatedAngle_minus_Click(object sender, EventArgs e)
        {
            RotatedAngle -= 1;
        }

        private void rotatedX_Plus_Click(object sender, EventArgs e)
        {
            RotatedX += 1;
        }

        private void rotatedX_Minus_Click(object sender, EventArgs e)
        {
            RotatedX -= 1;
        }

        private void rotatedY_Plus_Click(object sender, EventArgs e)
        {
            RotatedY += 1;
        }

        private void rotatedY_minus_Click(object sender, EventArgs e)
        {
            RotatedY -= 1;
        }

        private void rotatedZ_Plus_Click(object sender, EventArgs e)
        {
            RotatedZ += 1;
        }

        private void rotatedZ_Minus_Click(object sender, EventArgs e)
        {
            RotatedZ -= 1;
        }
    }
}
