using Damier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damier
{
    public static class AffichageJeu
    {
        public static void afficherDamier(int largeur, int longueur)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int L = 0; L < longueur; L++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (i % 2 == 0)
                        {
                            if (j % 2 == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                            }
                        }
                        else
                        {
                            if (j % 2 == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                            }
                        }
                        for (int l = 0; l < largeur; l++)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine("");
                }
            }
        }

        public static void afficherPions(int largeur, int hauteur, Joueur joueur)
        {
            foreach (Pion p in joueur.Pions)
            {
                Console.CursorLeft = (largeur / 2) + p.Y * largeur;
                Console.CursorTop = (hauteur / 2) + p.X * hauteur;
                Console.ForegroundColor = joueur.Color;
                Console.Write('O');
            }
        }

        public static void genererPions(int x, ConsoleColor color, Joueur joueur)
        {
            joueur.Color = color;
            for (int i = 0; i < joueur.Pions.Length; i++)
            {
                int Row = x;
                while (Row < x + 4)
                {
                    int Column;
                    if (Row % 2 == 0)
                    {
                        Column = 0;
                    }
                    else
                    {
                        Column = 1;
                    }
                    do
                    {
                        joueur[i] = new Pion();
                        joueur[i].X = Row;
                        joueur[i].Y = Column;
                        Column += 2;
                        i++;
                    } while (Column <= 9);
                    Row += 1;
                }
            }
        }        
    }
}
