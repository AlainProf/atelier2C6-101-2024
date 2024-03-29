﻿//-------------------------------
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
    internal class Etudiant : Humain
    {
        public string _Matricule { get; set; }
        public double _Moyenne { get; set; }

        //--------------------------------------------
        //
        //--------------------------------------------
        public Etudiant(string nom) : base(nom)
        {
            _Matricule = "";   
        }

        //--------------------------------------------
        //
        //--------------------------------------------
        public Etudiant(string nom, string mat) : base(nom)
        {
            _Matricule = mat;
        }
        public Etudiant(string nom, string mat, DateTime nais) : base(nom, nais)
        {
            _Matricule = mat;
        }



        //--------------------------------------------
        //
        //--------------------------------------------
        public void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Mat: " + _Matricule);
        }

    }

    class Universitaire : Etudiant
    {
        string _Programme { get; set; }
        //--------------------------------------------
        //
        //--------------------------------------------
        public Universitaire(string nom, string programme) : base(nom)
        {
            _Programme = programme;
        }
    }
}
