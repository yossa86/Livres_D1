using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres_D1
{
    // 1 Attributs de la classe Livre
    internal class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int NombrePages { get; set; }

        // 2 Constructeur de la classe Livre
        public Livre(string titre, string auteur, int nombrePages)
        {
            Titre = titre;
            Auteur = auteur;
            NombrePages = nombrePages;
        }

        // 3 Methode pour afficher les details du livre
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"Titre: {Titre}");
            Console.WriteLine($"Auteur: {Auteur}");
            Console.WriteLine($"Nombre de pages: {NombrePages}");
        }

    }


    

}
