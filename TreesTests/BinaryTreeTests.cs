using DataStructures.Trees.BinaryTree;
using System.Linq;
using Xunit;

namespace TreesTests
{
    public class BinaryTreeTests
    {
        private BinaryTree<int> bt;
        public BinaryTreeTests()
        {
            bt = new BinaryTree<int>();
        }
        [Fact]
        public void Insert_Create_Root()
        {
            bt.Insert(1);

            Assert.Equal(1, bt.Root.Value);
        }
        [Fact]
        public void Insert_Check_Left_Node()
        {
            bt.Insert(1);
            bt.Insert(2);

            Assert.Equal(bt.Root.Value, 1);
            Assert.Equal(bt.Root.Left.Value, 2);
        }
        [Fact]
        public void Insert_Check_Right_Node()
        {
            bt.Insert(1);
            bt.Insert(2);
            bt.Insert(3);

            Assert.Equal(bt.Root.Value, 1);
            Assert.Equal(bt.Root.Left.Value, 2);
            Assert.Equal(bt.Root.Right.Value, 3);
        }
        [Fact]
        public void Multiple_Insertion_Check()
        {
            new int[] { 1, 2, 3, 4, 5, 6, 7 }.ToList()
                .ForEach(x => bt.Insert(x));

            Assert.Equal(bt.Root.Value, 1);
            Assert.Equal(bt.Root.Left.Value, 2);
            Assert.Equal(bt.Root.Right.Value, 3);
            Assert.Equal(bt.Root.Left.Left.Value, 4);
            Assert.Equal(bt.Root.Left.Right.Value, 5);
            Assert.Equal(bt.Root.Right.Left.Value, 6);
            Assert.Equal(bt.Root.Right.Right.Value, 7);
        }
        [Fact]
        public void Count_Check()
        {
            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
            .Where(x => x % 2 == 0)
            .ToList()
            .ForEach(x => bt.Insert(x));

            Assert.Equal(bt.Root.Value, 2);
            Assert.Equal(bt.Root.Left.Value, 4);
            Assert.Equal(bt.Root.Right.Value, 6);
            Assert.Equal(bt.Root.Left.Left.Value, 8);
            Assert.Equal(bt.Root.Left.Right.Value, 10);

            Assert.Equal(5, bt.Count);
        }
        [Fact]
        public void Level_Order_Traverse_Test()
        {
            new int[] { 1, 2, 3, 4, 5, 6, 7 }
            .ToList()
            .ForEach(x => bt.Insert(x));

            var list = BinaryTree<int>.LevelOrderTraverse(bt.Root);

            Assert.Collection(list,
                item => Assert.Equal(bt.Root.Value, item.Value),
                item => Assert.Equal(2, item.Value),
                item => Assert.Equal(3, item.Value),
                item => Assert.Equal(4, item.Value),
                item => Assert.Equal(5, item.Value),
                item => Assert.Equal(6, item.Value),
                item => Assert.Equal(7, item.Value));

            Assert.Equal(7, bt.Count);

        }
        [Fact]
        public void GetEnumerator_Test()
        {
            new int[] { 1, 2, 3, 4, 5, 6, 7 }
            .ToList()
            .ForEach(x => bt.Insert(x));

            var list = BinaryTree<int>.LevelOrderTraverse(bt.Root);
            Assert.Collection(list,
                item => Assert.Equal(bt.Root.Value, item.Value),
                item => Assert.Equal(2, item.Value),
                item => Assert.Equal(3, item.Value),
                item => Assert.Equal(4, item.Value),
                item => Assert.Equal(5, item.Value),
                item => Assert.Equal(6, item.Value),
                item => Assert.Equal(7, item.Value));

            Assert.Equal(7, bt.Count);
        }
        [Fact]
        public void IsLeaf_Test()
        {
            new int[] { 1, 2, 3, 4, 5, 6, 7 }
            .ToList()
            .ForEach(x => bt.Insert(x));

            Assert.True(bt.Root.Left.Left.IsLeaf);
        }
        [Fact]
        public void IsNotLeaf_Test()
        {
            new int[] { 1, 2, 3, 4, 5, 6, 7 }
            .ToList()
            .ForEach(x => bt.Insert(x));

            Assert.False(bt.Root.Right.IsLeaf);
        }
    }
}