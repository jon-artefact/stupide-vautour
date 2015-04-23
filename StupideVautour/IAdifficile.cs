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


        public int IA1v1(int[,] mains_joueurs, int point){
            int pointEnJeu = Math.Abs(point);
            if (pointEnJeu > 5)
            {
                
            }
            
            
            
            
            return 2;
        }

        public int IA1vpair(int[,] mains_joueurs, int point)
        {
            return 3;
        }

        public int IA1vimpair(int[,] mains_joueurs, int point)
        {
            return 4;
        }


        public override int Joue(int[,] mains_joueurs, int point, int[] scores)
        {
            switch (nbJoueur)
            {
                case 2 :
                    return IA1v1(mains_joueurs, point);
                case 3 :
                    return IA1vpair(mains_joueurs, point);
                case 4 :
                    return IA1vimpair(mains_joueurs, point);
                case 5 :
                    return IA1vpair(mains_joueurs, point);
                default :
                    return 1;
            }
        }
    }
}
