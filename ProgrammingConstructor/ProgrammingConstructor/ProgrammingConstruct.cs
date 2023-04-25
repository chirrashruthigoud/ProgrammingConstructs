using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructor
{
    public class ProgrammingConstruct
    {
        int num;
        public void ChecktheNum()
        {
            Console.WriteLine("Enter the Number:");
            num=Convert.ToInt32(Console.ReadLine());

            if(num%2 ==0)
            {
                Console.WriteLine("Number is even.");
            }
            else
            {
                 Console.WriteLine("Number is odd.");
            }
        }
    }
}
