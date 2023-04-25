using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructor
{
    public class ProgrammingConstruct
    {
            public static double Calculate(double num_One, double num_Two, int Numresult)
            {
                double result = 0;

                switch (Numresult)
                {
                    case 1:
                        result = num_One + num_Two;
                        break;
                    case 2:
                        result = num_One - num_Two;
                        break;
                    case 3:
                        result = num_One * num_Two;
                        break;
                    case 4:
                        result = num_One / num_Two;
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }

                return result;
            }
        }
    }
