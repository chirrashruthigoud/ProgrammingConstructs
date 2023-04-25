using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructor
{
    public class ProgrammingConstruct
    {
            public void Factorial()
            {
            
            Console.WriteLine("Enter a number:");
            int n =int.Parse(Console.ReadLine());
            int factorial = 1;
            for ( int i = 1; i <= n; i++)
            {
                factorial *=i;

                Console.WriteLine($"{n}!={factorial}.");
            }

            Console.ReadKey();  
            }
    }
 
}
