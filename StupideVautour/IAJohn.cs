using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupideVautour
{
    class IAJohn : IA
    {
        public override int Joue(Mains mains_joueurs, int point, int[] scores)
        {
            return 1;
        }

        public IAJohn(int point, int nbJoueurs)
        {
            //to do
        }
    }
}
