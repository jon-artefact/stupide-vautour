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


        public int IA1v1(Mains mains_joueurs, int point)
        {
            int pointEnJeu = Math.Abs(point);
            if (pointEnJeu > 5)
            {
                if (mains_joueurs.maxAll(1) == 15)
                {
                    if (mains_joueurs.existeEntreJoueur(1, 10, 14))
                    {
                        int carteAjoue;
                        do
                        {
                            Random rand;
                            rand = new Random();
                            carteAjoue = rand.Next(5) + 10;
                        } while (mains_joueurs.existe(1, carteAjoue));
                        return carteAjoue;
                    }
                }
                else
                {
                    if (mains_joueurs.maxJoueur(0) < mains_joueurs.maxJoueur(1))
                    {
                        int i = mains_joueurs.maxJoueur(0) + 1;
                        while(!mains_joueurs.existe(1, i))
                        {
                            i++;
                        }
                        return i;
                    }
                    else
                    {
                        if (mains_joueurs.existeEntreJoueur(1, 1, 8))
                        {
                            int carteAjoue;
                            do
                            {
                                carteAjoue = this.jouePetiteCarte(mains_joueurs);
                            } while (!mains_joueurs.existe(1, carteAjoue));
                            return carteAjoue;
                        }
                        else
                        {
                            return mains_joueurs.minJoueur(1);
                        }
                    }

                }
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
