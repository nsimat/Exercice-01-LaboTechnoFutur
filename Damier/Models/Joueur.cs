using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damier.Models
{
    public class Joueur
    {
        public Pion[] Pions { get; set; }
        public ConsoleColor Color { get; set; }

        public Pion this[int index]
        {
            get
            {
               return Pions[index];
            }
            set
            {
                Pions[index] = value;
            }
        }
    }
}
