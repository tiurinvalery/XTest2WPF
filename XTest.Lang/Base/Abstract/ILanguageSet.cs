using System;
using System.Collections.Generic;
using System.Text;
using XTest.Lang.Const.Enums;

namespace XTest.Lang.Base.Abstract
{
    public interface ILanguageSet
    {
        Language Language { get; }

        string GetText(Text text);
        string GetStoredText(Text text);
    }
}
