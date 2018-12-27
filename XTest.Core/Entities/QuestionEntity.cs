using System;
using System.Collections.Generic;
using System.Text;
using XTest.Core.Abstract.Entities;
using XTest.Core.Const.Enums;

namespace XTest.Core.Entities
{
    public class QuestionEntity : IQuestionEntity
    {
        public string Description { get; set; }
        public IBaseValue Question { get; set; }
        public IBaseValue Answer { get; set; }
        public StateType StateType { get; set; }
        public QuestionType QuestionType { get; set; }
        public CodeType CodeType { get; set; }
    }
}
