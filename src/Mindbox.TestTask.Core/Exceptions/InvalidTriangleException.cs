namespace Mindbox.TestTask.Core.Exceptions
{
    public class InvalidTriangleException : Exception
    {
        public InvalidTriangleException()
            : base("The triangle with the specified coordinates does not exist")
        {

        }
    }
}
