using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupideVautour
{
    class IAnovice : IA
    {
        public IAnovice(int num, int nbJoueur)
            : base(num, nbJoueur)   { }

        public override int Joue(Mains mains_joueurs, int point, int[] scores)
        {
            return 1;
        }
    }
}
