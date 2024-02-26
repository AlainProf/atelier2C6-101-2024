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
    internal class ExploListe
    {
        const int NB_ELEMENTS = 10;
        List<int> _lstEntiers = new List<int>();
        List<Humain> _lstHumains = new List<Humain>();
        Util u = new Util();

        //--------------------------------------------
        //
        //--------------------------------------------
        public void Exec()
        {
            u.Titrer("Exploration de listes");
            //ExecListeEntiers();
            ExecListeObjets();

        }
        //--------------------------------------------
        //
        //--------------------------------------------
        void ExecListeObjets()
        {
            for (int i = 0; i < NB_ELEMENTS; i++)
            {
                _lstHumains.Add(new Humain(u._noms[u.rdm.Next(0, 10)], new DateTime(u.rdm.Next(1964, 2007), u.rdm.Next(1, 13), u.rdm.Next(1, 29))));
            }

            _lstHumains[9]._Nom = "Zébulon";
            _lstHumains[9]._Residence = new Adresse("485 app 32", "rue Fournier", "Singe et Rum", "Québec", "J7Z 4V2");

            u.Sep("Liste humain initiale");
            AfficherListeHumain();
            u.Pause();

            u.Sep("Liste humain triée par age");
            _lstHumains.Sort();
            AfficherListeHumain();

            u.Pause();


            u.Sep("Liste humain triée (ordre alpha)");
            _lstHumains.Sort(CompareHumain);
            AfficherListeHumain();

            u.Sep("Liste humain triée (ordre age)");
            _lstHumains.Sort(CompareAge);
            AfficherListeHumain();

            u.Sep("Liste humain triée (ordre alpha inverse)");
            _lstHumains.Sort((a, b) => { return b._Nom.CompareTo(a._Nom); });
            AfficherListeHumain();

            u.Sep("Liste humain triée (ordre alpha)");
            _lstHumains.Reverse();
            AfficherListeHumain();

            u.Sep("Liste humain clearée");
            _lstHumains.Clear();
            AfficherListeHumain();

        }

        //--------------------------------------------
        //
        //--------------------------------------------
        int CompareAge(Humain humB, Humain humA)
        {
            if (humA.GetNaissance() < humB.GetNaissance())
                return -1;
            if (humA.GetNaissance() > humB.GetNaissance())
                return 1;
            return 0;
        }

        //--------------------------------------------
        //
        //--------------------------------------------
        int CompareHumain(Humain humA, Humain humB)
        {
            return humA._Nom.CompareTo(humB._Nom);
        }

        //--------------------------------------------
        //
        //--------------------------------------------
        void ExecListeEntiers()
        {
            for (int i = 0; i < NB_ELEMENTS; i++)
            {
                _lstEntiers.Add(u.rdm.Next(0, 1000));
            }

            u.Sep("Liste initale");
            AfficherListe();
            u.Pause();

            u.Sep("Liste triée");
            _lstEntiers.Sort();
            AfficherListe();
            u.Pause();

            /* u.SepST("Liste inversée");
            _lstEntiers.Reverse();
            AfficherListe();

            u.SepST("Liste Clearée");
            _lstEntiers.Clear();
            AfficherListe();*/

        }

        //--------------------------------------------
        //
        //--------------------------------------------
        void AfficherListe()
        {
            for (int i = 0; i < _lstEntiers.Count; i++)
            {
                Console.WriteLine(i + ":" + _lstEntiers[i]);
            }
        }

        //--------------------------------------------
        //
        //--------------------------------------------
        void AfficherListeHumain()
        {
            for (int i = 0; i < _lstHumains.Count; i++)
            {
                if (_lstHumains[i] != null)
                {
                    _lstHumains[i].Afficher();
                }
                else
                {
                    Console.WriteLine("humain nul");
                }
            }
        }

    }
}
