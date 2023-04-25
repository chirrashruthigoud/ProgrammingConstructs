using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructor
{
    public class ProgrammingConstruct
    {
        public void SumofNaturalnum()
        {
            int n = 5;
            int sum = 0;

            int i = 1;
            while(i <= n)
            {
                sum += i;
                i++;

            }
            Console.WriteLine($"the first natural {n}is : {sum}");
        }
    }
}
