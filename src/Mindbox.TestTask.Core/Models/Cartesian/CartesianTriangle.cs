using Mindbox.TestTask.Core.IContracts;

namespace Mindbox.TestTask.Core.Models.Cartesian
{
    public class CartesianTriangle(CartesianPoint a, CartesianPoint b, CartesianPoint c)
        : Triangle<CartesianPoint>(a, b, c)
    {
        public override double CalculateArea()
        {
            double a = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            double b = Math.Sqrt(Math.Pow(C.X - B.X, 2) + Math.Pow(C.Y - B.Y, 2));
            double c = Math.Sqrt(Math.Pow(C.X - A.X, 2) + Math.Pow(C.Y - A.Y, 2));

            /// Calculating the half-meter
            double s = (a + b + c) / 2;

            /// Calculate the area of the triangle using the Heron formula
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
