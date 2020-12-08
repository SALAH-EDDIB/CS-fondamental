using System;

namespace Gestion_De_Comptes_Bancaires
{
    public class CompteSurCarnet : Compte
    {


        public int NuméroCanret { get; set; }
       

        public CompteSurCarnet(int numero, string nomProprietaire, float solde, int numéroCanret)
            : base(numero, nomProprietaire, solde)
        {
            NuméroCanret = numéroCanret;
            
        }

        public override void compteInfo()
        {

            Console.WriteLine("compte numero : " + Numero);
            Console.WriteLine("name : " + NomProprietaire);
            Console.WriteLine("solde : " + Solde + "DH");
            Console.WriteLine("numéro canret  : " + NuméroCanret);
            Console.WriteLine();


        }


        public override void Créditer(float somme)
        {
            Solde += somme;
        }

        public override void Débiter(float somme)
        {

            if (Solde >= somme && somme <= 10000)
            {
                Solde -= somme;
            }
            else if(somme > 10000) {
                Console.WriteLine(" Plafond dépassé");


            }
            else
            {
                Console.WriteLine(" Solde insuffisant ");
            }

        }


    }
}
