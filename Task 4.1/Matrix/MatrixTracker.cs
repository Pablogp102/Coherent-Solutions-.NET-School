namespace Task_4._1.Matrix
{
    public class MatrixTracker<T>
    {
        private readonly DiagonalMatrix<T> _matrix;
        private readonly Stack<ElementChangedEventArgs<T>> _history = new();
        public MatrixTracker(DiagonalMatrix<T> matrix)
        {
            _matrix = matrix ?? throw new ArgumentNullException(nameof(matrix));
            _matrix.ElementChanged += OnElementChanged;
        }
        private void OnElementChanged(object sender, ElementChangedEventArgs<T> e)
        { 
            _history.Push(e);
        }

        public void Undo() 
        { 
            if(_history.Count > 0)
            {
                var lastChange = _history.Pop();
                _matrix[lastChange.Row, lastChange.Column] = lastChange.OldValue;
            }
        }
    }
}
