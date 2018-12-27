using Hurricane.XTest.Core.Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane.XTest.Core.Entities
{
    public class TestAnswerEntity : ITestAnswerEntity
    {
        //string UserName { get; set; }
       public int AllCount { get; set; }
       public int CurrentCount { get; set; }
       public string NameTest { get; set; }
     //  public //ICollection<IQuestionEntity> Answers { get; set; }
       public IBaseValue Answer { get; set; }
       public IQuestionEntity QuestionEntity { get; set; }
    }
}
