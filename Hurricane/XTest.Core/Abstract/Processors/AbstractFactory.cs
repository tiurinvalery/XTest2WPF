using System.Collections.Generic;
using Hurricane.XTest.Core.Abstract.Entities;

namespace Hurricane.XTest.Core.Abstract.Processors
{
   public abstract class AbstractFactory
    {
        public abstract ICollection<IQuestionEntity> CreateCodeEllieas(int countQuestion);
        public abstract ICollection<IQuestionEntity> CreateCodeVarshamova(int countQuestion);
    }
}
