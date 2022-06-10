using ValueAndReferenceTypes;
using Xunit;

namespace ValueAndReferenceTypesTests
{
    public class ValueAndRefTypesTests
    {
        [Fact]
        public void RefTypeTest()
        {
            // Arrange
            var p1 = new RefType { X = 10, Y = 20 };
            var p2 = p1;

            // Act
            p1.X = 30;

            // Assert
            Assert.Equal(p1.X, p2.X);
        }
        [Fact]
        public void ValueTypeTest()
        {
            var p1 = new ValueType { X = 10, Y = 20 };
            var p2 = p1;

            p1.X = 30;

            Assert.NotEqual(p1.X, p2.X);
        }
        [Fact]
        public void RecordTypeTest()
        {
            var p1 = new RecordType(30, 50);

            var p2 = new RecordType(3, 5);

            Assert.NotEqual(p1, p2);
        }
        [Fact]
        public void SwapByValue()
        {
            int a = 23, b = 55;

            var valType = new ValueType();
            valType.Swap(a, b);

            Assert.Equal(55, b);
            Assert.Equal(23, a);
        }
        [Fact]
        public void SwapByRef()
        {
            int a = 23, b = 55;

            var valType = new RefType();
            valType.Swap(ref a, ref b);

            Assert.Equal(55, a);
            Assert.Equal(23, b);
        }
        [Fact]
        public void CheckOutKeyword()
        {
            var refType = new RefType();
            int b = 50;

            refType.CheckOut(out b);

            Assert.Equal(100, b);
        }
    }
}