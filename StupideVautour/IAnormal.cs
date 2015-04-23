using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupideVautour
{
    class IAnormal : IA
    {
         public IAnormal(int num, int nbJoueur)
            : base(num, nbJoueur)
        {

        }

        public override int Joue(int[,] mains_joueurs, int point, int[] scores)
        {
            switch(mode)
            {
                case 1:
                    
                    break;
                case 2:
                    break;
                default :
                    break;
            }
            return 0;
        }
    }
}
