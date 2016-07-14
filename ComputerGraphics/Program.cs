using System;
using System.Diagnostics;
using OpenGL;
using Tao.FreeGlut;

namespace ComputerGraphics
{
    class Program
    {
        private static int width = 1280, height = 720;
        private static ShaderProgram program;
        //элементы, которые нужно нарисовать
        private static VBO<Vector3> triangle, square;
        //цвета 
        private static VBO<Vector3> triangleColor, squareColor;
        //в каком порядке рендерить елементы
        private static VBO<int> triangleElements, squareElements;
        private static Stopwatch watch;
        private static float angle;
        static void Main(string[] args)
        {

            Glut.glutInit();
            //необходимы для того, чтобы не видеть как рисует программа
            Glut.glutInitDisplayMode(Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            Glut.glutInitWindowSize(width, height);
            Glut.glutCreateWindow("Open GL");

            Glut.glutIdleFunc(OnRenderFrame);
            Glut.glutDisplayFunc(OnDisplay);

            program = new ShaderProgram(VertexShader, FragmentShader);
            program.Use();
            //устанавливаем переменные программы, последние 2 переменные показывают как далеко предмет
            program["projection_matrix"].SetValue(Matrix4.CreatePerspectiveFieldOfView(0.45f, (float)width / height, 0.1f, 1000f));
            //где расположена камера
            program["view_matrix"].SetValue(Matrix4.LookAt(new Vector3(0, 0, 10), Vector3.Zero, Vector3.Up));

            triangle = new VBO<Vector3>(new Vector3[] { new Vector3(0, 1, 0), new Vector3(-1, -1, 0), new Vector3(1, -1, 0) });
            square = new VBO<Vector3>(new Vector3[] { new Vector3(-1, 1, 0), new Vector3(1, 1, 0), new Vector3(1, -1, 0), new Vector3(-1, -1, 0) });

            triangleElements = new VBO<int>(new int[] { 0, 1, 2 }, BufferTarget.ElementArrayBuffer);
            squareElements = new VBO<int>(new int[] { 0, 1, 2, 3 }, BufferTarget.ElementArrayBuffer);
            //red, green, blue color
            triangleColor = new VBO<Vector3>(new[] { new Vector3(1, 0, 0), new Vector3(0, 1, 0), new Vector3(0, 0, 1) });
            //blue color
            squareColor = new VBO<Vector3>(new Vector3[] { new Vector3(0.5, 0.5, 1), new Vector3(0.5, 0.5, 1), new Vector3(0.5, 0.5, 1), new Vector3(0.5, 0.5, 1) });

            watch = Stopwatch.StartNew();

            Glut.glutMainLoop();
        }

        private static void OnDisplay()
        {

        }
        private static void OnRenderFrame()
        {
            watch.Stop();
            var deltaTime = (float)watch.ElapsedTicks / Stopwatch.Frequency;
            watch.Restart();
            angle += deltaTime;

            //должны стереть предыдущую информацию
            Gl.Viewport(0, 0, width, height);
            Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);


            program.Use();
            //рисуем треугольник
            program["model_matrix"].SetValue(Matrix4.CreateRotationZ(angle) * Matrix4.CreateTranslation(new Vector3(-1.5f, 0, 0)));

            var vertexPositionIndex = (uint)Gl.GetAttribLocation(program.ProgramID, "vertexPosition");
            Gl.EnableVertexAttribArray(vertexPositionIndex);
            Gl.BindBuffer(triangle);
            Gl.VertexAttribPointer(vertexPositionIndex, triangle.Size, triangle.PointerType, true, 12, IntPtr.Zero);
            Gl.BindBufferToShaderAttribute(triangleColor, program, "vertexColor");
            Gl.BindBuffer(triangleElements);
            Gl.DrawElements(BeginMode.Triangles, triangleElements.Count, DrawElementsType.UnsignedInt, IntPtr.Zero);


            //рисуем квадрат
            program["model_matrix"].SetValue(Matrix4.CreateTranslation(new Vector3(1.5f, 0, 0) * Matrix4.CreateRotationZ(angle)));
            Gl.BindBufferToShaderAttribute(square, program, "vertexPosition");
            Gl.BindBufferToShaderAttribute(squareColor, program, "vertexColor");
            Gl.BindBuffer(squareElements);
            Gl.DrawElements(BeginMode.Quads, squareElements.Count, DrawElementsType.UnsignedInt, IntPtr.Zero);

            Glut.glutSwapBuffers();

        }

        //vertexPositon 
        //projection_matrix перспектива
        //view_matrix содержит информацию про камеру
        //model_matrix создает модель
        public static string VertexShader = @"
            in vec3 vertexPosition;
            in vec3 vertexColor;

            out vec3 color;    
            
            uniform mat4 projection_matrix;
            uniform mat4 view_matrix;
            uniform mat4 model_matrix;

void main(void)
{
    color = vertexColor;
    gl_Position = projection_matrix * view_matrix * model_matrix * vec4(vertexPosition, 1);
}
            ";


        public static string FragmentShader = @"
in vec3 color;

void main(void)
{
gl_FragColor = vec4(color,1);
}
";
    }
}
