namespace Mindbox.TestTask.Core.IContracts
{
    public interface IShapeFactory<TShape, TArgs> where TShape : IShape
    {
        TShape Create(TArgs args);
    }
}
