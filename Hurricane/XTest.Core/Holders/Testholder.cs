using Hurricane.XTest.Core.Abstract.Entities;
using Hurricane.XTest.Core.Const.Enums;

namespace Hurricane.XTest.Core.Holders
{
    public static class TestHolder
    {
        public static ITestEntity CurrentTest { get; set; }

        public static TestType TestType { get; set; }//??
    }
}
