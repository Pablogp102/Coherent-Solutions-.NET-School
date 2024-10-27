using System;

namespace Task_3._1.Queue;

class Program
{
    static void Main()
    {
        IQueue<int> intQueue = new Queue<int>(5);

        intQueue.Enqueue(1);
        intQueue.Enqueue(3);
        intQueue.Enqueue(5);
        intQueue.Enqueue(7);

        var stringQueue = new Queue<string>();
        stringQueue.Enqueue("apple");
        stringQueue.Enqueue("banana");
        stringQueue.Enqueue("cherry");
        
        Console.WriteLine("Orginal int queue:");
        DisplayQueue(intQueue);

        var tailIntQueue = intQueue.Tail();
        Console.WriteLine("\nTail of the orginal queue:");
        DisplayQueue(tailIntQueue);

        Console.WriteLine("Orginal string queue:");
        DisplayQueue(stringQueue);

        var tailStringQueue = stringQueue.Tail();
        Console.WriteLine("\nTail of the orginal queue:");
        DisplayQueue(tailStringQueue);
    }

    static void DisplayQueue<T>(IQueue<T> queue)
    {
        var tempQueue = new Queue<T>();

        while (!queue.IsEmpty())
        {
            T item = queue.Dequeue();
            Console.Write(item + " ");
            tempQueue.Enqueue(item);  
        }

        Console.WriteLine();

        while (!tempQueue.IsEmpty())
        {
            queue.Enqueue(tempQueue.Dequeue());
        }
    }

}
