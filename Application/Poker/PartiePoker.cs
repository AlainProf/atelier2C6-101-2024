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

        MainJoueur[] _mainsJoueurs = new MainJoueur[4];

        Paquet lePaquet = new Paquet();

        public PartiePoker()
        {
            for(int i=0; i<4; i++)
            {
                _mainsJoueurs[i] = new MainJoueur(i);
            }
        }
        public void Jouer()
        {
            Util u = new Util();
            u.Titrer("Poker 2C6 ");
            InitTable();

            /*lePaquet.Afficher();
            while (true)
            {
                Console.ReadKey();
                lePaquet.Afficher();
            }*/

            lePaquet.Brasser();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    _mainsJoueurs[j].InitCarte(i, lePaquet.Distribuer());
                }
            }

            for (int i = 0; i < 4; i++)
            {
               _mainsJoueurs[i].Afficher();
            }
        }

        void InitTable()
        {
            Console.BackgroundColor = (ConsoleColor)COULEUR_TAPIS;
            Console.ForegroundColor = (ConsoleColor)COULEUR_TEXTE;

            // a ligne suivante permet d'afficher des symboles unicode (coeur trèfle etc...
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Clear();
        }
    }
}
