//-------------------------------
//  Fichier Humain.cs
//  Auteur: Alain Martel
//  Création: 2024-01-31 
//-------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_101_2024
{
    internal class Humain
    {
        private string _nom;
        DateTime _naissance;
        DateTime _deces;
        int _nas;

        static int _compteur=0;


        //-------------------------------
        //
        //-------------------------------
        public Humain()
        {
            _nom = "incognito";
            _naissance = new DateTime(1,1,1);
            _compteur++;
            _nas = _compteur;

        }
        //-------------------------------
        //
        //-------------------------------
        public Humain(string n)
        {
            _nom = n;
            _naissance = DateTime.Now;
            _compteur++;
            _nas = _compteur;

        }

        //-------------------------------
        //
        //-------------------------------
        public Humain(string n, DateTime nais)
        {
            _nom = n;
            _naissance = nais;
            _compteur++;
            _nas = _compteur;

        }

        //-------------------------------
        //
        //-------------------------------
        public void Mourir()
        {
            _deces = DateTime.Now;   
        }

        //-------------------------------
        //
        //-------------------------------
        public void Afficher()
        {
            Console.WriteLine(_nom + "(" + _nas + ") né le " +  _naissance.ToShortDateString() + " agé de " + Age() + " ans ");
        }

        //-------------------------------
        //
        //-------------------------------
        private int Age()
        {
            double delta = DateTime.Now.Ticks - _naissance.Ticks;  

            int deltaAn = (int) (delta  / 10000000 / (60 * 60 * 24 * 365.24));
            return deltaAn;
        }

        public string GetNom()
        {
            return _nom;
        }
        public DateTime GetNaissance()
        {
            return _naissance;
        }
    }
}
