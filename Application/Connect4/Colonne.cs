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
    internal class Colonne
    {
        int _numero;
        Case[] _cases = new Case[Grille.NB_RANGEES];
        //--------------------------------------------
        //
        //--------------------------------------------
        public Colonne(int numColonne) 
        {
            _numero = numColonne;
            for(int i=0; i<Grille.NB_RANGEES; i++) 
            {
                _cases[i] = new Case(_numero, i); 
            }
        }

        //--------------------------------------------
        //
        //--------------------------------------------
        public void Afficher() 
        {
            for(int i=0;i<Grille.NB_RANGEES;i++)
            {
                _cases[i].Afficher();
            }
        }

        //--------------------------------------------
        //
        //--------------------------------------------
        public void InsererJeton(char joueur)
        {
            _cases[0]._Contenu = joueur;
        }
    }
}
