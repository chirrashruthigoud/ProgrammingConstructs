using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructor
{
    public class ProgrammingConstruct
    {
        public void FlipCoin()
        {
            Random random = new Random();
            int headcount = 0;
            int tailscount = 0;

            while (headcount > 20 && tailscount > 20)
            {
                int result = random.Next(2);
                if (result == 0)
                {
                    Console.WriteLine("heads");
                    headcount++;
                }
                else
                {
                    Console.WriteLine("tails ");
                    tailscount++;
                }

            }
            if(headcount == 20)
            {
              Console.WriteLine("heads win");
            }
            else
            {
              Console.WriteLine("Tails win");
            }
            
        }
    }
}
