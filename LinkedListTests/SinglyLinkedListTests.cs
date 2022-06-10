using DataStructures.LinkedList.SinglyLinkedList;
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
    }
}