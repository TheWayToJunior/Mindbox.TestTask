using Mindbox.TestTask.Core.Exceptions;
using Mindbox.TestTask.Core.Extensions;

namespace Mindbox.TestTask.Core.Models.Cartesian
{
    public class CartesianCircleTests
    {
        [Fact]
        public void CalculateArea_ReturnsCorrectArea_ForCircleWithPositiveRadius()
        {
            // Arrange
            CartesianPoint center = new(0, 0);
            double radius = 5;

            CartesianShapeFactory shapeFactory = new();
            CartesianCircle circle = shapeFactory.CreateCircle(center, radius);

            // Expected area of circle with radius 5
            double expectedArea = Math.PI * Math.Pow(radius, 2);

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void CalculateArea_ReturnsZero_ForCircleWithZeroRadius()
        {
            // Arrange
            CartesianPoint center = new(0, 0);
            double radius = 0;

            CartesianShapeFactory shapeFactory = new();
            CartesianCircle circle = shapeFactory.CreateCircle(center, radius);

            // Expected area of circle with radius 0
            double expectedArea = 0;

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void CalculateArea_ReturnsZero_ForCircleWithNegativeRadius()
        {
            // Arrange
            CartesianPoint center = new(0, 0);
            double radius = -5;

            CartesianShapeFactory shapeFactory = new();

            Assert.Throws<InvalidCircleException>(() =>
            {
                CartesianCircle circle = shapeFactory.CreateCircle(center, radius);
            });
        }
    }
}
