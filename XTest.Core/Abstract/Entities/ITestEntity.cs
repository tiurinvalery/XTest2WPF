using System;
using System.Collections.Generic;
using System.Text;
using XTest.Core.Const.Enums;

namespace XTest.Core.Abstract.Entities
{
    public interface ITestEntity : IBaseTestEntity
    {
        string Theotry { get; set; }
        TestType TestType { get; set; }
      
        ICollection<IQuestionEntity> Questions { get; set; }
    }
}
