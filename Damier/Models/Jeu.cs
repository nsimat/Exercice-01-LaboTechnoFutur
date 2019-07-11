using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damier.Models
{
    public class Jeu
    {
        private Joueur[] joueurs = { new Joueur(), new Joueur() };
        
        public Joueur this[int index]
        {
            get { return joueurs[index]; }
            set { joueurs[index] = value; }
        }

        public void Deplacement()
        {
            
        }
    }
}
