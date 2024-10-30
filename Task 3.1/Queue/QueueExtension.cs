namespace Task_3._1.Queue
{
    public static class QueueExtension
    {
        public static IQueue<T> Tail<T>(this IQueue<T> originalQueue)  where T : struct 
        {
            if (originalQueue.IsEmpty())
            {
                throw new InvalidOperationException("Cannot create a tail from an empty queue.");
            }

            var newQueue = new Queue<T>();
            var tempQueue = new Queue<T>();

            originalQueue.Dequeue();
            
            while (!originalQueue.IsEmpty())
            {
                var element = originalQueue.Dequeue();
                newQueue.Enqueue(element);
                tempQueue.Enqueue(element);
            }

            while (!tempQueue.IsEmpty()) 
            {
                originalQueue.Enqueue(tempQueue.Dequeue());
            }

            return newQueue;
        }


    }
}
