using Mindbox.TestTask.Core.Exceptions;
using Mindbox.TestTask.Cartesian.Extensions;
using Mindbox.TestTask.Cartesian.Models;

namespace Mindbox.TestTask.UnitTests
{
    public class CartesianTriangleTests
    {
        [Fact]
        public void CalculateArea_ReturnsCorrectArea_ForRightAngleTriangle()
        {
            // Arrange
            CartesianPoint pointA = new(0, 0);
            CartesianPoint pointB = new(3, 0);
            CartesianPoint pointC = new(0, 4);

            CartesianShapeFactory shapeFactory = new();
            CartesianTriangle triangle = shapeFactory.CreateTriangle(pointA, pointB, pointC);

            double expectedArea = 6;

            // Act
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void CalculateArea_ReturnsZero_ForDegenerateTriangle()
        {
            // Arrange
            CartesianPoint pointA = new(0, 0);
            CartesianPoint pointB = new(0, 0);
            CartesianPoint pointC = new(0, 0);

            Assert.Throws<InvalidTriangleException>(() =>
            {
                CartesianTriangle triangle = new(pointA, pointB, pointC);
            });
        }

        [Fact]
        public void CalculateArea_ReturnsCorrectArea_ForRightTriangle()
        {
            // Arrange
            CartesianPoint pointA = new(0, 0);
            CartesianPoint pointB = new(3, 0);
            CartesianPoint pointC = new(0, 4);

            CartesianShapeFactory shapeFactory = new();
            CartesianTriangle triangle = shapeFactory.CreateTriangle(pointA, pointB, pointC);

            // Expected area of right triangle with legs 3 and 4 is 1/2 * 3 * 4 = 6
            double expectedArea = 6;

            // Act
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void IsRightAngleTriangle_ReturnsTrue_ForRightAngleTriangle()
        {
            // Arrange
            CartesianPoint pointA = new(0, 0);
            CartesianPoint pointB = new(3, 0);
            CartesianPoint pointC = new(0, 4);

            CartesianShapeFactory shapeFactory = new();
            CartesianTriangle triangle = shapeFactory.CreateTriangle(pointA, pointB, pointC);

            // Act
            bool isRightAngleTriangle = triangle.IsRightAngleTriangle();

            // Assert
            Assert.True(isRightAngleTriangle);
        }

        [Fact]
        public void IsRightAngleTriangle_ReturnsFalse_ForNonRightAngleTriangle()
        {
            // Arrange
            CartesianPoint pointA = new(0, 0);
            CartesianPoint pointB = new(3, 0);
            CartesianPoint pointC = new(0, 3);

            CartesianShapeFactory shapeFactory = new();
            CartesianTriangle triangle = shapeFactory.CreateTriangle(pointA, pointB, pointC);

            // Act
            bool isRightAngleTriangle = triangle.IsRightAngleTriangle();

            // Assert
            Assert.False(isRightAngleTriangle);
        }
    }
}
