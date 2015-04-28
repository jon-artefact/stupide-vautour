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
            if(mode == 1) // Dans le cas d'un 1 vs 1
            {
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
            }
            else // Dans le cas d'un 1 vs 2, 1 vs 3 ou 1 vs 4
            {
                /*
                 * Dans le cas d'un affrontement contre plusieurs IA, nous allons procéder
                 * à une stratégie de groupe.
                 * L'IA numéro 1 sera chargée de récuperer les vautours afin d'obtenir le plus petit score
                 * L'IA numéro 2 sera en charge de récuper les cartes les plus fortes
                 * Si elles existent, les IA 3 et 4 essayeront de bloquer le joueur
                 */
                if(point < 0)
                {
                    // Si il s'agit de l'IA 1, je vais jouer ma carte la plus faible, les autres suivent la logique
                    return mains_joueurs.minJoueur(num) + num;
                }
                else // Si il s'agit d'une souris
                {
                    if(num == 1) // Le joueur 1 est le dernier
                        return mains_joueurs.maxJoueur(num) - nbJoueur + 2;
                    else // Le joueur 2 jouera la meilleur carte
                        return mains_joueurs.maxJoueur(num) - num + 2;
                }
            }
        }
    }
}
