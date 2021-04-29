using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou
{
    public class Jeu
    {
        public string laNarration;
        public Dictionary<int, Joueur> lesJoueurs = new Dictionary<int, Joueur>();
        public Dictionary<int, Joueur> lesJoueursEnBallotage = new Dictionary<int,
        Joueur>();
        public Dictionary<int, Joueur> lesJoueursActifs = new Dictionary<int, Joueur>();
        public Dictionary<int, Joueur> lesLoupsGarous = new Dictionary<int, Joueur>();
        public Dictionary<int, Joueur> lesVillageois = new Dictionary<int, Joueur>();
        public List<Role> lesRoles = new List<Role>();
        public List<Jour> lesJours = new List<Jour>();
        public Jour leJourEnCour;
        public Joueur leMaire;

        public Jeu()
        {
            Role R1 = new Role("Villageois", "Vous faîtes parti(e) des membres du village.");
            lesRoles.Add(R1);
            Role R2 = new Role("Loup garou", "Vous faîtes parti(e) des loups garou.");
            lesRoles.Add(R2);
            Role R3 = new Role("Maire", "Vous devrez trancher si les votes villageois sont ex aequo.");
            lesRoles.Add(R3);
            /*Début
            * Copier les éléments clé/valeur de lesJoueurs dans lesJoueursActifs
            * Fin
            */
        }

        public void init()
        {

            foreach(KeyValuePair<int,Joueur> element in lesJoueurs)
            {
                lesJoueursActifs.Add(element.Key, element.Value);
            }
        }

        public void activerDesactiver(Dictionary<int, Joueur> laListe, bool etat)
        {

            foreach(KeyValuePair<int,Joueur> element in laListe)
            {
                element.Value.estActif = etat;
            }
        }

        public void attribuerDesRoles()
         {

            Dictionary<int, Joueur> temp = new Dictionary<int, Joueur>();
            Random _Random = new Random();
            int Aleatoire;
            int nbreLoup;
            int nbreVillageois;
            int nbreJoueurs;

            foreach(KeyValuePair<int,Joueur> element in lesJoueurs)
            {
                temp.Add(element.Key, element.Value);
            }

            nbreVillageois = lesJoueurs.Count / 2 + 1;
            nbreLoup = lesJoueurs.Count - nbreVillageois;
            nbreJoueurs = lesJoueurs.Count;

            for (int i = 0; i < nbreVillageois; i++)
            {
                Aleatoire = _Random.Next(0, nbreJoueurs);
                lesJoueurs[temp.ElementAt(Aleatoire).Key].leRole = lesRoles[0];
                temp.Remove(temp.ElementAt(Aleatoire).Key);
                nbreJoueurs = nbreJoueurs - 1;
            }

            for (int i = 0; i < nbreLoup; i++)
            {
                Aleatoire = _Random.Next(0, nbreJoueurs);
                lesJoueurs[temp.ElementAt(Aleatoire).Key].leRole = lesRoles[1];
                temp.Remove(temp.ElementAt(Aleatoire).Key);
                nbreJoueurs = nbreJoueurs - 1;
            }
        }

        public void setlaNarration(int option)
        {

            switch (option)
            {
                case 0: laNarration = "<--- Début du jeu --->";
                    break;

                case 1: laNarration = "<--- 1er Jour -->";
                    break;

                case 2: laNarration = "<--- La nuit arrive --->\n<-- Le village s'endort -->";
                    break;

                case 3: laNarration = "<--- Le jour se lève --->\n<-- Le village se réveille -->";
                    break;

                case 4: laNarration = "Texte pour voter";
                    break;

                case 5: laNarration = "Texte pour annoncer le résultat du vote général";
                    break;

                case 6: laNarration = "Texte pour annoncer le ou les morts";
                    break;

                case 7: laNarration = "Texte pour annoncer le vote du maire";
                    break;

                case 8: laNarration = "Texte de fin de jeu";
                    break;
            }
        }

        public void voter(int choix)
        {

            if (lesJoueursEnBallotage.ContainsKey(choix))
            {
                lesJoueursEnBallotage[choix].leNbrVote = lesJoueursEnBallotage[choix].leNbrVote + 1;
            }
            else
            {
                lesJoueursEnBallotage.Add(choix, lesJoueursActifs[choix]);
                lesJoueursEnBallotage[choix].leNbrVote = lesJoueursEnBallotage[choix].leNbrVote + 1;
            }
        }
        public bool verifierVote(int choix)
        {

            bool result = false;
            if (validationVote() != 0)
            {
                result = true;
            }
            return result;
        }

        public int validationVote()
        {

            int result = 0;
            for(int i = 0; i < lesJoueursEnBallotage.Count; i++)
            {
                if (result < lesJoueursEnBallotage.ElementAt(i).Value.leNbrVote)
                {
                    result = lesJoueursEnBallotage.ElementAt(i).Value.leNbrVote;
                    if (i > 0)
                    {
                        lesJoueursEnBallotage.Remove(lesJoueursEnBallotage.ElementAt(i - 1).Key);
                    }
                    else if (result > lesJoueursEnBallotage.ElementAt(i).Value.leNbrVote)
                    {
                        lesJoueursEnBallotage.Remove(lesJoueursEnBallotage.ElementAt(i).Key);
                    }
                }
            }
            if (lesJoueursEnBallotage.Count == 1)
            {
                result=lesJoueursEnBallotage.ElementAt(0).Key;
            }
            else
            {
                result = 0;
            }
            return result;
        }

        public bool verifierGagnant()
        {
            bool result = false;
            if (lesLoupsGarous.Count==0 || lesVillageois.Count == 0)
            {
                result = true;
            }
            return result;
        }

        public void MAJlesJoueurs()
        {
             for (int i = 0; i < lesLoupsGarous.Count; i++) {
                lesLoupsGarous.Remove(i);
            }
            for (int i = 0; i < lesVillageois.Count; i++)
            {
                lesLoupsGarous.Remove(i);
            }
            foreach(KeyValuePair<int, Joueur> element in lesJoueursActifs)
            {
                if (element.Value.leRole == lesRoles[0] || element.Value.leRole == lesRoles[1])
                {
                    if(!lesVillageois.ContainsKey(element.Key))//A rajouter pour éviter les erreurs
                    lesVillageois.Add(element.Key, element.Value);
                }
                else
                {
                    lesLoupsGarous.Add(element.Key, element.Value);
                }
            }
        }

        public void initVote()
        {
           if (validationVote() != 0)
           {
                lesJoueurs[validationVote()].estActif = false;
                lesJoueurs[validationVote()].estMort = true;
                lesJoueursActifs.Remove(validationVote());
                MAJlesJoueurs();
            }
            for (int i = 0; i < lesJoueursEnBallotage.Count; i++)
            {
                lesJoueursEnBallotage.Remove(i);
            }

            for(int i=0; i < lesJoueursActifs.Count;i++)
            {
                lesJoueursActifs.ElementAt(i).Value.leNbrVote = 0;
            }
        }
    }
}
