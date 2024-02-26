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

namespace Atelier2C6_101_2024.Application
{
    internal class PartieTicTacToe
    {
        char _joueurCourant = 'X';
        char[] _cases = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        Util u = new Util();

        //--------------------------------------------
        //
        //--------------------------------------------
        public void Jouer()
        {

            DessinerGrille();

            bool partieEnCours = true;
            while (partieEnCours)
            {
                ProchainCoup();
                DessinerGrille();

                if (CoupGagnant())
                {
                    partieEnCours = false;
                    Console.WriteLine($"Bravo {_joueurCourant}, vous avez gagné!!");
                }

                if (_joueurCourant == 'X')
                    _joueurCourant = 'O';
                else
                    _joueurCourant = 'X';
            }
        }

        //--------------------------------------------
        //
        //--------------------------------------------
        bool CoupGagnant()
        {
            // Victoire 0
            if (_cases[0] != ' ')
            {
                if (_cases[0] == _cases[1] && _cases[0] == _cases[2])
                    return true;
            }
            // Victoire 1
            if (_cases[3] != ' ')
            {
                if (_cases[3] == _cases[4] && _cases[3] == _cases[5])
                    return true;
            }
            return false;
        }

        //--------------------------------------------
        //
        //--------------------------------------------
        void ProchainCoup()
        {
            Console.WriteLine($"\n à {_joueurCourant} de jouer (0 à 8):");

            char coup = 'Q';
            while (!CoupLegal(coup))
                coup = u.SaisirChar();

            int idx = int.Parse(coup.ToString());

            _cases[idx] = _joueurCourant;
        }

        //--------------------------------------------
        //
        //--------------------------------------------
        bool CoupLegal(char coup)
        {
            if (coup != '0' && coup != '1' && coup != '2' && coup != '3' && coup != '4' && coup != '5' && coup != '6' && coup != '7' && coup != '8')
                return false;

            int idx = int.Parse(coup.ToString());
            if (_cases[idx] != ' ')
                return false;

            return true;
        }

        //--------------------------------------------
        //
        //--------------------------------------------
        void DessinerGrille()
        {
            u.Titrer("Partie de TicTacToe opposant Xavier et Olivier");

            Console.WriteLine("\n");


            // Case 0
            if (_cases[0] != ' ')
            {
                Console.Write("_" + _cases[0] + "_|");
            }
            else
            {
                Console.Write("___|");
            }

            // Case 1
            if (_cases[1] != ' ')
            {
                Console.Write("_" + _cases[1] + "_|");
            }
            else
            {
                Console.Write("___|");
            }

            // Case 2
            if (_cases[2] != ' ')
            {
                Console.WriteLine("_" + _cases[2] + "_");
            }
            else
            {
                Console.WriteLine("___");
            }

            // Case 3
            if (_cases[3] != ' ')
            {
                Console.Write("_" + _cases[3] + "_|");
            }
            else
            {
                Console.Write("___|");
            }

            // Case 4
            if (_cases[4] != ' ')
            {
                Console.Write("_" + _cases[4] + "_|");
            }
            else
            {
                Console.Write("___|");
            }

            // Case 5
            if (_cases[5] != ' ')
            {
                Console.WriteLine("_" + _cases[5] + "_");
            }
            else
            {
                Console.WriteLine("___");
            }

            // Case 6
            if (_cases[6] != ' ')
            {
                Console.Write(" " + _cases[6] + " |");
            }
            else
            {
                Console.Write("   |");
            }

            // Case 7
            if (_cases[7] != ' ')
            {
                Console.Write(" " + _cases[7] + " |");
            }
            else
            {
                Console.Write("   |");
            }

            // Case 8
            if (_cases[8] != ' ')
            {
                Console.WriteLine(" " + _cases[8] + " ");
            }
            else
            {
                Console.WriteLine("   ");
            }
        }
    }
}
