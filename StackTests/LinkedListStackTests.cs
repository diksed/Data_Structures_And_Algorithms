using DataStructures.Stack.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StackTests
{
    public class LinkedListStackTests
    {
        private readonly IStack<char> _stack;
        public LinkedListStackTests()
        {
            _stack = new
                DataStructures
                .Stack
                .LinkedListStack<char>(new char[] { 's', 'e', 'l', 'a', 'm' });
        }
        [Fact]
        public void Count_Test()
        {
            var count = _stack.Count;

            Assert.Equal(5,count);
        }
        [Fact]
        public void Pop_Test()
        {
            var pop = _stack.Pop();

            Assert.Equal('m', pop);
            Assert.Collection(_stack,
                item => Assert.Equal('a',item),
                item => Assert.Equal('l',item),
                item => Assert.Equal('e', item),
                item => Assert.Equal('s', item));
        }
        [Theory]
        [InlineData('m')]
        [InlineData('e')]
        [InlineData('r')]
        [InlineData('h')]
        [InlineData('a')]
        [InlineData('b')]
        [InlineData('a')]
        public void Push_Test(char value)
        {
            _stack.Push(value);

            Assert.Equal(value, _stack.Peek());
        }
    }
}
