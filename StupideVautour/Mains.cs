using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupideVautour
{
    public class Mains
    {
        Main[] Jeux;

        public Mains(int n)
        {
            int i;
            this.Jeux = new Main[n];
            for (i = 0; i < n; i++)
            {
                Jeux[i] = new Main();
            }
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
