namespace Task_4._1.Matrix
{
    public static class DiagonalMatrixExtensions
    {
        public static DiagonalMatrix<T> Add<T>(this DiagonalMatrix<T> matrix1, 
                                                   DiagonalMatrix<T> matrix2, 
                                                   Func<T, T, T> addFunction)
        {
            if (matrix1.Size != matrix2.Size)
                throw new ArgumentException("Matrices must be the same size.");

            var resultMatrix = new DiagonalMatrix<T>(matrix1.Size);

            for (int i = 0; i < matrix1.Size; i++) 
            { 
                var value1 = matrix1[i,i];
                var value2 = matrix2[i,i];
                resultMatrix[i,i] = addFunction(value1, value2);
            }

            return resultMatrix;
        }
    }
}
