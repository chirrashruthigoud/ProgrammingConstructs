using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructor
{
    public class ProgrammingConstruct
    {
            public void Table()
            {
            int i;
            Console.WriteLine("Enter a number:");
            int n =int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine($"table of 3*{i}={3*i}");
            }

            Console.ReadKey();  
            }
        }
    }
