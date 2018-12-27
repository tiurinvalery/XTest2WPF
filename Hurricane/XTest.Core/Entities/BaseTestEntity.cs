using Hurricane.XTest.Core.Abstract.Entities;
using Hurricane.XTest.Core.Const.Enums;

namespace Hurricane.XTest.Core.Entities
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
