using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_101_2024.Application.Poker
{
    internal class Paquet
    {
        const int NB_CARTES = 52;
        int _curseur = 0;
        Carte[] lesCartes = new Carte[NB_CARTES];


        public Paquet()
        {
            for(int i = 0; i < NB_CARTES; i++)
            {
                lesCartes[i] = new Carte(i/13, i%13);
            }
        }

        public void Afficher()
        {
            for(int i = 0; i < NB_CARTES; i++)
            {
                lesCartes[i].Afficher(true, i%13, i/13 );

            }
        }

        public void Brasser()
        {
            Random alea = new Random();

            for(int i = 51; i>1; --i )
            {
                int randomIndex = alea.Next(i);
                Carte temp = lesCartes[i];
                lesCartes[i] = lesCartes[randomIndex];
                lesCartes[randomIndex] = temp;  
            }
        }

        public Carte Distribuer()
        {
            return lesCartes[_curseur++];
        }
    }
}
