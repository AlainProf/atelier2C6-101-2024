using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_101_2024
{
    internal class Tableau2D
    {
        readonly int NB_RANGEES;
        readonly int NB_COLONNES;
        char[,] _grille;

        public Tableau2D(int nbCol, int nbRang) 
        {
            NB_COLONNES = nbCol;
            NB_RANGEES = nbRang;

            _grille = new char[NB_COLONNES, NB_RANGEES];

            for (int i = 0; i < NB_COLONNES; i++) 
            {
                for (int j = 0; j < NB_RANGEES; j++)
                {
                    _grille[i, j] = '_';
                }
            }
        }

        public void Afficher()
        {
            for (int i = 0; i < NB_COLONNES; i++)
            {
                for (int j = 0; j < NB_RANGEES; j++)
                {
                    EcrireCase(i, j);
                }
            }

        }
        public void AfficherHorizontalement()
        {
            char dec;
            for (int i = 0; i < NB_COLONNES; i++)
            {
                for (int j = 0; j < NB_RANGEES; j++)
                {
                    dec = 'x';
                    if (j % 2 == 0)
                        dec = 'o';

                    _grille[i, j] = dec;
                    
                    EcrireCase(i, j);
                }
            }

        }
        public void AfficherVertical()
        {
            char dec;
            for (int i = 0; i < NB_COLONNES; i++)
            {
                for (int j = 0; j < NB_RANGEES; j++)
                {
                    dec = 'x';
                    if (i % 2 == 0)
                        dec = 'o';

                    _grille[i, j] = dec;
                    EcrireCase(i, j);
                }
            }
        }
        public void AfficherAleatoire()
        {
            
            for (int i = 0; i < NB_COLONNES; i++)
            {
                for (int j = 0; j < NB_RANGEES; j++)
                {
                    int dec = Util.rdm.Next(0, 3);
                    switch(dec)
                    {
                        case 0:
                            _grille[i, j] = 'o';
                            break;
                        case 1:
                            _grille[i, j] = 'x';
                            break;
                        case 2:
                            _grille[i, j] = '_';
                            break;
                    }
                    EcrireCase(i, j);
                }
            }
        }

        private void EcrireCase(int x, int y)
        {
            Console.SetCursorPosition(x * 4,y + 6);
            Console.Write($"_{_grille[x,y]}_|");
        }
    }
}
