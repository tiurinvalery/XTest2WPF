namespace XTest.Bl.Core.Abstract.Entities.Common
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; set; }

        bool IsNull { get; }
    }
}
