using System;
using Into;

namespace begin
{
    class Program
   {
        static void Main(string[] args)
        {
        fromstart:
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("choose the condtion + or - or / or *");
            string condtion = Console.ReadLine();
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if(condtion == "*")
            {
                Console.WriteLine(string.Concat("The result is : ",num1 * num2));
            } else if(condtion == "/")
            {
                Console.WriteLine(string.Concat("The result is : ", num1 / num2));
            } else if(condtion == "+")
            {
                Console.WriteLine(string.Concat("The result is : ", num1 + num2));
            } else if(condtion == "-")
            {
                Console.WriteLine(string.Concat("The result is : ", num1 - num2));
            }
            else
            {
                Console.WriteLine("No condtion was found :)\r\n");
            }
            Console.WriteLine("Again ?");
            if(Console.ReadLine().ToLower() == "y")
            {
                Console.Clear();
                goto fromstart;
            }
        }
    }
}
