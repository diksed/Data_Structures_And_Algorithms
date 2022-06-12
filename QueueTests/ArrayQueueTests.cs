using DataStructures.Queue;
using System;
using Xunit;

namespace QueueTests
{
    public class ArrayQueueTests
    {
        private ArrayQueue<int> _queue;
        public ArrayQueueTests()
        {
            _queue = new ArrayQueue<int>(new int[] { 10, 20, 30 });
        }
        [Fact]
        public void Count_Test()
        {
            var count = _queue.Count;

            Assert.Equal(3, count);
        }
        [Theory]
        [InlineData(23)]
        [InlineData(44)]
        [InlineData(66)]
        [InlineData(61)]
        [InlineData(55)]
        public void Enqueue(int value)
        {
            _queue.EnQueue(value);

            Assert.Equal(4, _queue.Count);
            Assert.Collection(_queue,
                item => Assert.Equal(10, item),
                item => Assert.Equal(20, item),
                item => Assert.Equal(30, item),
                item => Assert.Equal(value, item));
        }
        [Fact]
        public void Dequeue_Test()
        {
            var dequeue = _queue.DeQueue();

            Assert.Equal(2, _queue.Count);
            Assert.Collection(_queue,
                item => Assert.Equal(20, item),
                item => Assert.Equal(30, item));
            Assert.Equal(10, dequeue);
        }
        [Fact]
        public void Peek_Test()
        {
            var peek = _queue.Peek();

            Assert.Equal(3,_queue.Count);
            Assert.Equal(10, peek);
        }
        [Fact]
        public void Dequeue_EmptyQueueException_Test()
        {
            _queue.DeQueue();
            _queue.DeQueue();
            _queue.DeQueue();

            Assert.Throws<EmptyQueueException>(() => _queue.DeQueue());
        }
    }
}