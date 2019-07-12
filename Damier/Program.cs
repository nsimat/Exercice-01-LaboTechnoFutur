using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Damier.Models;

namespace Damier
{
    class Program
    {
        static void Main(string[] args)
        {
            Jeu jeu = new Jeu();            
            
            jeu[0].Pions = new Pion[20];
            jeu[1].Pions = new Pion[20];

            Joueur Joueur1 = jeu[0];
            Joueur Joueur2 = jeu[1];
            
            int largeur = 5;
            int hauteur = 3;
                        
            AffichageJeu.genererPions(0, ConsoleColor.Blue, Joueur1);
            AffichageJeu.genererPions(6, ConsoleColor.Red, Joueur2);

            AffichageJeu.afficherDamier(largeur, hauteur);

            AffichageJeu.afficherPions(largeur, hauteur, Joueur1);
            AffichageJeu.afficherPions(largeur, hauteur, Joueur2);

            Console.WriteLine("");
            Console.WriteLine(" ");
            Console.WriteLine("");

            Console.WriteLine("Déplacer joueur 1 vers la gauche");//

            Console.ReadLine();

            Joueur1.Deplacer("gauche", 5);//

            AffichageJeu.afficherDamier(largeur, hauteur);

            AffichageJeu.afficherPions(largeur, hauteur, Joueur1);
            AffichageJeu.afficherPions(largeur, hauteur, Joueur2);

            Console.ReadLine();
        }        
    }
}
