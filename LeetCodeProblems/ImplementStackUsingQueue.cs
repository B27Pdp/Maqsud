    public class MyStack
    {
        Queue<int> queue = new Queue<int>();
        Queue<int> queue2 = new Queue<int>();

        public MyStack()
        {

        }

        public void Push(int x)
        {
            int count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                queue2.Enqueue(queue.Dequeue());
            }
            queue.Enqueue(x);
            for (int i = 0; i < count; i++)
            {
                queue.Enqueue(queue2.Dequeue());
            }
        }

        public int Pop()
        {
            return queue.Dequeue();
        }

        public int Top()
        {

            return queue.Peek();
        }

        public bool Empty()
        {
            return queue.Count == 0;
        }
    }