using Mindbox.TestTask.Core.IContracts;
using Mindbox.TestTask.Core.Models.Cartesian;

namespace Mindbox.TestTask.Core.Extensions
{
    public static class CartesianShapeFactoryExtension
    {
        public static CartesianCircle CreateCircle(
            this IShapeFactory<CartesianCircle, CircleArgs<CartesianPoint>> factory, 
            CartesianPoint center,
            double radius)
        {
            return factory.Create(new CircleArgs<CartesianPoint>(center, radius));
        }

        public static CartesianTriangle CreateTriangle(
            this IShapeFactory<CartesianTriangle, TriangleArgs<CartesianPoint>> factory,
            CartesianPoint a,
            CartesianPoint b, 
            CartesianPoint c)
        {
            return factory.Create(new TriangleArgs<CartesianPoint>(a, b, c));
        }
    }
}
