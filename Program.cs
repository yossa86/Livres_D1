using System.Runtime.CompilerServices;

using System;
using System.Collections.Generic;
using AppConsoleLivres_D1;

namespace Bibliotheque
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Création d'une liste générique de type Livre
            List<Livre> maBibliotheque = new List<Livre>();

            // Création d'objets de la classe Revue et Roman
            Revue revue1 = new Revue("Revue Science", "Dr. Smith", 50, 12, 2023);
            Revue revue2 = new Revue("Revue Histoire", "Dr. Brown", 40, 5, 2022);

            Roman roman1 = new Roman("Le Grand Voyage", "Jules Verne", 300, "Aventure");
            Roman roman2 = new Roman("Amour Impossible", "Jane Austen", 250, "Romance");

            // Ajout des objets à la liste
            maBibliotheque.Add(revue1);
            maBibliotheque.Add(revue2);
            maBibliotheque.Add(roman1);
            maBibliotheque.Add(roman2);

            // Parcours de la liste pour afficher les détails de chaque objet
            foreach (var livre in maBibliotheque)
            {
                livre.AfficherDetails();
                Console.WriteLine(); // Ajout de ligne vide pour séparer les détails des livres
            }
        }
    }
}
