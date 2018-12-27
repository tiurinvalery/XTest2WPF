using System;
using System.Collections.Generic;
using System.Text;

namespace XTest.Core.Abstract.Entities
{
    public interface IQuestionAnswerEntity
    {
        IQuestionEntity Question { get; set; }
        string Answer { get; set; }
    }
}
