using System;

public class IA
{
    protected int num;
    protected int nbJoueur;
	
    public IA(int num, int nbJoueur)
	{
        this.num = num;
        this.nbJoueur = nbJoueur;
	}

    protected int mode()
    {
        switch (nbJoueur)
        {
            case 2:
                return 1;
            case 4:
                return 3;
            default:
                return 2;
        }
    }

    public int Joue(int[,] mains_joueurs, int point);
}
