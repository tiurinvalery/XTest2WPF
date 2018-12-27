using System;
using System.Collections.Generic;
using System.Text;

namespace XTest.Core.Abstract.Entities.Common
{
    public interface IResult
    {
        bool Success { get; set; }

        string Message { get; set; }

        Exception Exception { get; set; }
    }
}
