using System.Text;

namespace Task_4._1.Matrix
{
    public class DiagonalMatrix<T>
    {
        private readonly T[] diagonalElements;
        public int Size { get; }
        public event EventHandler<ElementChangedEventArgs<T>> ElementChanged;

        public DiagonalMatrix(int size)
        {
            if (size < 0)
            {
                throw new ArgumentException("Size must be non-negative value.");
            }
                Size = size;
            diagonalElements = new T[size];
        }
        public T this[int i, int j]
        {
            get 
            {
                ValidateIndices(i,j);
                return i == j ? diagonalElements[i] : default(T);
            }
            set 
            {
                ValidateIndices(i, j);
                if (i == j && !EqualityComparer<T>.Default.Equals(diagonalElements[i], value))
                {
                    var oldValue = diagonalElements[i];
                    diagonalElements[i] = value;
                    ElementChanged?.Invoke(this, new ElementChangedEventArgs<T>(i,j,oldValue, value));
                }
            }
        }

        private void ValidateIndices(int i, int j)
        {
            if(i < 0  || i >= Size || j < 0 || j >= Size)
            {
                throw new IndexOutOfRangeException("Indices are out of range");
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i == j)
                    {
                        sb.Append($"{diagonalElements[i]}\t");
                    }
                    else
                    {
                        sb.Append($"{default(T)}\t");
                    }
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
