using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructor
{
    public class ProgrammingConstruct
    {
        int age;
        public void ChecktheNum()
        {
            Console.WriteLine("Enter the Number:");
            age=Convert.ToInt32(Console.ReadLine());

            if(age>=18)
            {
                Console.WriteLine("Candidate Eligible to Vote.");
            }
            else
            {
                 Console.WriteLine("Candidate Not Eligible to Vote.");
            }
        }
    }
}
