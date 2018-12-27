using System;
using System.Collections.Generic;
using System.Text;
using XTest.Core.Abstract.Entities;
using XTest.Core.Const.Enums;

namespace XTest.Core.Entities
{
    public class BaseTestEntity : IBaseTestEntity
    {
        public string Name { get; set; }
        public GroupType GroupType { get; set; }
        public QuestionType QuestionType { get; set; }
        public int CountDecodTest { get; set; }
        public int CountEncodTest { get; set; }
    }
}
