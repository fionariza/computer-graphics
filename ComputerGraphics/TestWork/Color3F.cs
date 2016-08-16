namespace TestWork
{
    struct Color3F
    {
        private float _red;
        public float Red { get { return _red; } }

        private float _green;
        public float Green { get { return _green; } }

        private float _blue;
        public float Blue { get { return _blue; } }

        public Color3F(float red, float green, float blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }


        public static Color3F GetColor3F(float red, float green, float blue)
        {
            return new Color3F(red, green, blue);
        }
    }

}
