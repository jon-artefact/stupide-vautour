using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StupideVautour
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        /*
         * Cette fonction permet de lancer le jeu en fonction du boutton de choix du nombre de Joueurs 
        */
        private void launchGame(int nbJoueur)
        {
            int difficulte = 1;

            if (difficulty.Text.CompareTo("Normal") == 0)
                difficulte = 2;
            else if (difficulty.Text.CompareTo("Difficile") == 0)
                difficulte = 3;
            else if (difficulty.Text.CompareTo("John") == 0)
                difficulte = 42;

            Console.WriteLine(nbJoueur);
            Console.WriteLine(difficulte);
            Table_jeu Jeu = new Table_jeu(nbJoueur, difficulte);
            Jeu.Show();
        }

        private void button_2Joueurs_Click(object sender, EventArgs e)
        {
            launchGame(2);
        }

        private void button_3Joueurs_Click(object sender, EventArgs e)
        {
            launchGame(3);
        }

        private void button_4Joueurs_Click(object sender, EventArgs e)
        {
            launchGame(4);
        }

        private void button_5Joueurs_Click(object sender, EventArgs e)
        {
            launchGame(5);
        }

        private void quitter(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void difficulty_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
