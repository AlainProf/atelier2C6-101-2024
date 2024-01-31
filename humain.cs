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

        //-------------------------------
        //
        //-------------------------------
        public Humain()
        {
            _nom = "incognito";
            _naissance = new DateTime(1,1,1);
        }
        //-------------------------------
        //
        //-------------------------------
        public Humain(string n)
        {
            _nom = n;
            _naissance = DateTime.Now;
        }

        //-------------------------------
        //
        //-------------------------------
        public Humain(string n, DateTime nais)
        {
            _nom = n;
            _naissance = nais;
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
            Console.WriteLine(_nom + " né le " +  _naissance.ToShortDateString() + " agé de " + Age() + " ans ");
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
    }
}
