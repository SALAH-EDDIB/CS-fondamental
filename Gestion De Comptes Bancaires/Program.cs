using System;
using System.Linq;

namespace Gestion_De_Comptes_Bancaires
{








    class Program
    {
        static void Main(string[] args)
        {







            Bank bank = new Bank();




            int action = StartAction();
            int number = 0;






            while (action != 0)
            {

                try
                {
                    switch (action)
                    {

                        case (1):

                            Console.WriteLine(" Enter nom Proprietaire  ");
                            string nomProprietaire = Console.ReadLine();
                            Console.WriteLine(" Enter solde ");
                            float solde = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(" Enternuméro Canret ");
                            int numéroCanret = Convert.ToInt32(Console.ReadLine());
                            number++;

                            CompteSurCarnet compteCarnet = new CompteSurCarnet(number, nomProprietaire, solde, numéroCanret);

                            bank.AjouterCompte(compteCarnet);


                            action = StartAction();

                            break;

                        case (2):


                            Console.WriteLine(" Enter nom Proprietaire  ");
                             nomProprietaire = Console.ReadLine();
                            Console.WriteLine(" Enter solde ");
                             solde = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(" Enter numéro chéque ");
                            int numéroChèque = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(" Enter numéro chéque ");
                            int numéroCarte = Convert.ToInt32(Console.ReadLine());
                            number++;

                            CompteSurCheque compteCheque = new CompteSurCheque(number, nomProprietaire, solde, numéroChèque, numéroCarte);

                            bank.AjouterCompte(compteCheque);


                            action = StartAction();

                            break;


                        case (3):

                            Console.WriteLine(" Enter le compte numero ");
                            int value = Convert.ToInt32(Console.ReadLine());
                            bank.rechercher(value);
 
                            action = StartAction();

                            break;

                        case (4):

                            Console.WriteLine(" Enter le compte numero ");
                             value = Convert.ToInt32(Console.ReadLine());

                            bank.Supprimer(value);

                            action = StartAction();

                            break;




                        default:

                            action = StartAction();

                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }




bank.comptes.ForEach(c => c.compteInfo());


        }


       



            



                static int StartAction()
        {
            Console.WriteLine("******************************");
            Console.WriteLine(" Enter 1 pour Ajouter Compte Carnet ");
            Console.WriteLine(" Enter 2 pour Ajouter Compte Cheque ");
            Console.WriteLine(" Enter 3 pour rechercher ");
            Console.WriteLine(" Enter 4 pour suprimer");
            Console.WriteLine("******************************");




            int action;
            bool isAction = Int32.TryParse(Console.ReadLine(), out action);

            if (isAction)
            {
                return action;
            }
            else
            {
                return -1;
            }








        }














    }








}





