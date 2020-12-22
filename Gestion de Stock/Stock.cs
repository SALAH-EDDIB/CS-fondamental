using System.Collections.Generic;
using System.Linq;
using System;


namespace Gestion_de_Stock
{
    public class Stock
    {

        List<Article> articles = new List<Article>();
        




        public void AddArticle(Article article)
        {

            articles.Add(article);

            Console.WriteLine("the Ithem Added successfully");

        }


        public void ShowArticles()
        {
            articles.ForEach(article => article.ArticleInfo());
        }


        public Article find(string name)
        {
            Article article =  articles.Find(article => article.Name.Contains(name));

            return article ;

        }

        public Article find(int refNumber)
        {
            Article article =  articles.Find(article => article.RefNumber == refNumber);

            return article ;

        }


        public void PriceGreater( float price)
        {

          List<Article>  newArticles =  articles.Where(article => article.BuyPrice > price).ToList();

            if (newArticles.Count > 0)
                newArticles.ForEach(article => article.ArticleInfo());
            else
                Console.WriteLine("no article with giving price ");



        }



        public void Delete(int refnumber)
        {
            if (articles.Remove(find(refnumber)))
                Console.WriteLine("Article deleted ");
            else
                Console.WriteLine("Article not found ");
        }






        public void Edit(int refNumber, string name, float buyPrice, float sellPrice)
        {

            Article article = find(refNumber);

            if (article != null)
            {
                article.Name = name;
                article.BuyPrice = buyPrice;
                article.SellPrice = sellPrice;

                article.ArticleInfo();
            }


        }


    }
}
