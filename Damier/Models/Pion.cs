﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damier.Models
{
    public class Pion
    {
        private int _X;
        public int X {
            get {
                return _X;
            }
            set {
                if(value<=9 && value >= 0)
                {
                    _X = value;
                }
            }
        }
        private int _Y;

        public int Y
        {
            get { return _Y; }
            set {
                if ((value <= 9 && value >= 0)&&(X%2==value%2))
                {
                    _Y = value;
                }
            }
        }

        public virtual void Monte(string direction)
        {
            if (direction.Equals("gauche"))
            {

                if (X == 0)
                {
                    ++X;
                    --Y;
                }
                else
                {
                    --X;
                    --Y;
                }
            }
            else
            {
                if (X == 9)
                {
                    ++X;
                    --Y;
                }
                else
                {
                    --X;
                    --Y;
                }
            }
        }

        public virtual void Descend(string direction)
        {
            if(direction.Equals("gauche"))
            {
                if(X == 9)
                {
                    --X;
                    Y++;
                }
            }
        }
    }
}
