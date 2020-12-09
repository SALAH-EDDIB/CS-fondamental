using System;

namespace heritage
{


    public class Animal
    {

        public string Name { get ;   set; }
        public string Color { get; set; }
        public int Age { get  ; set; }

        public Animal(string name, string color, int age)
        {
            Name = name;
            Color = color;
            Age = age;
        }


        public void Eat()
        {
            Console.WriteLine("{0} is eating" , Name) ;
        }

        public void Sleep()
        {
            Console.WriteLine("{0} is sleeping", Name);
        }

    }


    public sealed class Bengal : Cat
    {
        private int max_age;

        public Bengal(int time_life)
            : base("tom", "red", 13  , "catTing")
        { max_age = time_life; }
    }


    public class Cat : Animal
    {

        public string CatThing { get ; set; }

       


        public Cat(string name, string color, int age , string catThing)
            :base( name , color , age )
        {

            CatThing = catThing ;

        }





    }

 



    


    class Program
    {
        static void Main(string[] args)
        {



            Cat cat = new Cat("tom", "grey", 12, "cat thing");

            cat.Sleep();



        }
    }
}
