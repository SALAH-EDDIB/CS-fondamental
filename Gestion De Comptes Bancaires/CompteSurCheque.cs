using System;

namespace Gestion_De_Comptes_Bancaires
{
    public class CompteSurCheque : Compte {


        public int NuméroChèque { get; set; }
        public int NuméroCarte { get; set; }

        public CompteSurCheque(int numero, string nomProprietaire, float solde , int numéroChèque, int numéroCarte)
            :base(  numero ,  nomProprietaire  , solde)
        {
            NuméroChèque = numéroChèque;
            NuméroCarte = numéroCarte;
        }

        public override void compteInfo()
        {

            Console.WriteLine("compte numero : " + Numero);
            Console.WriteLine("name : " + NomProprietaire);
            Console.WriteLine("solde : " + Solde + "DH");
            Console.WriteLine("numéro Chèque  : " + NuméroChèque);
            Console.WriteLine("numéro carte: " + NuméroCarte);
            Console.WriteLine();


        }


        public override void Créditer(float somme)
        {
            Solde += somme;
        }

        public override void Débiter(float somme)
        {

            if(Solde >= somme)
            {
                Solde -= somme;
            }
            else
            {
                Console.WriteLine(" Solde insuffisant ");
            }

        }


    }
}
