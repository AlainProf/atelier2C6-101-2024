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

        /* 
        // Méthode classique
        private string _nom;

        public string GetNom()
        {
            return _nom;
        }

        public void SetNom(string nom)
        {
            _nom = nom;
        }
        */

        // Méthode property
        /*
        private string _nom;
        public string _Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        */

        // Méthode property auto

        public string _Nom {  get; set; }   

        public DateTime _Naissance { get; set; }
        public DateTime _Deces { get; set; }
        public int _Nas { get;  set; }

        public Adresse _Residence { get; set; }

        static int _compteur=0;


        //-------------------------------
        //
        //-------------------------------
        public Humain()
        {
            _Nom = "incognito";
            _Naissance = new DateTime(1,1,1);
            _compteur++;
            _Nas = _compteur;
            _Residence = new Adresse(); 

        }
        //-------------------------------
        //
        //-------------------------------
        public Humain(string n)
        {
            _Nom = n;
            _compteur++;
            _Nas = _compteur;
            _Residence = new Adresse();


        }

        //-------------------------------
        //
        //-------------------------------
        public Humain(string n, DateTime nais)
        {
            _Nom = n;
            _Naissance = nais;
            _compteur++;
            _Nas = _compteur;
            _Residence = new Adresse();
        }
        //-------------------------------
        //
        //-------------------------------
        public Humain(string n, DateTime nais, Adresse naissance)
        {
            _Nom = n;
            _Naissance = nais;
            _compteur++;
            _Nas = _compteur;
            _Residence = naissance;
        }

        //-------------------------------
        //
        //-------------------------------
        public void Mourir()
        {
            _Deces = DateTime.Now;   
        }

        //-------------------------------
        //
        //-------------------------------
        public void Afficher()
        {
            Console.WriteLine(_Nom + "(" + _Nas + ") né le " +  _Naissance.ToShortDateString() + " agé de " + Age() + " ans ");

            if (_Residence._NumCivique != "0")
               _Residence.Afficher();
        }

        //-------------------------------
        //
        //-------------------------------
        private int Age()
        {
            double delta = DateTime.Now.Ticks - _Naissance.Ticks;  

            int deltaAn = (int) (delta  / 10000000 / (60 * 60 * 24 * 365.24));
            return deltaAn;
        }

        public DateTime GetNaissance()
        {
            return _Naissance;
        }
    }
}
