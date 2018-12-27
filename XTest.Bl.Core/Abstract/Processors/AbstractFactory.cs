using System.Collections.Generic;
using XTest.Bl.Core.Abstract.Entities;

namespace XTest.Bl.Core.Abstract.Processors
{
   public abstract class AbstractFactory
    {
        public abstract ICollection<IQuestionEntity> CreateCodeEllieas(int countQuestion);
        public abstract ICollection<IQuestionEntity> CreateCodeVarshamova(int countQuestion);
    }
}
