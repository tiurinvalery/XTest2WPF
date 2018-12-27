using System.Collections.Generic;
using XTest.Bl.Core.Abstract.Entities;
using XTest.Bl.Core.Const.Enums;

namespace XTest.Bl.Core.Entities
{
    public class TestEntity : BaseTestEntity,ITestEntity
    {
      public  string Theotry { get; set; }//??
      public  TestType TestType { get; set; }
      public  ICollection<IQuestionEntity> Questions { get; set; }
    }
}
