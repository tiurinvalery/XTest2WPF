using System;
using System.Collections.Generic;
using System.Text;

namespace XTest.Core.Abstract.Entities.Common
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; set; }

        bool IsNull { get; }
    }
}
