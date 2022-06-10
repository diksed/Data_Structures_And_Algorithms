using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CollectionsTests
{
    public class collectionListTest
    {
        private List<int> leftList;
        private List<int> rightList;
        public collectionListTest()
        {
            leftList = new List<int> { 1, 2, 3, 4, 4, 5 };
            rightList = new List<int> { 4, 5, 6, 6, 7 };
        }
        [Fact]
        public void Add_Test()
        {
            leftList.Add(10);

            Assert.Equal(7, leftList.Count);
        }
        [Fact]
        public void AddRange_Test()
        {
            leftList.AddRange(new int[] { 7, 8 });

            Assert.Collection(leftList,
                item => Assert.Equal(item, leftList[0]),
                item => Assert.Equal(item, leftList[1]),
                item => Assert.Equal(item, leftList[2]),
                item => Assert.Equal(item, leftList[3]),
                item => Assert.Equal(item, leftList[4]),
                item => Assert.Equal(item, leftList[5]),
                item => Assert.Equal(item, leftList[6]),
                item => Assert.Equal(item, leftList[7])
                );
        }
        [Fact]
        public void InterSection_Test()
        {
            var interSectionSet = leftList.Intersect(rightList);

            Assert.Collection(interSectionSet,
                item => Assert.Equal(item, 4),
                item => Assert.Equal(item, 5)
                );
        }
        [Fact]
        public void Union_Test()
        {
            var unionSet = leftList.Union(rightList);

            Assert.Collection(unionSet,
                item => Assert.Equal(item, 1),
                item => Assert.Equal(item, 2),
                item => Assert.Equal(item, 3),
                item => Assert.Equal(item, 4),
                item => Assert.Equal(item, 5),
                item => Assert.Equal(item, 6),
                item => Assert.Equal(item, 7)
                );
        }
    }
}