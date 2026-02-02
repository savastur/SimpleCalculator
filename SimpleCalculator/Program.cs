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
            //res = product, sum, qutient, or difference.
            float res, a, b;
            String signInput = "";
            string userInput = "";
            bool End = false;
            do
            {
                //Converst string into number 
                Console.WriteLine("Enter \"Q\" to quit.");
                Console.WriteLine("Press Enter to continue.");
                userInput = Console.ReadLine();
                

                try
                {

                    Console.WriteLine("Type First Number");
                    a = (float)Convert.ToDouble(Console.ReadLine()); //fisrt number 
                    Console.WriteLine("Type second number");
                    b = (float)Convert.ToDouble(Console.ReadLine()); //second number
                    //sign selection
                    Console.WriteLine("Slect Sign:(/,*,+,-)");
                    signInput = Console.ReadLine();


                    switch (signInput)
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
                }
                catch (Exception ex)
                {
                    if (userInput == "q" || userInput == "Q")
                    {
                        Console.WriteLine("Have a Nice Day!!");
                    }
                 
                }



            }
            while (!End);
            Console.Read();

        }

        private static int Consolereadline()
        {
            throw new NotImplementedException();
        }
    }
}