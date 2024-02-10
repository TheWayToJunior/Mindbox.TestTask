using Mindbox.TestTask.Core.IContracts;

namespace Mindbox.TestTask.Cartesian.Models
{
    public record TriangleArgs<T>(T A, T B, T C) where T : IPoint;

    public record CircleArgs<T>(T Center, double Radius) where T : IPoint;

    public class CartesianShapeFactory :
        IShapeFactory<CartesianTriangle, TriangleArgs<CartesianPoint>>,
        IShapeFactory<CartesianCircle, CircleArgs<CartesianPoint>>
    {
        public CartesianTriangle Create(TriangleArgs<CartesianPoint> args)
        {
            return new CartesianTriangle(args.A, args.B, args.C);
        }

        public CartesianCircle Create(CircleArgs<CartesianPoint> args)
        {
            return new CartesianCircle(args.Center, args.Radius);
        }
    }
}
