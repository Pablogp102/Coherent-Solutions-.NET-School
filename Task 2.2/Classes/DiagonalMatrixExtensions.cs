namespace Task_2._2.Classes
{
    public static class DiagonalMatrixExtensions
    {
        public static DiagonalMatrix Add(this DiagonalMatrix matrix, DiagonalMatrix other)    
        {
            int size = Math.Max(matrix.Size, other.Size);
            int[] resultElements = new int[size];

            for (int i = 0; i < size; i++)
            {
                int element1 = (i < matrix.Size) ? matrix[i, i] : 0;
                int element2 = (i < other.Size) ? other[i, i] : 0;
                resultElements[i] = element1 + element2;
            }

            return new DiagonalMatrix(resultElements);
        }
    }
}
