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
using Atelier2C6_101_2024.Classes;

namespace Atelier2C6_101_2024.Exploration
{
    internal class ExploTableau
    {
        const int NB_ELEMENTS = 10;
        int[] _tabEntiers = new int[NB_ELEMENTS];
        Humain[] _tabHumains = new Humain[NB_ELEMENTS];

        Util u;

        //--------------------------------------------
        //
        //--------------------------------------------
        public ExploTableau()
        {
           u = new Util();
        }
        //--------------------------------------------
        //
        //--------------------------------------------
        public void Exec()
        {
            u.Titrer("Tableau (array) en C#");
                     
            //TabHumains();

            u.Pause();
        }

        void TabHumains()
        {
            for (int i = 0; i < NB_ELEMENTS; i++)
            {
                _tabHumains[i] = new Humain(u._noms[u.rdm.Next(0, 10)], new DateTime(u.rdm.Next(1964, 2007), u.rdm.Next(1, 13), u.rdm.Next(1, 29)));
            }
            u.Sep("Tableau humain initial");
            AfficherTabHum();


            u.Sep("Tableau humain trié par age");
            Array.Sort(_tabHumains, new Humain().comparerAge);
            AfficherTabHum();
                        
            u.Sep("inverse");
            Array.Reverse(_tabHumains);
            AfficherTabHum();

            u.Sep("POST Clear");
            Array.Clear(_tabHumains);
            AfficherTabHum();
        }

        //--------------------------------------------
        //
        //--------------------------------------------
        void TabEntiers()
        {
            for (int i = 0; i < _tabEntiers.Length; i++)
            {
                _tabEntiers[i] = u.rdm.Next(0, 1000);
            }
            u.Sep("tab initial");
            AfficherTab();

            Array.Sort(_tabEntiers);
            
            u.Sep("Tab trié");
            AfficherTab();

            Array.Reverse(_tabEntiers);
            u.Sep("Tab inversé");
            AfficherTab();

            double moy = _tabEntiers.Average();
            u.Sep("moyenne: " + moy);

            Array.Clear(_tabEntiers);
            u.Sep("post clear()");
            AfficherTab();
        }

        //--------------------------------------------
        //
        //--------------------------------------------
        void AfficherTab()
        {
            for (int i = 0; i < _tabEntiers.Length; i++)
            {
                Console.WriteLine(i + ":" + _tabEntiers[i]);
            }
        }
        //--------------------------------------------
        //
        //--------------------------------------------
        void AfficherTabHum()
        {
            for (int i = 0; i < _tabHumains.Length; i++)
            {
                if (_tabHumains[i] != null)
                {
                    // _tabHumains[i].Afficher();
                }
                else
                {
                    Console.WriteLine("humain nul");
                }
            }
        }
    }
}
