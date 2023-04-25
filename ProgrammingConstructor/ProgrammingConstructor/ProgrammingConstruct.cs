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
        public void ReverseString()
        {
            Console.WriteLine("enter a name");
            string name= Console.ReadLine();
            string xname = " ";

            int i = name.Length - 1;

            while(i>=0)
            {
                xname += name[i];
                i--;
            }
            Console.WriteLine($"reverse name is : {xname}");

        }
    }
}
