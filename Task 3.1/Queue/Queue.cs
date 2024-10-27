namespace Task_3._1.Queue
{
    public class Queue<T> : IQueue<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node(T data) 
            { 
                Data = data;
                Next = null;
            }
        }

        private Node head;
        private Node tail;
        private int counter;
        private readonly int maxCapacity;

        public Queue(int maxCapacity = int.MaxValue)
        {
            head = null;
            tail = null;
            counter = 0;
            this.maxCapacity = maxCapacity;
        }
        public void Enqueue(T element)
        {
            if (counter >= maxCapacity) 
            {
                throw new InvalidOperationException("Queue has reached its maximum capacity.");
            }

            var newNode = new Node(element);
            if (IsEmpty())
            {
                head = newNode;
            }
            else 
            { 
                tail.Next = newNode;
            }
            tail = newNode;
            counter++;
        }
        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            var dequeuedData = head.Data;
            head = head.Next;
            counter--;
            if(head == null)
            {
                tail = null;
            }
            return dequeuedData;
        }


        public bool IsEmpty()
        {
            return counter == 0;
        }
    }
}
