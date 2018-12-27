using System;
using System.Collections.Generic;
using System.Text;
using XTest.Core.Abstract.Entities;
using XTest.Core.Const.Enums;

namespace XTest.Core.Holders
{
    public static class TestHolder
    {
        public static ITestEntity CurrentTest { get; set; }

        public static TestType TestType { get; set; }//??
    }
}
