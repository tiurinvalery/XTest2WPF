using System;
using System.Collections.Generic;
using System.Text;
using XTest.Lang.Const.Enums;

namespace XTest.Lang.Base.Abstract
{
    public abstract class BaseLanguageSet : ILanguageSet
    {
        protected Language language;
        protected Dictionary<Text, string> data;
        protected string path;

        public BaseLanguageSet(Language language, 
            Dictionary<Text, string> data, string path)
        {
            this.language = language;
            this.data = data;
        }

        public Language Language => language;

        public string GetStoredText(Text text)
        {
            throw new NotImplementedException();
        }

        public string GetText(Text text)
        {
            return data[text];
        }
    }
}
