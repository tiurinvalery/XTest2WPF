using System;
using System.Collections.Generic;
using System.Linq;
using XTest.Lang.Base.Abstract;
using XTest.Lang.Const.Enums;
using XTest.Lang.Exceptions;

namespace XTest.Lang
{
    public static class LanguageManger
    {
        private static readonly ICollection<ILanguageSet> _languageSets;

        public static Language Language { get; set; }

        public static string GetText(Text text,
            TextType textType = TextType.Internal)
        {
            string GetInternal(Text internalText)
            {
                return _languageSets.FirstOrDefault
                    (x => x.Language == Language).GetText(internalText);
            }

            string GetExternal(Text externalText)
            {
                return _languageSets.FirstOrDefault
                    (x => x.Language == Language).GetStoredText(externalText);
            }

            switch (textType)
            {
                case TextType.Internal:
                    return GetInternal(text);

                case TextType.External:
                    return GetExternal(text);
            }

            throw new XTestLanguageException();
        }

    }
}
