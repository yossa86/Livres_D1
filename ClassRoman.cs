using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres_D1
{
    // 1 Attributs de la classe Roman
    internal class Roman : Livre
    {
        public string Genre { get; set; }
        

        // 2 Constructeur de la classe Roman
        public Roman(string titre, string auteur, int nombrePages, string genre) : base(titre, auteur, nombrePages)
        {
            Genre = genre;
          
        }

        // 3 Methode pour afficher les details du Roman
        public virtual void AfficherDetails()
        {
            base.AfficherDetails(); // Appelle la méthode de la classe mère
            Console.WriteLine($"Genre: {Genre}");
          
        }
    }
}
