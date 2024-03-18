using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_101_2024.Application.Poker
{
    internal class Carte
    {

        // ♥♣♦♠
        public int _Sorte {  get; set; }    
        public int _Valeur { get; set; }

        string _valeurTexte = "2";
        string _sorteTexte = "Pique";

        const int COULEUR_PIQUE = 0;
        const int COULEUR_TREFLE = (int)ConsoleColor.DarkBlue;
        const int COULEUR_CARREAU = (int)ConsoleColor.Red;
        const int COULEUR_COEUR = (int)ConsoleColor.DarkRed;
      


        const int LARGEUR_CARTE = 5;

        public Carte(int sorte = 0, int valeur = 0) 
        {
            _Sorte = sorte; 
            _Valeur = valeur;   
        }

        public void Afficher(bool graphique = true, int posX=0,int posY=0)
        {
            SetValeurTexte();
            SetSorteTexte();
            if (graphique)
            {
                Console.BackgroundColor = ConsoleColor.White;
                switch (_Sorte)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }
                //Console.Clear();
                Console.SetCursorPosition(posX * (LARGEUR_CARTE + 1), (posY *4) + 3);
                Console.Write(_valeurTexte);
                Console.Write("    ");
                Console.SetCursorPosition(posX * (LARGEUR_CARTE + 1), (posY * 4) + 4);
                Console.Write($"  {GetSymbole()}  ");
                Console.SetCursorPosition(posX * (LARGEUR_CARTE + 1), (posY * 4) + 5);
                Console.Write("    ");
                Console.Write(_valeurTexte);
            }
            else
            {
                Console.WriteLine($"\n{_valeurTexte} de {_sorteTexte}");
            }
        }

        char GetSymbole()
        {
            //♥♣♦♠
            switch ( _Sorte)
            {
                case 0:
                    return '♠';
                case 1:
                    return '♣';
                case 2:
                    return '♦';
                case 3:
                    return '♥';
                default:
                    return '♠';
            }
        }

        private void SetValeurTexte()
        {
            switch (_Valeur)
            {
                case 12:
                    _valeurTexte = "A";
                    break;
                case 11:
                    _valeurTexte = "K";
                    break;
                case 10:
                    _valeurTexte = "Q";
                    break;
                case 9:
                    _valeurTexte = "J";
                    break;
                case 8:
                    _valeurTexte = "X";
                    break;
                case 7:
                    _valeurTexte = "9";
                    break;
                case 6:
                    _valeurTexte = "8";
                    break;
                case 5:
                    _valeurTexte = "7";
                    break;
                case 4:
                    _valeurTexte = "6";
                    break;
                case 3:
                    _valeurTexte = "5";
                    break;
                case 2:
                    _valeurTexte = "4";
                    break;
                case 1:
                    _valeurTexte = "3";
                    break;
                case 0:
                    _valeurTexte = "2";
                    break;
                default:
                    throw new ArgumentException($"Erreur {_Valeur} valeur de carte invalide");
            }
        }
        private void SetSorteTexte()
        {
            switch (_Sorte)
            {
                case 3:
                    _sorteTexte = "Coeur";
                    break;
                case 2:
                    _sorteTexte = "Carreau";
                    break;
                case 1:
                    _sorteTexte = "Trèfle";
                    break;
                case 0:
                    _sorteTexte = "Pique";
                    break;
                default:
                    throw new ArgumentException($"Erreur {_Sorte} sorte de carte invalide");
            }
        }
    }
}
