using Hurricane.XTest.Core.Abstract.Entities.Common;

namespace Hurricane.XTest.Core.Entities.Common
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; set; }

        public bool IsNull => Data == null;

        public DataResult(){}

        public DataResult(Result result)
        {
            Success = result.Success;
            Message = result.Message;
            Exception = result.Exception;
        }

        public DataResult(Result result, T data) : this(result)
        {
            Data = data;
        }

        public static DataResult<T> Empty() => new DataResult<T>();
        public static new DataResult<T> Fail() => Result.Fail().ToDataResult<T>();
    }
}
