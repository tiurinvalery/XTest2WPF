using System;
using System.Collections.Generic;
using System.Text;

namespace XTest.Lang.Exceptions
{
    public class XTestLanguageException : Exception
    {
        public XTestLanguageException() 
            : this("Unknown language or language type.")
        {

        }

        public XTestLanguageException(string message) : base(message)
        {

        }
    }
}
