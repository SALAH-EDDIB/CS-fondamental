using System;

namespace Gestion_de_Stock
{

    class Program
    {

      

        

        static void Main(string[] args)
        {

            Stock stock = new Stock();

       /*   stock.AddArticle("test 1", 1.3f, 1.4f);
            stock.AddArticle("test 2", 1.4f, 2.3f);
            stock.AddArticle("test 3", 3.3f, 3.4f);
            stock.AddArticle("test 4", 3.4f, 3.5f);*/

            int action = StartAction() ;
            int refnumber = 0;
           

            while (action != 0)
            {

                try
                {
                    switch (action)
                    {

                        case (1):

                            Console.WriteLine(" Enter Item name ");
                            string name = Console.ReadLine();
                            Console.WriteLine(" Enter buy Price");
                            float buyPrice = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(" Enter sell price ");
                            float sellPrice = Convert.ToInt32(Console.ReadLine());
                            refnumber++;

                            Article ithem = new Article(  refnumber , name, buyPrice, sellPrice);

                            stock.AddArticle(ithem);

                            action = StartAction();

                            break;

                        case (2):

                            stock.ShowArticles();

                            action = StartAction();

                            break;


                        case (3):

                            Console.WriteLine(" Enter Item name Or refrence number ");
                            string value = Console.ReadLine();
                            int refNum;

                            bool isParse = Int32.TryParse(value, out refNum);

                            if (isParse)
                            {
                                Article article = stock.find(refNum);

                                if (article != null)
                                {
                                    article.ArticleInfo();
                                }
                                else
                                {
                                    Console.WriteLine("there is no item with the giving number");
                                }


                            }
                            else
                            {
                                Article article = stock.find(value);

                                if (article != null)
                                {
                                    article.ArticleInfo();

                                }
                                else
                                {
                                    Console.WriteLine("there is no item with the giving name");
                                }



                            }


                            action = StartAction();

                            break;

                        case (4):

                            Console.WriteLine(" Enter price");

                            float price = float.Parse(Console.ReadLine());

                            stock.PriceGreater(price);


                            action = StartAction();

                            break;



                        case (5):

                            Console.WriteLine(" Enter refrence number ");
                            value = Console.ReadLine();
                            isParse = Int32.TryParse(value, out refNum);

                            if (isParse)
                            {
                                stock.Delete(refNum);
                            }




                            action = StartAction();

                            break;


                        case (6):

                            Console.WriteLine(" Enter refrence number ");
                            value = Console.ReadLine();
                            isParse = Int32.TryParse(value, out refNum);

                            if (isParse)
                            {
                                Article article = stock.find(refNum);

                                if (article != null)
                                {
                                    Console.WriteLine(" Enter Item name ");
                                    name = Console.ReadLine();
                                    Console.WriteLine(" Enter buy Price");
                                    buyPrice = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine(" Enter sell price ");
                                    sellPrice = Convert.ToInt32(Console.ReadLine());

                                    stock.Edit(refNum, name, buyPrice, sellPrice);

                                }
                                else
                                {
                                    Console.WriteLine("there is no item with the giving number");
                                }






                            }







                            action = StartAction();

                            break;

                        default:

                            action = StartAction();

                            break;
                    }

                }catch(Exception e)
                {
                    Console.WriteLine( e.Message );
                }

            }







        }


        static int StartAction()
        {
            Console.WriteLine("******************************");
            Console.WriteLine(" Enter 1 to Add Item ");
            Console.WriteLine(" Enter 2 to View All  Items ");
            Console.WriteLine(" Enter 3 to find Items  ");
            Console.WriteLine(" Enter 4 to find Items whose purchase price is greater than an entered value. ");
            Console.WriteLine(" Enter 5 to Delete  Item");
            Console.WriteLine(" Enter 6 to Modify Item ");
            Console.WriteLine("******************************");




            int action;
            bool isAction = Int32.TryParse(Console.ReadLine() , out action  );

            if (isAction)
            {
                return action;
            }
            else{
                return -1;
            }



            




        }

    }





 

}
