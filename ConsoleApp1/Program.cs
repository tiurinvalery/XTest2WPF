using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> respons = new List<int> {233,234,231,5,7 ,999};

            List<string> results =
                respons.Select(p => p.ToString()).OrderByDescending(p => p).ToList();

            StringBuilder stringBuilder = new StringBuilder();

            foreach(var n in results)
            {
                stringBuilder.Append(n);
            }

            Console.WriteLine(stringBuilder);
            Console.ReadKey();
        }
    }
}
