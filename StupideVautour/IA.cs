﻿using System;

public abstract class IA
{
    protected int num;
    protected int nbJoueur;
    protected int mode;

    public IA()
    {
        //yolo;
    }

    public IA(int num, int nbJoueur)
	{
        this.num = num;
        this.nbJoueur = nbJoueur;
        this.mode = setMode();
	}

    protected int setMode()
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

    public abstract int Joue(int[,] mains_joueurs, int point, int[] scores);
}
