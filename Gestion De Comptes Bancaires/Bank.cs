using System.Collections.Generic;
using System.Linq;
using System;


namespace Gestion_De_Comptes_Bancaires
{
    public class Bank
    {

       public List<Compte> comptes = new List<Compte>();



       public void AjouterCompte(CompteSurCarnet compteCarnet)

        {


            comptes.Add(compteCarnet) ;

            Console.WriteLine(" le compte est ajouté ");

        }




        public void AjouterCompte(CompteSurCheque compteCheque)

        {

          

            comptes.Add(compteCheque);

            Console.WriteLine("le compte est ajouté");

        }



        public void AfficherList()
        {
            foreach (Compte compte in comptes)
            {
                compte.compteInfo();
            }
        }


        public void Supprimer(int numero)
        {
          bool isExist =   comptes.Remove(comptes.SingleOrDefault(compte => compte.Numero == numero));

            if(isExist)
                Console.WriteLine( "compte est supprimer ");
            else
                Console.WriteLine("le compte n'exist pas");


        }


        public void rechercher(int numero)
        {
            Compte compte = comptes.Find(compte => compte.Numero == numero);

            if (compte != null)
                compte.compteInfo();
            else
                Console.WriteLine("le compte n'exist pas");

        }

    }
}
