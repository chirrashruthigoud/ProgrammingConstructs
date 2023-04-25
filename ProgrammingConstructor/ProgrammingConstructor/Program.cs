namespace ProgrammingConstructor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*ProgrammingConstruct num=new ProgrammingConstruct();
             num.ChecktheNum();
             Console.ReadLine();*/
            Console.WriteLine("Enter first number:");
            double num_One = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double num_Two = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation (press 1 for addition, 2 for substraction, 3 for multiplication, 4 for division):");
            int Numresult = int.Parse(Console.ReadLine());

            double result = ProgrammingConstruct.Calculate(num_One, num_Two, Numresult);

            Console.WriteLine("Result: " + result);
        }
    }
}