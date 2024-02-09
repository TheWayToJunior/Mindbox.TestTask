namespace Mindbox.TestTask.Core.Exceptions
{
    public class InvalidCircleException : Exception
    {
        public InvalidCircleException()
            : base("The circle with the specified parameters does not exist")
        {
        }
    }
}
