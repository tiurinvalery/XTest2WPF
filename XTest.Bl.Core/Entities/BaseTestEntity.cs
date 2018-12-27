using XTest.Bl.Core.Abstract.Entities;
using XTest.Bl.Core.Const.Enums;

namespace XTest.Bl.Core.Entities
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
