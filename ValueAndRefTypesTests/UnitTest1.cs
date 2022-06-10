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
    }
}