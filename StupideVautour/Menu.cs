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

        private void button_2Joueurs_Click(object sender, EventArgs e)
        {
            Table_jeu Jeu = new Table_jeu(2);
            Jeu.Show();
        }

        private void button_3Joueurs_Click(object sender, EventArgs e)
        {
            Table_jeu Jeu = new Table_jeu(3);
            Jeu.Show();
        }

        private void button_4Joueurs_Click(object sender, EventArgs e)
        {
            Table_jeu Jeu = new Table_jeu(4);
            Jeu.Show();
        }

        private void button_5Joueurs_Click(object sender, EventArgs e)
        {
            Table_jeu Jeu = new Table_jeu(5);
            Jeu.Show();
        }
    }
}
