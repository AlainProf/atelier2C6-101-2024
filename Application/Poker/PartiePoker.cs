using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_101_2024.Application.Poker
{
    internal class PartiePoker
    {
        const int COULEUR_TAPIS = 2;  // Vert
        const int COULEUR_TEXTE = 15; // Blanc
        const int NB_CARTE_DANS_UNE_MAIN = 5;
        const int NB_CARTE_DANS_UN_PAQUET = 52;
        public void Jouer()
        {
            InitTable();
            Util u = new Util();
            u.Titrer("Poker 2C6 ");
            
            Carte[] uneMain = new Carte[NB_CARTE_DANS_UNE_MAIN];

            uneMain[0] = new Carte(0, 0);
            uneMain[1] = new Carte(1, 12);
            uneMain[2] = new Carte(2, 8);
            uneMain[3] = new Carte(3, 10);
            uneMain[4] = new Carte(0, 1);

            InitTable(); 

            for(int i=0; i<uneMain.Length;i++)
            {
                uneMain[i].Afficher(i);
            }

            Console.WriteLine();
        }

        void InitTable()
        {
            Console.BackgroundColor = (ConsoleColor)COULEUR_TAPIS;
            Console.ForegroundColor = (ConsoleColor)COULEUR_TEXTE;

            // a ligne suivante permet d'afficher des symboles unicode (coeur trèfle etc...
            Console.OutputEncoding = System.Text.Encoding.Unicode;
        }
    }
}
