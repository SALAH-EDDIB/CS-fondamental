using System.Collections.Generic;
using System.Linq;


namespace Gestion_De_Comptes_Bancaires
{
    public class Bank
    {

       public List<Compte> comptes = new List<Compte>();



       public void AjouterCompteCarnet(int numero, string nomProprietaire, float solde, int numéroCanret)

        {

            CompteSurCarnet compteCarnet = new CompteSurCarnet(numero, nomProprietaire, solde , numéroCanret);


            comptes.Add(compteCarnet) ;

        }


        public void AjouterCompteCheque(int numero, string nomProprietaire, float solde, int numéroChèque, int numéroCarte)

        {

            CompteSurCheque compteCheque = new CompteSurCheque(numero, nomProprietaire, solde, numéroChèque , numéroCarte);


            comptes.Add(compteCheque);

        }

        public void Supprimer(int numero)
        {
            comptes.Remove(comptes.SingleOrDefault(compte => compte.Numero == numero));
        }


        public void rechercher(int numero)
        {
            Compte compte = comptes.Find(compte => compte.Numero == numero);

            if (compte != null)
                compte.compteInfo();

        }

    }
}
