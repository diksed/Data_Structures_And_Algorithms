using DataStructures.LinkedList.SinglyLinkedList;
using System;
using Xunit;

namespace LinkedListTests
{
    public class SinglyLinkedListTests
    {
        private SinglyLinkedList<int> _list;
        public SinglyLinkedListTests()
        {
            _list = new SinglyLinkedList<int>(new int[] { 6, 8 });
        }
        [Fact]
        public void Count_Test()
        {
            int count = _list.Count;

            Assert.Equal(2, count);
        }
        [Theory]
        [InlineData(6)]
        [InlineData(10)]
        [InlineData(15)]
        [InlineData(2)]
        [InlineData(7)]
        public void AddFirst_Test(int value)
        {
            _list.AddFirst(value);

            Assert.Equal(value, _list.Head.Value);
            //Assert.Collection(_list,
            //    item => Assert.Equal(item, value),
            //    item => Assert.Equal(item, 8),
            //    item => Assert.Equal(value, 6)
            //    );
        }
        [Fact]
        public void GetEnumerator_Test()
        {
            Assert.Collection(_list,
                item => Assert.Equal(item, 8),
                item => Assert.Equal(item, 6));
        }
        [Theory]
        [InlineData(6)]
        [InlineData(10)]
        [InlineData(15)]
        [InlineData(2)]
        [InlineData(7)]
        public void AddLast_Test(int value)
        {
            _list.AddLast(value);

            Assert.Collection(_list,
                item => Assert.Equal(8, item),
                item => Assert.Equal(6, item),
                item => Assert.Equal(value, item));
        }
        [Theory]
        [InlineData(60)]
        [InlineData(6)]
        [InlineData(10)]
        [InlineData(15)]
        [InlineData(1)]
        [InlineData(9)]
        public void AddBefore_Test(int value)
        {
            _list.AddBefore(_list.Head.Next, value);

            Assert.Collection(_list,
                item => Assert.Equal(8,item),
                item => Assert.Equal(value, item),
                item => Assert.Equal(6, item)
            );
        }
        [Fact]
        public void AddBefore_ArgumentException()
        {
            var node = new SinglyLinkedListNode<int>(55);

            Assert.Throws<ArgumentException>(() => _list.AddBefore(node, 45));
        }
        [Theory]
        [InlineData(60)]
        [InlineData(6)]
        [InlineData(10)]
        [InlineData(15)]
        [InlineData(1)]
        [InlineData(9)]
        public void AddAfter_Test(int value)
        {
            _list.AddAfter(_list.Head, value);

            Assert.Collection(_list,
                item => Assert.Equal(8,item),
                item => Assert.Equal(value, item),
                item => Assert.Equal(6, item));
        }
        [Fact]
        public void AddAfter_ArgumentException()
        {
            var node = new SinglyLinkedListNode<int>(55);

            Assert.Throws<ArgumentException>(() => _list.AddAfter(node, 45));
        }
        [Fact]
        public void RemoveFirst_Test()
        {
            _list.RemoveFirst();

            Assert.Collection(_list, item => Assert.Equal(6, item));
        }
        [Fact]
        public void RemoveFirst_Exception_Test()
        {
            _list.RemoveFirst();
            _list.RemoveFirst();

            Assert.Throws<Exception>(() => _list.RemoveFirst());
        }
        [Fact]
        public void RemoveLast_Test()
        {
            var result = _list.RemoveLast();

            Assert.Collection(_list, item => Assert.Equal(8, item));
            Assert.Equal(6, result);
        }
        [Theory]
        [InlineData(8)]
        public void Remove_Test(int value)
        {
            _list.AddFirst(10);
            _list.Remove(value);

            Assert.Collection(_list,
                item => Assert.Equal(10, item),
                item => Assert.Equal(6, item));
        }
    }
}