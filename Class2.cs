using System;








namespace helloWord
{
    class Program
    {


        static void calculTtc(string productName, float price)

        {

            float ttc;
            const float TVA = 0.19f;

            ttc = price + (price * TVA);
            Console.WriteLine("Le prix du " + productName + " TTC est de " + ttc + " DH");

        }


        static void Main(string[] args)
        {


            float newPrice;

            try
            {
                Console.WriteLine("Enter product name  :");
                string productName = Console.ReadLine();
                Console.WriteLine("Enter " + productName + " price  :");
                string price = Console.ReadLine();
                newPrice = Convert.ToInt64(price);
                calculTtc(productName, newPrice);

            }
            catch (Exception e)
            {
                Console.WriteLine(" price need to be a number ");
            }

        }
    }
}














class Program
{

    static void Main(string[] args)
    {

        float number1 = 1;



        for (var num = 200; num > 0; num -= 15)
        {


            Console.Write(num);
            Console.WriteLine("enfin !!! ");


        }



        while (number1 < 10)
        {

            number1 += number1 / 2;
            Console.WriteLine(number1);


        }





    }





}























class Program
{


    static void Main(string[] args)
    { 

        var months = new List<string>() { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December " };

        Console.WriteLine(months[5]);

        months.ForEach(month  => Console.WriteLine(month));

        months[7] = "August!";

        months.Insert(0, "month");

        months.RemoveAt(3);

        var FebruaryIndex = months.IndexOf("February");

        months.Sort();

        var newMonths = new List<string>(months);



    }



}
}





















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
