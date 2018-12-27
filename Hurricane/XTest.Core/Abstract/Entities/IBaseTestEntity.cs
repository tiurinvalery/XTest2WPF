using Hurricane.XTest.Core.Const.Enums;

namespace Hurricane.XTest.Core.Abstract.Entities
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
