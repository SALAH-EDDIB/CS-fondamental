using System;

namespace helloWord
{
    public abstract class PresentationObject
    {
        public int Width { get; set; }
        public int Heigth { get; set; }


        public abstract void Copy();
      

        public void Duplicate()
        {
            Console.WriteLine("object was duplicate !");
        }


    }

        


    }