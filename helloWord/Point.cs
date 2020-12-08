using System;

namespace helloWord
{
    public class Point
    {

        public int X;
        public int Y;

        public Point()
        {
        }

        public Point(int x , int y)
        {
            this.X = x; 
            this.Y = y;
        }

        public void move(int x , int y)
        {
            this.X = x;
            this.Y = y; 
        }

        public void move(Point newLocation )
        {

            if (newLocation == null)
                throw new ArgumentNullException("newLoaction" , "the location can't be null ");

            move(newLocation.X , newLocation.Y);
          
        }


    }


    }