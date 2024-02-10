using Mindbox.TestTask.Core.IContracts;

namespace Mindbox.TestTask.Cartesian.Models
{
    public class CartesianPoint(double x, double y) : IPoint
    {
        public double X { get; } = x;

        public double Y { get; } = y;

        public double DistanceTo(IPoint other)
        {
            if (other is not CartesianPoint cartesianPoint)
            {
                throw new ArgumentException("It is not possible to calculate the distance between points of different types");
            }

            double deltaX = X - cartesianPoint.X;
            double deltaY = Y - cartesianPoint.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
