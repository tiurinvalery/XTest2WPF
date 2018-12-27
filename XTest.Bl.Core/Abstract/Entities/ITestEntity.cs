using System.Collections.Generic;
using XTest.Bl.Core.Const.Enums;

namespace XTest.Bl.Core.Abstract.Entities
{
    public interface ITestEntity : IBaseTestEntity
    {
        string Theotry { get; set; }
        TestType TestType { get; set; }
      
        ICollection<IQuestionEntity> Questions { get; set; }
    }
}
