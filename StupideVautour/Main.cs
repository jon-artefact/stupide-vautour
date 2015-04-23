using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupideVautour
{
    class Main
    {
        bool[] cartes;

        public Main()
        {
            int i;
            this.cartes = new bool[15];
            for (i = 0; i < 15; i++)
            {
                cartes[i] = true;
            }
        }

        public int max()
        {
            return 1;
        }

        public int min()
        {
            return 1;
        }

        public bool existe(int carte)
        {
            return cartes[carte];
        }

        public void joue(int carte)
        {
            cartes[carte] = false;
        }
    }
}
