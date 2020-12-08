namespace Gestion_De_Comptes_Bancaires
{
    public abstract class Compte
    {

        public int Numero { get; set; }
        public string NomProprietaire { get; set; }
        public float Solde { get; set; }

        protected Compte(int numero, string nomProprietaire, float solde)
        {
            Numero = numero;
            NomProprietaire = nomProprietaire;
            Solde = solde;
        }


        public abstract void compteInfo();

        public abstract void Créditer(float somme);

        public abstract void Débiter(float somme);


    }
}
