using System;

namespace heritage
{



    public class Animal
    {

        public string Name {  get;  set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public Animal(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public void Eat()
        {

            Console.WriteLine( " {0} is eating " , Name );

        }

        public   void Sleep()
        {

            Console.WriteLine(" {0} is sleeping ", Name);

        }




    }


    public class Cat : Animal
    {

        public int ACatThing { get; set; }

        public Cat(string name, int age, string color)
            : base(name , age , color)
        {

        }

    }


   






    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("tom", 15, "gray");

            cat.Eat();
        }
    }
}
