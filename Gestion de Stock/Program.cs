namespace Gestion_de_Stock
{

    class Program
    {
        static void Main(string[] args)
        {

            Stock stock = new Stock();

            stock.AddArticle(1 ,"test 1" , 1.3f , 1.4f);
            stock.AddArticle(2, "test 2", 1.4f, 2.3f);
            stock.AddArticle(3, "test 3", 3.3f, 3.4f);
            stock.AddArticle(4, "test 4", 3.4f, 3.5f);

            

            stock.Edit(3, "test 3333", 3.4f, 5f);

            stock.ShowArticles();




        }
    }
}
