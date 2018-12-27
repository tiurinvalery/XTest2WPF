using System;
using System.Collections.Generic;
using System.Text;
using XTest.Lang.Base.Abstract;
using XTest.Lang.Const.Enums;

namespace XTest.Lang.LanguageSet
{
    public class UALanguageSet : BaseLanguageSet, ILanguageSet
    {
        private static Language _language;
        
        private static string _path;

        private static Dictionary<Text, string> _data;

        static UALanguageSet()
        {
            Initialize();
        }

        public UALanguageSet() : base(_language, _data, _path) { }

        private static void Initialize()
        {
            _language = Language.UA;

            _data = new Dictionary<Text, string>
            {

            };
        }

    }
}
