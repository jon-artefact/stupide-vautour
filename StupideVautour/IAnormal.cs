using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupideVautour
{
    class IAnormal : IA
    {
        public int MAX = 10;

         public IAnormal(int num, int nbJoueur)
            : base(num, nbJoueur)   { }

        /*
         * Ceci constitue le corps de l'IA Normal
         * Les paramètres d'entrée sont :
         * les Mains des joueurs présents (dont la notre)
         * la valeur de la carte qui est actuellement jouée (Vautour ou Souris)
         * Cette valeur est entre -5 et 10
         * Un tableau des scores des joueurs
         * 
         * Notre IA va retourner une valeur entre 1 et 15 qui correspond à la carte que l'on va jouer 
         */
        public override int Joue(Mains mains_joueurs, int point, int[] scores)
        {
            // Verrification des paramètres
            if (point < -5 || point > 10)
            {
                Console.WriteLine("IA Normal : le paramètre point a recu une valeur non conforme :");
                Console.WriteLine(point);
            }
                
            // On va commencer par regarder le mode de jeu actuel
            switch(mode)
            {
                    // Dans le cas d'un 1 vs 1
                case 1:
                    int min = (point < 0)? point * (-1) : point;
                    int max = min + 5;
                    int i = min;
                    int last = 0;
                    for (i = min; i <= max; ++i)
                    {
                        if (mains_joueurs.existe(num, i))
                        {
                            if (!mains_joueurs.existe(0, i))
                                return i;
                            else
                                last = i;
                        }
                    }
                    if (last != 0)
                        return last;
                    else
                        return mains_joueurs.maxJoueur(num);
                    break;

                    // Dans le cas d'un 1 vs 2 ou 1 vs 4
                case 2:
                    Random rand = new Random();
                    break;

                    // Dans le cas d'un 1 vs 3
                default :

                    break;
            }
            return 0;
        }
    }
}
