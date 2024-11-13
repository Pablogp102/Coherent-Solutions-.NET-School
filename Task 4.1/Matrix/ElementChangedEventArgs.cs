namespace Task_4._1.Matrix
{
    public class ElementChangedEventArgs<T> : EventArgs
    {
        public int Row { get; }
        public int Column { get; }
        public T OldValue { get; }
        public T NewValue { get; }

        public ElementChangedEventArgs(int row, int colum, T oldValue, T newValue)
        {
            Row = row;
            Column = colum;
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}