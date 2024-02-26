//-------------------------------
//  Fichier .cs
//  Auteur: Alain Martel
//  Création: 2024-02-26 
//-------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_101_2024.Connect4
{
    internal class PartieConnect4
    {
        Grille _grille = new Grille();
        bool _partieEnCours;
        char _joueurCourant = 'x';
        Util u = new Util();

        //--------------------------------------------
        //
        //--------------------------------------------
        public void Jouer()
        {
            u.Titrer(" .... C O N N E C T - 4 \n Par Alain Martel");

            _partieEnCours = true;
            _grille = new Grille();
            _grille.Afficher();

            while (_partieEnCours)
            {
                char dec = SaisirDecision();
                if (Valider(dec))
                {
                    InsererJeton(dec, _joueurCourant);
                    _grille.Afficher();
                }
                if (CoupGagnant())
                {
                    _partieEnCours = false;
                }
               
            }
        }

        //--------------------------------------------
        //
        //--------------------------------------------
        void InsererJeton(char col, char joueur)
        {
            _grille.InsererJeton(col, joueur);
        }

        //--------------------------------------------
        //
        //--------------------------------------------
        char SaisirDecision()
        {
            return 'A';
        }

        //--------------------------------------------
        //
        //--------------------------------------------
        bool Valider(char dec) 
        {
            return true;
        }

        //--------------------------------------------
        //
        //--------------------------------------------
        bool CoupGagnant() { 
            return true;    
        }
    }
}
