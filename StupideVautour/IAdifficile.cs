using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupideVautour
{
    class IAdifficile : IA
    {

        public IAdifficile(int num, int nbJoueur)
            : base(num, nbJoueur)
        {

        }


        public int IA1v1(Mains mains_joueurs, int point){
            int pointEnJeu = Math.Abs(point);
            if (pointEnJeu > 5)
            {
                
            }
            
            
            
            
            return 2;
        }

        public int IA1vpair(Mains mains_joueurs, int point)
        {
            return 3;
        }

        public int IA1vimpair(Mains mains_joueurs, int point)
        {
            return 4;
        }


        public override int Joue(Mains mains_joueurs, int point, int[] scores)
        {
            int cartePosee;
            switch (mode)
            {
                case 1 :
                    cartePosee = IA1v1(mains_joueurs, point);
                    break;
                case 2 :
                    cartePosee = IA1vpair(mains_joueurs, point);
                    break;
                case 3 :
                    cartePosee = IA1vimpair(mains_joueurs, point);
                    break;
                default :
                    cartePosee = 1;
                    break;
            }
            mains_joueurs.joue(num, cartePosee);
            return cartePosee;
        }
    }
}
