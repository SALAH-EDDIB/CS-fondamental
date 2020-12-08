using System;

namespace helloWord
{
    public class person
    {

        public DateTime BirthDate { set; get; }


       


        public int Age { 
            get
            {

              var timeSpan =   DateTime.Today - BirthDate;
              var years =   timeSpan.Days / 365;
                return years ;
            } 
        }

    } 


    }