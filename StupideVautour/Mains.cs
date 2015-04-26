using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupideVautour
{
    public class Mains
    {
        int nbMains;
        Main[] Jeux;

        public Mains(int n)
        {
            int i;
            this.Jeux = new Main[n];
            for (i = 0; i < n; i++)
            {
                Jeux[i] = new Main();
            }
            this.nbMains = n;
        }

        /**
         * Renvoi la carte la plus forte, tout adversaires confondu;
         */
        public int maxAll(int joueur)
        {
            int i;
            int max = 0;
            for (i = 0; i < nbMains; i++)
            {
                if (i!=joueur && Jeux[i].max() > max)
                {
                    max = Jeux[i].max();
                }
            }
            return max;
        }

        public bool existe(int joueur, int carte)
        {
            return Jeux[joueur].existe(carte);
        }

        public void joue(int joueur, int carte)
        {
            Jeux[joueur].joue(carte);
        }
    }
}
