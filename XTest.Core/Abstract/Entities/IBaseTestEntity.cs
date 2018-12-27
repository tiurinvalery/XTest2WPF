using System;
using System.Collections.Generic;
using System.Text;
using XTest.Core.Const.Enums;

namespace XTest.Core.Abstract.Entities
{
    public interface IBaseTestEntity
    {
        string Name { get; set; }
        GroupType GroupType { get; set; }
        QuestionType QuestionType { get; set; }
        int CountDecodTest { get; set; }
        int CountEncodTest { get; set; }

    }
}
