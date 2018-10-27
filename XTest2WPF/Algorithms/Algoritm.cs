using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTest2WPF.Algorithms
{
    interface Algoritm
    {
        AlgoritmDTO code(AlgoritmDTO dto);

        AlgoritmDTO decode(AlgoritmDTO dto);
    }
}
