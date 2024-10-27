namespace Task_3._1.Queue
{
    public static class QueueExtension
    {
        public static IQueue<T> Tail<T>(this IQueue<T> orginalQueue)
        {
            var newQueue = new Queue<T>();

            orginalQueue.Dequeue();
            while (!orginalQueue.IsEmpty())
            {
                newQueue.Enqueue(orginalQueue.Dequeue());
            }

            return newQueue;
        }


    }
}
