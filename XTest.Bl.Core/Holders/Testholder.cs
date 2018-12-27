using XTest.Bl.Core.Abstract.Entities;
using XTest.Bl.Core.Const.Enums;

namespace XTest.Bl.Core.Holders
{
    public static class TestHolder
    {
        public static ITestEntity CurrentTest { get; set; }

        public static TestType TestType { get; set; }//??
    }
}
