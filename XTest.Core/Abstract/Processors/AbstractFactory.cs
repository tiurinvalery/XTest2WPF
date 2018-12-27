using System;
using System.Collections.Generic;
using System.Text;
using XTest.Core.Abstract.Entities;

namespace XTest.Core.Abstract.Processors
{
   public abstract class AbstractFactory
    {
        public abstract ICollection<IQuestionEntity> CreateCodeEllieas(int countQuestion);
        public abstract ICollection<IQuestionEntity> CreateCodeVarshamova(int countQuestion);
    }
}
