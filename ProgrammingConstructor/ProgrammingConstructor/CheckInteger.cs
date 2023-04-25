using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructor
{
    public class CheckInteger
    {
        int num_One;
        int num_Two;
        public void ChecktheNum()
           
        {
            Console.WriteLine("Enter the Number:");
            num_One=Convert.ToInt32(Console.ReadLine());
            num_Two=Convert.ToInt32(Console.ReadLine());

            if(num_One == num_Two)
            {
                Console.WriteLine("Number is equal.");
            }
            else
            {
                 Console.WriteLine("Number is not equal");
            }
        }
    }
}
