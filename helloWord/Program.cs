using System;
using System.Collections.Generic;

namespace helloWord
{

    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Enter 1st number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the action to be performed");
            string action = Console.ReadLine();
            int result = 0;
            switch (action)
            {
                case "+":
                    {
                        result = Addition(number1, number2);
                        break;
                    }
                case "-":
                    {
                        result = Subtraction(number1, number2);
                        break;
                    }
                case "*":
                    {
                        result = Multiplication(number1, number2);
                        break;
                    }
                case "/":
                    {
                        result = Division(number1, number2);
                        break;
                    }
                case "%":
                    {
                        result = euclidienne(number1, number2);
                        break;
                    }
                case "q":
                    {
                        Environment.Exit(0);
                        break;
                    }
                default:
                    Console.WriteLine("the action is wrong try again  ");
                    break;
            }
            Console.WriteLine("The result is {0}", result);

        }
        //Addition  
        public static int Addition(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }
        //Substraction  
        public static int Subtraction(int number1, int number2)
        {
            int result = number1 - number2;
            return result;
        }
        //Multiplication  
        public static int Multiplication(int number1, int number2)
        {
            int result = number1 * number2;
            return result;
        }
        //Division  
        public static int Division(int number1, int number2)
        {
            int result = number1 / number2;
            return result;
        }
        public static int euclidienne(int number1, int number2)
        {
            int result = number1 % number2;
            return result;
        }





    }
}


