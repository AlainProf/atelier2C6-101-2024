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

namespace Atelier2C6_101_2024.Classes
{
    internal class Voiture
    {
        public string _Marque { get; set; }
        public string _Couleur { get; set; }

        //--------------------------------------------
        //
        //--------------------------------------------
        public Voiture() {
            _Marque= string.Empty;  
            _Couleur= "";
        }
        //--------------------------------------------
        //
        //--------------------------------------------
        public void Afficher()
        {
            Console.WriteLine($"Une {_Marque} de couleur {_Couleur}");
        }
    }
}
