using System;
using System.Collections.Generic;
using System.Text;
using XTest.Core.Abstract.Entities;
using XTest.Core.Const.Enums;

namespace XTest.Core.Entities
{
    public class TestEntity : BaseTestEntity,ITestEntity
    {
      public  string Theotry { get; set; }//??
      public  TestType TestType { get; set; }
      public  ICollection<IQuestionEntity> Questions { get; set; }
    }
}
