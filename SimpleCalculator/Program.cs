using System.Collections;
//Sturm Savage
//RCET2265
//Spring Semester
//https://github.com/savastur/SimpleCalculator.git
namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type First Number");
            int res, a, b;
            String SignInput = "";

            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Slect Sign:(/,*,+,-)");


            SignInput = Console.ReadLine();
            switch (SignInput)
            {
                                case "/":
                    res = a / b;
                    Console.WriteLine("Result:" + res);
                    Console.WriteLine($" {res = a / b};"); 
                    
                    break;
                case "+":
                    res = a + b;
                    Console.WriteLine("Result:" + res); 
                    Console.WriteLine($"{res = a + b}");
                    break;
                    case "-":
                    res = a - b;
                    Console.WriteLine("Result:" + res); 
                    Console.WriteLine($"{res = a - b}");
                    break;
                case "*":
                    res = a * b;
                    Console.WriteLine("Result:" + res); 
                    Console.WriteLine($"{res = a * b}");
                    break;
            }
            Console.Read();

            }

            
          
            




           
        

        private static int Consolereadline()
        {
            throw new NotImplementedException();
        }
    }
}
