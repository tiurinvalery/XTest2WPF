using System;
using System.Collections.Generic;
using System.Text;

namespace XTest.Core.Abstract.Entities
{
    public interface IMarkEntity
    {
        string UserName { get; set; }
        int Mark { get; set; }
        double ExecutedPerent { get; set; }
    }


}
