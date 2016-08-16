namespace TestWork
{
    struct Translated
    {
        public Translated(float x, float y, float z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        private float _x;

        public float X
        {
            get { return _x; }
        }

        private float _y;

        public float Y
        {
            get { return _y; }
        }

        private float _z;

        public float Z
        {
            get { return _z; }
        }

        public static Translated GetTranslated(float x, float y, float z)
        {
            return new Translated(x, y, z);
        }
    }
}
