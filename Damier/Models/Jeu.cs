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

        public void Deplacer(Joueur joueur, string direction, int index)
        {
            if (joueur.Equals(this[0]))
            {
                joueur.Deplacer(joueur[index], "descendre", direction);
            }
            else
            {
                joueur.Deplacer(joueur[index], "monter", direction);
            }
        }        
    }
}
