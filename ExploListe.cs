using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_101_2024
{
    internal class ExploListe
    {
        const int NB_ELEMENTS = 10;
        static List<int> _lstEntiers = new List<int>();
        static List<Humain> _lstHumains = new List<Humain>();
        

        static Random _r = new Random();
        static public void Exec()
        {
            Util.Titrer("Exploration de listes");

           
            //ExecListeEntiers();

            ExecListeObjets();

            //Util.Pause();

            
        }
        static void ExecListeObjets()
        {
            for (int i = 0; i < NB_ELEMENTS; i++)
            {
                _lstHumains.Add(new Humain(Util._noms[_r.Next(0, 10)], new DateTime(_r.Next(1964, 2007), _r.Next(1, 13), _r.Next(1, 29))));
            }

            _lstHumains[9]._Nom = "Zébulon";
            _lstHumains[9]._Residence = new Adresse("485 app 32", "rue Fournier", "Singe et Rum", "Québec", "J7Z 4V2" );

            Util.SepST("Liste humain initale");
            AfficherListeHumain();

            Util.SepST("Liste humain triée (ordre alpha)");
            _lstHumains.Sort(CompareHumain);
            AfficherListeHumain();

            Util.SepST("Liste humain triée (ordre age)");
            _lstHumains.Sort(CompareAge);
            AfficherListeHumain();

            Util.SepST("Liste humain triée (ordre alpha inverse)");
            _lstHumains.Sort((a, b) => { return b._Nom.CompareTo(a._Nom); });
            AfficherListeHumain();

            Util.SepST("Liste humain triée (ordre alpha)");
            _lstHumains.Reverse();
            AfficherListeHumain();

            Util.SepST("Liste humain clearée");
            _lstHumains.Clear();
            AfficherListeHumain();

        }

        static int CompareAge(Humain humB, Humain humA)
        {
            if (humA.GetNaissance() < humB.GetNaissance())
                return -1;
            if (humA.GetNaissance() > humB.GetNaissance())
                return 1;
            return 0;
        }

        static int CompareHumain(Humain humA, Humain humB)
        {
            return humA._Nom.CompareTo(humB._Nom);
        }

        static void ExecListeEntiers()
        {
            for (int i = 0; i < NB_ELEMENTS; i++) 
            {
                _lstEntiers.Add(_r.Next(0, 1000));
            }

            Util.SepST("Liste initale");
            AfficherListe();

            Util.SepST("Liste triée");
            _lstEntiers.Sort();
            AfficherListe();

            Util.SepST("Liste inversée");
            _lstEntiers.Reverse();
            AfficherListe();

            Util.SepST("Liste Clearée");
            _lstEntiers.Clear();
            AfficherListe();

        }

        static void AfficherListe()
        {
            for (int i = 0; i < _lstEntiers.Count; i++)
            {
                Console.WriteLine(i + ":" + _lstEntiers[i]);
            }
        }

        static void AfficherListeHumain()
        {
            for (int i = 0; i < _lstHumains.Count; i++)
            {
                if (_lstHumains[i] != null)
                {
                   // _lstHumains[i].Afficher();
                }
                else
                {
                    Console.WriteLine("humain nul");
                }
            }
        }
                
    }
}
