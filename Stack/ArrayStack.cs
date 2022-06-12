using DataStructures.Array.Generic;
using DataStructures.Stack.Contracts;
using System.Collections;


namespace DataStructures.Stack
{
    public class ArrayStack<T> : IStack<T>
    {
        private readonly Array<T> _Array = new Array<T>();
        public int Count => _Array.Count;
        public IEnumerator<T> GetEnumerator()
        {
            return _Array.GetEnumerator();
        }
        public T Peek()
        {
            if(Count == 0)
                return default(T);
            return _Array.GetValue(_Array.Count - 1);
        }
        public T Pop()
        {
            if (Count == 0)
                throw new Exception("Empty stack.");
            var result = _Array.Remove();
            return result;
        }
        public void Push(T item)
        {
            _Array.Add(item);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
