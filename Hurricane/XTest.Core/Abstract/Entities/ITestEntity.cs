using System.Collections.Generic;
using Hurricane.XTest.Core.Const.Enums;

namespace Hurricane.XTest.Core.Abstract.Entities
{
    public interface ITestEntity : IBaseTestEntity
    {
        string Theotry { get; set; }
        TestType TestType { get; set; }
      
        ICollection<IQuestionEntity> Questions { get; set; }
    }
}
