namespace Task_2._2.Classes
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            var matrix1 = new DiagonalMatrix(1, 2, 3);
            var matrix2 = new DiagonalMatrix(4, 5, 6);

            Console.WriteLine($"Matrix1 Size: {matrix1.Size}");
            Console.WriteLine($"Matrix2 Size: {matrix2.Size}");

            Console.WriteLine("Matrix1:");
            Console.WriteLine(matrix1.ToString());
            Console.WriteLine("Matrix2:");
            Console.WriteLine(matrix2.ToString());

            Console.WriteLine($"Element at (0, 0) in Matrix1: {matrix1[0, 0]}");
            Console.WriteLine($"Element at (1, 2) in Matrix1: {matrix1[1, 2]}");

            Console.WriteLine($"Track of Matrix1: {matrix1.Track()}");

            Console.WriteLine($"Are Matrix1 and Matrix2 equal? {matrix1.Equals(matrix2)}");

            var matrix3 = matrix1.Add(matrix2);
            Console.WriteLine("Matrix3 (Matrix1 + Matrix2):");
            Console.WriteLine(matrix3.ToString());
        }
    }
}
