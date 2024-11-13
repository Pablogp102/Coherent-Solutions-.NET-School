using System.Text;
namespace Task_2._2.Classes
{
    public class DiagonalMatrix
    {
        private int[] diagonalElements;

        public int Size => diagonalElements.Length;

        public DiagonalMatrix(params int[] elements)
        {
            diagonalElements = new int[elements.Length];
            Array.Copy(elements, diagonalElements, elements.Length);
        }

        public int this[int i, int j]
        {
            get
            {
                ValidateIndexes(i, j);
                return i == j ? diagonalElements[i] : 0;
            }

            set
            {
                ValidateIndexes(i, j);

                if (i == j) 
                { 
                    diagonalElements[i] = value;
                }
            }
        }

        private void ValidateIndexes(int i, int j)
        { 
            if (i < 0 || j < 0 || i >= Size || j >= Size)
            {
                throw new IndexOutOfRangeException($"Indices out of range: i={i}, j={j}. Valid range is 0 to {Size - 1}.");
            }
        }

        public int Track()
        {
            int sum = 0;
            for (int i = 0; i < Size; i++)
            {
                sum += diagonalElements[i];
            }
            return sum;
        }

        public override bool Equals(object? obj)
        {
            if(obj is DiagonalMatrix other && other.Size == Size)
            {
                for(int i = 0; i < Size; i++)
                {
                    if (this.diagonalElements[i] != other.diagonalElements[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            if (Size == 0) return "Empty Matrix";

            var result = new StringBuilder();
            for (int i = 0; i <= Size; i++) 
            { 
                for(int j = 0; j < Size; j++)
                {
                    result.Append(this[i, j] + "\t");
                }
                result.AppendLine();
            }
            return result.ToString();
        }
    }
}
