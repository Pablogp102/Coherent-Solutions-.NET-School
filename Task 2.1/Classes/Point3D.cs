namespace Task_2._1.Classes
{
    public class Point3D
    {
        private int[] coordinates = new int[3];
        private double mass;

        public int X
        {
            get { return coordinates[0]; }
            set { coordinates[0] = value; }
        }

        public int Y
        {
            get { return coordinates[1]; }
            set { coordinates[1] = value; }
        }
        public int Z
        {
            get { return coordinates[2]; }
            set { coordinates[2] = value; }
        }

        public double Mass
        {
            get { return mass; }
            set { mass = value < 0 ? 0 : value; }
        }

        public Point3D(int x , int y, int z, double mass)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.Mass = mass;
        }

        public bool IsZero()
        {
            return X == 0 && Y == 0 && Z == 0;
        }

        public double DistanceToAnotherPoint(Point3D anotherPoint)
        {
            // PQ = d = √ [(x2 – x1)2 + (y2 – y1)2 + (z2 – z1)2].  mathematical formula
            int distanceX = X - anotherPoint.X;
            int distanceY = Y - anotherPoint.Y;
            int distanceZ = Z - anotherPoint.Z;


            return Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2) + Math.Pow(distanceZ, 2));
        }
    }
}
