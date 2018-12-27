using System;
using System.Collections.Generic;
using System.Text;

namespace XTest.Core.Entities.History
{
   public class AnswerHistoryEntity
    {
        public string Answer { get; set; }

        public string UserAnswer { get; set; }

        public bool IsCorrect { get; set; }
    }
}
