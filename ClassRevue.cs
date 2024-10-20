using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres_D1
{
    // 1 Attributs de la classe Fille Revue
    internal class Revue : Livre
    {
        public int Numero { get; set; }
        public int Annee { get; set; }


        // 2 Constructeur de la classe Revue
        public Revue(string titre, string auteur, int nombrePages, int numero, int annee) : base(titre, auteur, nombrePages)
        {
            Numero = numero;
            Annee = annee;

        }

        // 3 Methode pour afficher les details du Revue
        public virtual void AfficherDetails()
        {
            base.AfficherDetails(); // Appelle la méthode de la classe mère
            Console.WriteLine($"Numero: {Numero}");
            Console.WriteLine($"Annee: {Annee}");

        }
    }
}