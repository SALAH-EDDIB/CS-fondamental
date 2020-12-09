using System.Collections.Generic;
using System.Linq;

namespace Gestion_de_Stock
{
    public class Stock
    {

        List<Article> articles = new List<Article>();
        int refNum = 0;




        public Article AddArticle( string name, float buyPrice, float sellPrice)
        {

            refNum++;

            Article ithem = new Article( refNum , name, buyPrice, sellPrice);

            articles.Add(ithem);

            return ithem;


    

        }


        public void ShowArticles()
        {
            articles.ForEach(article => article.ArticleInfo());
        }


        public Article find(string name)
        {
           Article article =  articles.Find(article => article.Name.Contains(name));

           
               return article;



        }

        public Article find(int refNumber)
        {
            Article article = articles.Find(article => article.RefNumber == refNumber);

            return article;

        }


        public void PriceGreater( float price)
        {

          List<Article>  newArticles =  articles.Where(article => article.BuyPrice > price).ToList();

            if (newArticles.Count > 0)
                newArticles.ForEach(article => article.ArticleInfo());


        }

        public void Delete(int refnumber)
        {
            articles.Remove(articles.SingleOrDefault(article => article.RefNumber == refnumber));
        }


        public void Edit(int refNumber, string name, float buyPrice, float sellPrice)
        {

            Article article = articles.Find(article => article.RefNumber == refNumber);

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
