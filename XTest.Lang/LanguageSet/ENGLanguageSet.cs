using System;
using System.Collections.Generic;
using System.Text;
using XTest.Lang.Base.Abstract;
using XTest.Lang.Const.Enums;

namespace XTest.Lang.LanguageSet
{
    public class ENGLanguageSet : BaseLanguageSet, ILanguageSet
    {
        private static Language _language;

        private static Dictionary<Text, string> _data;

        private static string _path;

        public ENGLanguageSet() : base(_language, _data, _path)
        {

        }

        static ENGLanguageSet()
        {
            Initialize();
        }

        private static void Initialize()
        {
           // _language = Language.ENG;

            _data = new Dictionary<Text, string>
            {

            };
        }
    }
}
