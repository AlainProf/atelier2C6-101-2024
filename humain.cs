using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2C6_101_2024
{
    internal class humain
    {
        private string nom;
        DateTime naissance;

        public humain(string n, DateTime nais)
        {
            nom = n;
            naissance = nais;
        }

        public void Afficher()
        {
            Console.WriteLine(nom + " né le " +  naissance.ToString());
        }
    }
}
