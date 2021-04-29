using System;
using System.Collections.Generic;
using LoupGarou;

namespace TestLogique
{
    public class Program
    {
        static void Main(string[] args)
        {
            Jeu G1 = new Jeu();

            /*foreach(Role element in G1.lesRoles)
            {
                Console.WriteLine(element.leDescriptif);
            }*/
            Joueur j1 = new Joueur("Lulu", 1);
            Joueur j2 = new Joueur("Boun", 2);
            Joueur j3 = new Joueur("Smuel", 3);
            Joueur j4 = new Joueur("Lilou", 4);
            Joueur j5 = new Joueur("Shreyk", 5);
            Joueur j6 = new Joueur("Gloire", 6);

            G1.lesJoueurs.Add(1, j1);
            G1.lesJoueurs.Add(2, j2);
            G1.lesJoueurs.Add(3, j3);
            G1.lesJoueurs.Add(4, j4);
            G1.lesJoueurs.Add(5, j5);
            G1.lesJoueurs.Add(6, j6);

            G1.attribuerDesRoles();
            foreach (KeyValuePair<int, Joueur> joueur in G1.lesJoueurs)
            {
                Console.WriteLine(joueur.Key + " -> " + joueur.Value.leLogin + "   " + joueur.Value.leRole.leLibelle + " = " + joueur.Value.leRole.leDescriptif);
                if (joueur.Value.leRole.leLibelle == "Loup garou")
                {
                    G1.lesLoupsGarous.Add(joueur.Key, joueur.Value);
                }
                else if (joueur.Value.leRole.leLibelle == "Villageois")
                {
                    G1.lesVillageois.Add(joueur.Key, joueur.Value);
                }
                else
                {
                    Console.WriteLine("Erreur");
                }
            }

            /*foreach (KeyValuePair<int, Joueur> element in G1.lesLoupsGarou)
            {
                Console.WriteLine(element.Key + " " + element.Value.leRole.leLibelle);
            }*/

            /*foreach (KeyValuePair<int, Joueur> element in G1.lesVillageois)
            {
                Console.WriteLine(element.Key + " " + element.Value.leRole.leLibelle);
            }*/

            G1.init();

            G1.setlaNarration(0);
            Console.WriteLine("\n" + G1.laNarration);

            Jour Jour1 = new Jour();


            G1.setlaNarration(1);
            Console.WriteLine("\n" + G1.laNarration + "\n");

            G1.activerDesactiver(G1.lesLoupsGarous, true);

            foreach (KeyValuePair<int, Joueur> element in G1.lesLoupsGarous)
            {
                Console.WriteLine("Joueurs n° "+element.Key + " " +" est un "+ element.Value.leRole.leLibelle + " : " + element.Value.estActif);
            }

            G1.setlaNarration(4);

            for (int i = 1; i < G1.lesLoupsGarous.Count + 1; i++)
            {
                G1.voter(i);
                G1.verifierVote(i);
                G1.validationVote();
            }

            G1.MAJlesJoueurs();

            G1.initVote();

            G1.setlaNarration(3);
            Console.WriteLine("\n" + G1.laNarration + "\n");

            G1.verifierGagnant();

            G1.activerDesactiver(G1.lesJoueursActifs, true);

            G1.setlaNarration(4);
            Console.WriteLine("\n" + G1.laNarration + "\n");

            for (int i = 1; i < G1.lesVillageois.Count + 1; i++)
            {
                G1.voter(i);
                G1.verifierVote(i);
                G1.validationVote();
            }
            G1.setlaNarration(4);
            Console.WriteLine("\n" + G1.laNarration + "\n");

            G1.MAJlesJoueurs();

        }
    }
}
