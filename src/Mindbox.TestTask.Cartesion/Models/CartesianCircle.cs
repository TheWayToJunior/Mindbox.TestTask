using Mindbox.TestTask.Core.Exceptions;
using Mindbox.TestTask.Core.IContracts;

namespace Mindbox.TestTask.Cartesian.Models
{
    public class CartesianCircle : IShape
    {
        public CartesianCircle(CartesianPoint center, double radius)
        {
            Center = center!;

            if(radius < 0)
            {
                throw new InvalidCircleException();
            }

            Radius = radius;
        }

        public CartesianPoint Center { get; }

        public double Radius { get; }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
