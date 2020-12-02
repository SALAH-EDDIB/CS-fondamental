using System;
using System.Collections.Generic;

namespace helloWord
{


    class Program
    {


        static void Main(string[] args)
        {

            var months = new List<string>() { "January" , "February" , "March" , "April" , "May" , "June" , "July" , "August" , "September" , "October" , "November" , "December " };
            
            Console.WriteLine(months[5]);

            months.ForEach(month => Console.WriteLine(month));

            months[7] = "August!";

            months.Insert(0, "month");

            months.RemoveAt(3);

         var FebruaryIndex =   months.IndexOf("February");

            months.Sort();

            var newMonths = new List<string>(months);

            


        }




    }
}
