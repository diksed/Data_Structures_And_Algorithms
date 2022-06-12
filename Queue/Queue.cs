using DataStructures.Queue.Contracts;
using System.Collections;

namespace DataStructures.Queue
{
    public class Queue<T> : IQueue<T>
    {
        private readonly IQueue<T> _queue;
        public int Count => _queue.Count;
        public T DeQueue()
        {
            return _queue.DeQueue();
        }
        public void EnQueue(T value)
        {
            _queue.EnQueue(value);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return _queue.GetEnumerator();
        }
        public T Peek()
        {
            return _queue.Peek();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}