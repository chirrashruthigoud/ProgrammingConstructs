using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructor
{
    public class ProgrammingConstruct
    {
            public void WeekDays()
            {
            Console.WriteLine("Enter a Day:");
            int Day=int.Parse(Console.ReadLine());

                switch (Day)
                {
                    case 1:
                    Console.WriteLine("It is Monday.");
                     break;
                    case 2:
                    Console.WriteLine("It is Tuseday.");
                    break;
                    case 3:
                    Console.WriteLine("It is Wednesday.");
                    break;
                    case 4:
                    Console.WriteLine("It is Thusday.");
                    break;
                   case 5:
                    Console.WriteLine("It is Friday.");
                    break;
                    case 6:
                    Console.WriteLine("It is Saturday.");
                    break;
                    case 7:
                    Console.WriteLine("It is Sunday.");
                    break;
                   
                    default:
                        Console.WriteLine("Invalid Day");
                        break;
                }
            }
        }
    }
