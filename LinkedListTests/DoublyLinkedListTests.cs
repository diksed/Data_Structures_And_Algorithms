using LinkedList.DoblyLinkedList;
using System;
using Xunit;

namespace LinkedListTests
{
    public class DoublyLinkedListTests
    {
        private DoublyLinkedList<char> _list;
        public DoublyLinkedListTests()
        {
            _list = new DoublyLinkedList<char>(new char[] {'a','z'});
        }
        [Theory]
        [InlineData('f')]
        [InlineData('e')]
        [InlineData('m')]
        [InlineData('o')]
        [InlineData('t')]
        public void AddFirst_Test(char value)
        {
            _list.AddFirst(value);

            Assert.Equal(value, _list.Head.Value);
        }
        [Fact]
        public void Count_Test()
        {
            var count = _list.Count;

            Assert.Equal(2, count);
        }
        [Theory]
        [InlineData('f')]
        [InlineData('e')]
        [InlineData('r')]
        public void AddLast_Test(char value)
        {
            _list.AddLast(value);
            var tailValue = _list.Tail.Value;

            Assert.Equal(value, tailValue);
            Assert.Collection(_list,
                item => Assert.Equal(item, 'a'),
                item => Assert.Equal(item, 'z'),
                item => Assert.Equal(item, value));
        }
        [Theory]
        [InlineData('k')]
        [InlineData('m')]
        [InlineData('n')]
        [InlineData('r')]
        [InlineData('s')]
        public void AddBefore_Test(char value)
        {
            _list.AddBefore(_list.Head.Next, value);

            Assert.Equal(value, _list.Head.Next.Value);

            Assert.Collection(_list,
                item => Assert.Equal(item, 'a'),
                item => Assert.Equal(item, value),
                item => Assert.Equal(item, 'z'));
        }
        [Fact]
        public void AddBefore_ArgumentException_Test()
        {
            DbNode<char> node = new DbNode<char>('x');

            Assert.Throws<ArgumentException>(() =>
            _list.AddBefore(node, node.Value));
        }
        [Theory]
        [InlineData('k')]
        [InlineData('m')]
        [InlineData('n')]
        [InlineData('r')]
        [InlineData('s')]
        public void AddAfter_Test(char value)
        {
            _list.AddAfter(_list.Head.Next, value);

            Assert.Equal(value, _list.Tail.Value);

            Assert.Collection(_list,
                item => Assert.Equal(item, _list.Head.Value),
                item => Assert.Equal(item, _list.Head.Next.Value),
                item => Assert.Equal(value, _list.Tail.Value));
        }
        [Fact]
        public void RemoveFirst_Test()
        {
            _list.RemoveFirst();

            Assert.Collection(_list, item => Assert.Equal(item, 'z'));
        }
        [Fact]
        public void RemoveLast_Exception_Test()
        {
            var r1 = _list.RemoveLast();
            var r2 = _list.RemoveLast();

            Assert.Equal(r1, 'z');
            Assert.Equal(r2, 'a');
            Assert.Throws<Exception>(() => _list.RemoveLast());
        }
        [Fact]
        public void Remove_Exception_Test()
        {
            _list.Remove('a');
            _list.Remove('z');

            Assert.Throws<Exception>(() => _list.Remove('x'));
        }
        [Fact]
        public void ToList_Test()
        {
            var list = _list.ToList();

            Assert.Collection(list,
                item => Assert.Equal(item, _list.Head.Value),
                item => Assert.Equal(item, _list.Head.Next.Value));
        }

    }
}
