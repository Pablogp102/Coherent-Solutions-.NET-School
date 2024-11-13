using System;

using Task_4._1.Matrix;

public static class Program
{
    public static void Main()
    {
        var matrix = new DiagonalMatrix<int>(5);
        var tracker = new MatrixTracker<int>(matrix);

        matrix[0, 0] = 10;
        matrix[1, 1] = 20;
        matrix[2, 2] = 30;

        Console.WriteLine($"Original values:\n {matrix.ToString()}");
        

        // Undo the last change
        tracker.Undo();
        Console.WriteLine($"\nAfter undo:\n {matrix.ToString()}");
        

        // Create another diagonal matrix and add it to the first
        var matrix2 = new DiagonalMatrix<int>(5);
        matrix2[0, 0] = 1;
        matrix2[1, 1] = 2;
        matrix2[2, 2] = 3;

        var resultMatrix = matrix.Add(matrix2, (a, b) => a + b);


        Console.WriteLine($"\nmatrix2:\n {matrix2.ToString()}");
        

        Console.WriteLine($"\nResult of matrix addition:\n {resultMatrix.ToString()}");
      
    }
}
