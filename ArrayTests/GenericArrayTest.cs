using DataStructures.Array.Generic;
using System.Collections.Generic;
using Xunit;

namespace ArrayTests
{
    public class GenericArrayTest
    {
        private Array<char> _array;
        public GenericArrayTest()
        {
            _array = new Array<char>(new List<char> { 's', 'a', 'm', 'u' });
        }
        [Theory]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        public void DefaultSize_Test(int defaultSize)
        {
            var arr = new Array<char>(defaultSize);

            Assert.Equal(arr.Length, defaultSize);
        }
        [Fact]
        public void Params_Test()
        {
            var arr = new Array<int>(1, 2, 3, 4);

            Assert.Equal(4, arr.Length);
        }
        [Fact]
        public void GetValue_Test()
        {
            var c = _array.GetValue(0);

            Assert.Equal('s', c);
            Assert.IsType<char>(c);
            Assert.True(c is char);
            Assert.IsType(typeof(char), c);
        }
        [Fact]
        public void SetValue_Test()
        {
            _array.SetValue('S', 0);

            Assert.Equal('S', _array.GetValue(0));
        }
    }
}
