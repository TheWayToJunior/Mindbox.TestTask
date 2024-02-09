using Mindbox.TestTask.Core.Exceptions;
using Mindbox.TestTask.Core.IContracts;

namespace Mindbox.TestTask.Core.Models
{
    public abstract class Triangle<T> : IShape 
        where T: IPoint
    {
        public Triangle(T a, T b, T c)
        {
            A = a!;
            B = b!;
            C = c!;

            if (!IsTriangleValid())
            {
                throw new InvalidTriangleException();
            }
        }

        public T A { get; }

        public T B { get; }

        public T C { get; }

        public abstract double CalculateArea();

        private bool IsTriangleValid()
        {
            double sideAB = A.DistanceTo(B);
            double sideBC = B.DistanceTo(C);
            double sideCA = C.DistanceTo(A);

            /// A triangle exists if the sum of the lengths of any two sides is greater than the length of the third side
            return sideAB + sideBC > sideCA &&
                   sideBC + sideCA > sideAB &&
                   sideCA + sideAB > sideBC;
        }

        public bool IsRightAngleTriangle()
        {
            double sideA = A.DistanceTo(B);
            double sideB = B.DistanceTo(C);
            double sideC = C.DistanceTo(A);

            double a = Math.Pow(sideA, 2);
            double b = Math.Pow(sideB, 2);
            double c = Math.Pow(sideC, 2);

            /// Check if the triangle is rectangular
            return (a == b + c) || (b == a + c) || (c == a + b);
        }
    }
}
