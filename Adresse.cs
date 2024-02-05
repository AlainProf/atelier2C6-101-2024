using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_101_2024
{
    internal class Adresse
    {
        public string _NumCivique { get; set; }
        public string _Rue { get; set; }
        public string _Ville { get; set; }
        public string _Province { get; set; }
        public string _CodePostal { get; set; }

        public Adresse() 
        {
            _NumCivique = "0";
            _Rue = "inconnue";
            _Ville = "st-glinglin";
            _Province = "loosers";
            _CodePostal = "A1a1a1";
        }

        public Adresse(string n, string r, string v, string p, string c  )
        {
            _NumCivique = n;
            _Rue = r;
            _Ville = v;
            _Province = p;
            _CodePostal = c;
        }

        public void Afficher()
        {
            Console.WriteLine("{0} {1}\n{2}\n{3}\n{4}", _NumCivique, _Rue, _Ville, _Province, _CodePostal);
        }



    }
}
