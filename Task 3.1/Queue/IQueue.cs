﻿namespace Task_3._1.Queue
{
    public interface IQueue<T> where T : struct
    {
        void Enqueue(T element);
        T Dequeue();
        bool IsEmpty();
    }
}
