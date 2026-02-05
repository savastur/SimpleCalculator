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
            float result, firstNumber, secondNumber;
            String signInput = "";
            string userInput = "";
            bool End = false;
            do
            {
                Console.WriteLine("Enter \"Q\" to quit.");
                Console.WriteLine("Press Enter to continue.");
                userInput = Console.ReadLine();
                

                try
                {

                    //Converts string into number 
                    Console.WriteLine("Type First Number");
                    firstNumber = (float)Convert.ToDouble(Console.ReadLine()); //fisrt number 
                    Console.WriteLine("Type second number");
                    secondNumber = (float)Convert.ToDouble(Console.ReadLine()); //second number
                    //sign selection
                    Console.WriteLine("Slect Sign:(/,*,+,-)");
                    signInput = Console.ReadLine();


                    switch (signInput)
                    {
                        case "/":
                            result = firstNumber / secondNumber;
                            Console.WriteLine("Result:" + result);
                            Console.WriteLine($" {result = firstNumber / secondNumber};");

                            break;
                        case "+":
                            result = firstNumber + secondNumber;
                            Console.WriteLine("Result:" + result);
                            Console.WriteLine($"{result = firstNumber + secondNumber}");
                            break;
                        case "-":
                            result = firstNumber - secondNumber;
                            Console.WriteLine("Result:" + result);
                            Console.WriteLine($"{result = firstNumber - secondNumber}");
                            break;
                        case "*":
                            result = firstNumber * secondNumber;
                            Console.WriteLine("Result:" + result);
                            Console.WriteLine($"{result = firstNumber * secondNumber}");
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