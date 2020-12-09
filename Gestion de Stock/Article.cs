using System;

namespace Gestion_de_Stock
{
    public class Article
    {
        public int RefNumber { get; set; }
        public string Name  { get; set; }
        public float BuyPrice { get; set; }
        public float SellPrice { get; set; }


        public Article(int refNumber, string name, float buyPrice, float sellPrice)
        {
            RefNumber = refNumber;
            Name = name;
            BuyPrice = buyPrice;
            SellPrice = sellPrice;
            if (buyPrice > sellPrice)  throw new ArgumentException("the buy price should not be inferior to the selling price ");
        }

        public void ArticleInfo()
        {

            Console.WriteLine("refrence number : " + RefNumber);
            Console.WriteLine("name : " + Name);
            Console.WriteLine("buy price : " + BuyPrice);
            Console.WriteLine("sell price : " + SellPrice);
            Console.WriteLine();

        }






    }
}
