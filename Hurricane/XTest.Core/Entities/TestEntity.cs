using System.Collections.Generic;
using Hurricane.XTest.Core.Abstract.Entities;
using Hurricane.XTest.Core.Const.Enums;

namespace Hurricane.XTest.Core.Entities
{
    public class TestEntity : BaseTestEntity,ITestEntity
    {
      public  string Theotry { get; set; }//??
      public  TestType TestType { get; set; }
      public  ICollection<IQuestionEntity> Questions { get; set; }
    }
}
