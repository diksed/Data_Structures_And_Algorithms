using DataStructures.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArrayTests
{
    public class ArrayListTests
    {
        private ArrayList _arrayList;
        public ArrayListTests()
        {
            _arrayList = new ArrayList();
        }
        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        public void ArrayList_Constructor_Test(int defaultSize)
        {
            var _arrayList = new ArrayList(defaultSize);

            Assert.Equal(_arrayList.Length, defaultSize);
        }
        [Fact]
        public void ArrayList_Add_Test()
        {
            for (int i = 0; i < 50; i++)
            {
                _arrayList.Add(i);
            }

            Assert.Equal(64, _arrayList.Length);
        }
        [Theory]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        public void ArrayList_Remove_Test(int len)
        {
            for (int i = 0; i < len; i++)
            {
                _arrayList.Add(i);
            }

            Assert.Equal(len, _arrayList.Length);

            for (int i = _arrayList.Length - 1; i > 8; i--)
            {
                _arrayList.Remove();
            }

            Assert.Equal(32, _arrayList.Length);
        }
        [Fact]
        public void ForEach_Test()
        {
            _arrayList.Add("a");
            _arrayList.Add("b");
            _arrayList.Add("c");
            _arrayList.Add("d");

            _arrayList.Remove();
            _arrayList.Remove();
            string s = "";
            foreach (var item in _arrayList)
            {
                s += item;
            }

            Assert.Equal("ab", s);
        }
        [Fact]
        public void ArrayList_Constructor_with_IEnumerable_Test()
        {
            var list = new List<int> { 1, 2, 3 };

            var array = new DataStructures.Array.ArrayList(list);
            string s = "";
            foreach (var item in array)
            {
                s += item;
            }

            Assert.Equal("123", s);
        }
        [Fact]
        public void IndexOf_Test()
        {
            _arrayList.Add("a");
            _arrayList.Add("b");
            _arrayList.Add("c");

            var result = _arrayList.IndexOf("c");

            Assert.Equal(2, result);
        }


    }
}
