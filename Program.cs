/**
 Créer un nouveau projet Exercice41

Le programme doit permettre de saisir villes (après avoir saisi le nombre).
Au final, il faut afficher une seule fois le nom de chaque ville, suive de sa fréquence de saisie.
*/

using System;

namespace Exercice41
{
    class Program
    {
        //Création d'une structure au-dessus du Main qui va permettre de gérer le nom d'une ville et sa fréquence
        struct StrVille
        {
            public string nom;
            public int frequence;
        }

        static void Main(string[] args)
        {
            //Saisie du nombre de villes
            Console.Write("Saisir le nombre de ville : ");
            int nb = int.Parse(Console.ReadLine());

            //Déclaration d'une variable de structure StrVille
            StrVille[] lesVilles = new StrVille[nb];//La structure maximum est nb saisi au-dessus
            int nbVilles = 0;//Compteur du nombre de ville


            //Saisie des villes

            for (int i = 0; i < nb; i++)
            {
                //Saisie de la ville
                Console.Write("Saisir le nom de la ville n°" + (i + 1) + " : ");
                string ville = Console.ReadLine(); //Récupération de la ville afin de comparer l'existance dans la structure lesVilles
                //Recherche dans la structure
                int j = 0;
                while (j < nbVilles - 1 && ville != lesVilles[j].nom)
                {
                    j++;//On continue de scruter les noms déjà présents dans la structure lesVilles
                }
                if (ville == lesVilles[j].nom)//Ville déjà présente dans la structure
                {
                    lesVilles[j].frequence++; //Incrémentation de la fréquence de la ville déjà trouvée
                }
                else
                {
                    //Nouvelle ville à remplir
                    lesVilles[nbVilles].nom = ville; //Création de la nouvelle ville.
                    lesVilles[nbVilles].frequence = 1;//Initialisation de la fréquence à 1.
                    nbVilles++;// Nouvelle ville, incrémentation de nbVilles
                }
            }

            //Affichage des fréquences par ville
            Console.WriteLine();
            for (int i = 0; i < nbVilles; i++)
            {
                Console.WriteLine(lesVilles[i].nom + " apparait " + lesVilles[i].frequence + " fois.");
            }
            Console.ReadLine();
        }
    }

}


