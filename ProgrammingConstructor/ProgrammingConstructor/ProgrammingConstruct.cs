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
            int Mathsmarks, Pysicsmarks, Chemistrymarks, totalmarks;
            Console.WriteLine("Enter the Maths marks:");
            Mathsmarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Pysics marks:");
            Pysicsmarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Chemistry:");
            Chemistrymarks = Convert.ToInt32(Console.ReadLine());
            totalmarks = Mathsmarks + Pysicsmarks + Chemistrymarks;
            if (Mathsmarks >= 65 && Pysicsmarks >= 55 && Chemistrymarks >= 50 && totalmarks >= 180)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else if (Mathsmarks >= 65 && (Pysicsmarks >= 55 || Chemistrymarks >= 50) && (Mathsmarks + Pysicsmarks + Chemistrymarks >= 140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
            Console.ReadLine();
        }
    }
}
