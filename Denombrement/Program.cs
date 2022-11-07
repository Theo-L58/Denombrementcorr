/**
 * titre:
 * description:
 * auteur:
 * date création:
 * date dernière modif:
 */
using System;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// application qui permet de faire le dénombrement
        /// </summary>
        /// <param name="args">signifie qu'on est dans le module principal, pris en compte</param>
        static void Main(string[] args)
        {
            int c = 1;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());

                if (c == 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    //saisie du nombre d'éléments à gérer
                    Console.Write("nombre total d'éléments à gérer = ");
                    int totalElement = int.Parse(Console.ReadLine());
                    long result = 1, result1 = 1, result2 = 1;
                    if (c == 1)
                    {
                        // calcul de r
                        for (int k = 1; k <= totalElement; k++)
                        {
                            result *= k;
                        }
                        Console.WriteLine(totalElement + "! = " + result);
                    }
                    else
                    {
                        // Saisie du nombre d'éléments dans le sous ensemble
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int nbreSousEnsemble = int.Parse(Console.ReadLine());
                        if (c == 2)
                        {
                            // calcul de r
                            for (int k = (totalElement - nbreSousEnsemble + 1); k <= totalElement; k++)
                            {
                                result *= k;
                            }
                            // affichage du résultat
                            Console.WriteLine("A(" + totalElement + "/" + nbreSousEnsemble + ") = " + result);
                        }
                        else
                        {
                            // calcul de r1
                            for (int k = (totalElement - nbreSousEnsemble + 1); k <= totalElement; k++)
                            {
                                result1 *= k;
                            }
                            // calcul de r2
                            for (int k = 1; k <= nbreSousEnsemble; k++)
                            {
                                result2 *= k;
                            }
                            // Affihage du resultat
                            Console.WriteLine("C(" + totalElement + "/" + nbreSousEnsemble + ") = " + (result1 / result2));
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
