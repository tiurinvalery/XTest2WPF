using XTest.Bl.Core.Abstract.Entities;

namespace XTest.Bl.Core.Entities
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
