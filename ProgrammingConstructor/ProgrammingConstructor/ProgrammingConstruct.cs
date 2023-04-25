using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructor
{
    public class ProgrammingConstruct
    {
        public void ChecktheNum()
        {
            Console.WriteLine("enter first Number:");
           int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number:");
            int z = Convert.ToInt32(Console.ReadLine());
            int largest;
            if (x>=y && x>=z)
            {
                largest = x;
            }
            else if(y>=x && y>=z)
            {
                largest = y;
            }else
            {
                largest = z;
            }
            Console.WriteLine("the largest is {0}.", largest);
            Console.ReadLine();
            
        }
    }
}
