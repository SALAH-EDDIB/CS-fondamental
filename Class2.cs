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

        months.ForEach(month => Console.WriteLine(month));

        months[7] = "August!";

        months.Insert(0, "month");

        months.RemoveAt(3);

        var FebruaryIndex = months.IndexOf("February");

        months.Sort();

        var newMonths = new List<string>(months);




    }




}
}

