using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_101_2024.Application.Poker
{
    internal class MainJoueur
    {
        Carte[] _lesCartes = new Carte[5];
        int _idJoueur;

        public MainJoueur(int idxJoueur) 
        { 
            for(int i=0; i < 5; i++) {
                _lesCartes[i] = new Carte();
            }
            _idJoueur = idxJoueur;
        }

        public void Afficher()
        {
            for (int i = 0; i < 5; i++)
            {
                _lesCartes[i].Afficher(true, i, _idJoueur);
            }
        }


        public void InitCarte(int idx, Carte laCarte)
        {
            _lesCartes[idx] = laCarte;
        }

    }
}
