namespace TestWork
{
    struct Rotated
    {
        public Rotated(float angle, float x, float y, float z)
        {
            _angle = angle;
            _x = x;
            _y = y;
            _z = z;
        }

        private float _angle;
        public float Angle { get { return _angle; } }

        private float _x;
        public float X { get { return _x; } }

        private float _y;
        public float Y { get { return _y; } }

        private float _z;
        public float Z { get { return _z; } }

        public static Rotated GetRotated(float angle, float x, float y, float z)
        {
            return new Rotated(angle, x, y, z);
        }
    }
}
