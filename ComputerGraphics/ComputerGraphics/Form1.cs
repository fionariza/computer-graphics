using System;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace ComputerGraphics
{
    public partial class Form1 : Form
    {
        private int transX;
        private int transY;
        private int transZ;

        public int TransX
        {
            get { return transX;}
            set
            {
                transX = value;
                transX_label.Text = "Trans X: " + value;
            }
        }
        public int TransY
        {
            get { return transY; }
            set
            {
                transY = value;
                transY_label.Text = "Trans Y: " + value;
            }
        }
        public int TransZ
        {
            get { return transZ; }
            set
            {
                transZ = value;
                transZ_label.Text = "Trans Z: " + value;
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
            }
        }


        private float radius;
        public float Radius
        {
            get { return radius; }
            set
            {
                if (value < 0.1) return;
                radius = value;
                radius_lbl.Text = "Radius: " + value;
            }
        }

        private float height;
        public float Height
        {
            get { return height; }
            set
            {
                height = value;
                height_lbl.Text = "Height: " + value;
            }
        }

        private int slices;
        public int Slices
        {
            get { return slices; }
            set
            {
                if (value < 20) return;
                slices = value;
                slices_lbl.Text = "Slices: " + value;
            }
        }

        private int stacks;
        public int Stacks
        {
            get { return stacks; }
            set
            {
                if (value < 20) return;
                stacks = value;
                stacks_lbl.Text = "Stacks: " + value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            openGlControl.InitializeContexts();
            TransX = 0;
            TransY = 4;
            TransZ = -6;

            PerspectiveFovY = 90;
            PerspectiveAspectRatio = (float) openGlControl.Width/(float) openGlControl.Height;
            PerpectiveZNear = 0.1f;
            PerpectiveZFar = 200;

            RotatedAngle = 90;
            RotatedX = 1;
            RotatedY = 0;
            RotatedZ = 0;

            Radius = 1;
            Height = 1;
            Slices = 100;
            Stacks = 100;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

            Draw();
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
            
            Glut.glutWireCylinder(Radius, Height, Slices, Stacks);
            Glut.glutWireCube(Height);

            Gl.glPopMatrix();
            Gl.glFlush();
            openGlControl.Invalidate();
        }


        private void translatedX_Plus_Click(object sender, EventArgs e)
        {
            ++TransX;
            Draw();
        }

        private void translatedY_Plus_Click(object sender, EventArgs e)
        {
            ++TransY;
            Draw();
        }

        private void translatedZ_Plus_Click(object sender, EventArgs e)
        {
           ++TransZ;
            Draw();
        }

        private void transX_Minus_Click(object sender, EventArgs e)
        {
            --TransX;
            Draw();
        }

        private void transY_Minus_Click(object sender, EventArgs e)
        {
            --TransY;
            Draw();
        }

        private void transZ_Minus_Click(object sender, EventArgs e)
        {
            --TransZ;
            Draw();
        }

        private void persFovY_Plus_Click(object sender, EventArgs e)
        {
            ++PerspectiveFovY;
            Draw();
        }

        private void persFovY_Minus_Click(object sender, EventArgs e)
        {
           --PerspectiveFovY;
            Draw();
        }

        private void persAspectRatio_Plus_Click(object sender, EventArgs e)
        {
            ++PerspectiveAspectRatio;
            Draw();
        }

        private void persAspectRatio_Minus_Click(object sender, EventArgs e)
        {
            --PerspectiveAspectRatio;
            Draw();
        }

        private void persZNear_Plus_Click(object sender, EventArgs e)
        {
            PerpectiveZNear += 0.1f;
            Draw();
        }

        private void persZNear_Minus_Click(object sender, EventArgs e)
        {
            perpectiveZNear -= 0.1f;
            Draw();
        }

        private void persZFar_Plus_Click(object sender, EventArgs e)
        {
            PerpectiveZFar += 200;
            Draw();
        }

        private void persZFar_minus_Click(object sender, EventArgs e)
        {
            PerpectiveZFar -= 200;
            Draw();
        }

        private void rotatedAngle_Plus_Click(object sender, EventArgs e)
        {
            RotatedAngle += 15;
            Draw();
        }

        private void rotatedAngle_minus_Click(object sender, EventArgs e)
        {
            RotatedAngle -= 15;
            Draw();
        }

        private void rotatedX_Plus_Click(object sender, EventArgs e)
        {
            RotatedX += 1;
            Draw();
        }

        private void rotatedX_Minus_Click(object sender, EventArgs e)
        {
            RotatedX -= 1;
            Draw();
        }

        private void rotatedY_Plus_Click(object sender, EventArgs e)
        {
            RotatedY += 1;
            Draw();
        }

        private void rotatedY_minus_Click(object sender, EventArgs e)
        {
            RotatedY -= 1;
            Draw();
        }

        private void rotatedZ_Plus_Click(object sender, EventArgs e)
        {
            RotatedZ += 1;
            Draw();
        }

        private void rotatedZ_Minus_Click(object sender, EventArgs e)
        {
            RotatedZ -= 1;
            Draw();
        }

        private void radius_Plus_Click(object sender, EventArgs e)
        {
            Radius += 0.1f;
            Draw();
        }

        private void radius_Minus_Click(object sender, EventArgs e)
        {
            Radius -= 0.1f;
            Draw();
        }

        private void height_Plus_Click(object sender, EventArgs e)
        {
            Height += 1;
            Draw();
        }

        private void height_minus_Click(object sender, EventArgs e)
        {
            Height -= 1;
            Draw();
        }

        private void slices_Plus_Click(object sender, EventArgs e)
        {
            Slices += 20;
            Draw();
        }

        private void slices_Minus_Click(object sender, EventArgs e)
        {
            Slices -= 20;
            Draw();
        }

        private void stacks_Plus_Click(object sender, EventArgs e)
        {
            Stacks += 20;
            Draw();
        }

        private void stacks_Minus_Click(object sender, EventArgs e)
        {
            Stacks -= 20;
            Draw();
        }
    }
}
