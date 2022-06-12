using LinkedList.DoblyLinkedList;
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
        [InlineData('r')]
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
    }
}
