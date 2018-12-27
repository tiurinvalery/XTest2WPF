using XTest.Bl.Core.Const.Enums;

namespace XTest.Bl.Core.Abstract.Entities
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
