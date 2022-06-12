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
    }
}
