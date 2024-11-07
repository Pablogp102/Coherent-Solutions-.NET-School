namespace Task_4._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = 5;  
            Rational r2 = 3;  
            Rational r3 = new Rational(2, 13);  

            double d = (double)r3;  
            Console.WriteLine($"Rational r3 as double: {d}");

            Rational sum = r1 + r2;
            Rational diff = r1 - r3;  
            Rational prod = r1 * r3;  
            Rational quot = r1 / r3;  

            Console.WriteLine($"Sum: {sum}");  
            Console.WriteLine($"Difference: {diff}");  
            Console.WriteLine($"Product: {prod}");  
            Console.WriteLine($"Quotient: {quot}");  

            
            Console.WriteLine($"r1 equals r2: {r1.Equals(r2)}");  
            Console.WriteLine($"r1 equals r3: {r1.Equals(r3)}");  

            
            Rational r4 = new Rational(3, 4);  
            Rational r5 = new Rational(5, 6);
            r4.CompareTo(r5);

            Rational r3copy = new Rational(2, 13);

            Console.WriteLine($"HashCode of r3: {r3.GetHashCode()} and HashCode of r3 copy: {r3copy.GetHashCode()}");
        }
    }
}
