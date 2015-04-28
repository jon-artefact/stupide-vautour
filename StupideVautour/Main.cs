using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupideVautour
{
    class Main
    {
        /**
         * tableau de 15 cartes; 0-14
         */
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

        /**
         * Regarde s'il existe une carte dans l'intervalle de valeur donné
         */
        public bool existeEntre(int min, int max)
        {
            int i;
            for (i = min-1; i < max-1; i++)
            {
                if (cartes[i])
                {
                    return true;
                }
            }
            return false;
        }

        public int max()
        {
            int i=14;
            while (!cartes[i])
            {
                i--;
            }
            return i++;
        }

        public int min()
        {
            int i = 0;
            while (!cartes[i])
            {
                i++;
            }
            return i++;
        }

        public bool existe(int carte)
        {
            return cartes[carte-1];
        }

        public void joue(int carte)
        {
            cartes[carte-1] = false;
        }

        public int nbCartesRestantes()
        {
            int i, j = 0;
            for (i = 0; i < 15; ++i)
            {
                if (cartes[i])
                    j++;
            }
            return j;
        }
    }
}
