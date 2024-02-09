using Mindbox.TestTask.Core.Models.Cartesian;

namespace Mindbox.TestTask.UnitTests
{
    public class CartesianPointTests
    {
        [Fact]
        public void DistanceTo_ReturnsCorrectDistance()
        {
            // Arrange
            CartesianPoint point1 = new(0, 0);
            CartesianPoint point2 = new(3, 4);

            double expectedDistance = 5;

            // Act
            double actualDistance = point1.DistanceTo(point2);

            // Assert
            Assert.Equal(expectedDistance, actualDistance);
        }

        [Fact]
        public void DistanceTo_ReturnsZero_ForSamePoint()
        {
            // Arrange
            CartesianPoint point1 = new(2, 2);
            CartesianPoint point2 = new(2, 2);

            double expectedDistance = 0;

            // Act
            double actualDistance = point1.DistanceTo(point2);

            // Assert
            Assert.Equal(expectedDistance, actualDistance);
        }
    }
}
