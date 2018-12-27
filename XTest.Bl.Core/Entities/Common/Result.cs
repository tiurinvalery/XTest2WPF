using System;

namespace XTest.Bl.Core.Entities.Common
{
    public class Result
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public Exception Exception { get; set; }

        public DataResult<T> ToDataResult<T>(T data) 
            => new DataResult<T>(this, data);

        public DataResult<T> ToDataResult<T>()
            => new DataResult<T>(this);

        public static Result Fail() => new Result { Success = false };
        public static Result Fail(string message)
            => new Result { Success = false, Message = message };
        public static Result Fail(Exception exception) 
            => new Result { Success = false, Exception = exception };
    }
}
