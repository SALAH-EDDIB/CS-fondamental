using System.Linq;

namespace Gestion_De_Comptes_Bancaires
{








    class Program
    {
        static void Main(string[] args)
        {


            Bank bank = new Bank();

            bank.AjouterCompteCarnet(1, "salah", 200 , 14);
            bank.AjouterCompteCheque(2, "salah eddib ", 200, 14 , 22);



            bank.comptes.ForEach(c => c.compteInfo());


            


           



        }
    }
}
