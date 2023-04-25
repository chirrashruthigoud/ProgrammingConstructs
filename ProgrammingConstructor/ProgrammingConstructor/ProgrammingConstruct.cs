using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructor
{
    public class ProgrammingConstruct
    {
            public void SumOfquares()
            {
            int i;
            Console.WriteLine("Enter a number:");
            int n =int.Parse(Console.ReadLine());
            int sumofsquare = 0;
            for (i = 1; i <= n; i++)
            {
                sumofsquare=i*i;

                Console.WriteLine($"The sum of squares numbers {n} start of {i} is {sumofsquare}.");
            }

            Console.ReadKey();  
            }
    }
 
}
