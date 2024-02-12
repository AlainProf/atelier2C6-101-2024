using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_101_2024.Connect4
{
    internal class Case
    {
        int _numCol;
        int _numRangee;
        public char _Contenu { get; set; }
        public Case(int col, int rang) 
        { 
            _numCol = col;  
            _numRangee = rang;
            _Contenu = ' ';
        }
        
        public void Afficher() 
        {
            Console.SetCursorPosition(_numCol * 4, _numRangee + 6);
            Console.Write("___|");
        }
    }
}
