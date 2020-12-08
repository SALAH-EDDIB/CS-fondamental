using System.Collections.Generic;
using System.Linq;

namespace Gestion_de_Stock
{
    public class Stock
    {

        List<Article> articles = new List<Article>();



        public void AddArticle(int refNumber, string name, float buyPrice, float sellPrice)
        {


            Article ithem = new Article(refNumber, name, buyPrice, sellPrice);

            articles.Add(ithem);


    

        }


        public void ShowArticles()
        {
            articles.ForEach(article => article.ArticleInfo());
        }


        public void find(string name)
        {
           Article article =  articles.Find(article => article.Name.Contains(name));

            if(article != null)
            article.ArticleInfo();

        }

        public void find(int refNumber)
        {
            Article article = articles.Find(article => article.RefNumber == refNumber);

            if (article != null)
                article.ArticleInfo();

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
