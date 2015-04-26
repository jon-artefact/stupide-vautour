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
                
            int pivot;
            
            // On va commencer par regarder le mode de jeu actuel
            switch(mode)
            {
                    // Dans le cas d'un 1 vs 1
                case 1:
                    if (point < 0)
                        pivot = point * (-1);
                    break;

                    // Dans le cas d'un 1 vs 2 ou 1 vs 4
                case 2:

                    break;

                    // Dans le cas d'un 1 vs 3
                default :

                    break;
            }
            return 0;
        }
    }
}
