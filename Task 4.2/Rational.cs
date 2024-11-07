namespace Task_4._2
{
    public sealed class Rational : IComparable<Rational>
    {
        public int N { get; private set; }
        public int M { get; private set; }
        public Rational(int n, int m)
        {
            if(m <= 0)
            {
                throw new ArgumentException("M have to be natural number greater than 0");
            }
            var reduced = Reduce(n, m);
            N = reduced.Item1; 
            M = reduced.Item2;
        }
        public static Tuple<int, int> Reduce(int n, int m) 
        { 
            int gcd =  CalculateGCD(Math.Abs(n), Math.Abs(m));

            n /= gcd;
            m /= gcd;

            return Tuple.Create(n, m);
        }
        private static int CalculateGCD(int a, int b)
        {
            while (b != 0) 
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public int CompareTo(Rational? other)
        {
            if (other == null) throw new ArgumentNullException(nameof(other));

            int left = N * other.M;
            int right = M * other.N;

            if (left > right)
            {
                Console.WriteLine($"{this} is greater than {other}");
                return 1;  
            }
            else if (left < right)
            {
                Console.WriteLine($"{this} is less than {other}");
                return -1; 
            }
            else
            {
                Console.WriteLine($"{this} is equal to {other}");
                return 0;  
            }
        }
        public override bool Equals(object? obj)
        {
            return obj is Rational rational &&
                   N == rational.N &&
                   M == rational.M;
        }
        public override int GetHashCode()
        {
            return N.GetHashCode() ^ M.GetHashCode();
        }
        public override string ToString()
        {
            return $"{N}/{M}";
        }

        public static explicit operator double(Rational r) => (double)r.N / r.M;
        
        public static implicit operator Rational(int value) => new Rational(value, 1);

        public static Rational operator +(Rational left, Rational right)
        {
            //(a / b) + (c / d) = (a * d + b * c) / (b * d)

            int n = left.N * right.M + left.M * right.N;
            int m = left.M * right.M;
            return new Rational(n, m);
        }

        public static Rational operator -(Rational left, Rational right)
        {
            //(a / b) - (c / d) = (a * d - b * c) / (b * d)

            int n = left.N * right.M - left.M * right.N;
            int m = left.M * right.M;
            return new Rational(n, m);
        }      

        public static Rational operator *(Rational left, Rational right)
        {
            //(a / b) * (c / d) = (a*c) / (b*d)

            int n = left.N * right.N;
            int m = left.M * right.M;
            return new Rational(n, m);
        }

        public static Rational operator /(Rational left, Rational right)
        {
            //(a / b) / (c / d) = (a * d) / (b * c) && c != 0
            if(right.N == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            int n = left.N * right.M;
            int m = left.M * right.N;
            return new Rational(n, m);  
        }

    }
}
