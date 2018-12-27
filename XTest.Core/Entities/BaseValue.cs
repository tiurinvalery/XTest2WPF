using System;
using System.Collections.Generic;
using System.Text;
using XTest.Core.Abstract.Entities;

namespace XTest.Core.Entities
{
   public class BaseValue : IBaseValue
    {
        public string Value { get; set; }
    }

    public class  MatrixValue : BaseValue, IMatrixValue
    {
       public string[][] Matrix { get; set; }
    }
}
