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
        const int LARGEUR_CARTE = 5;

        public Carte(int sorte = 0, int valeur = 0) 
        {
            _Sorte = sorte; 
            _Valeur = valeur;   
        }

        public void Afficher(int decalage=0, bool graphique = true)
        {
            SetValeurTexte();
            SetSorteTexte();
            if (graphique)
            {
                switch (_Sorte)
                {
                    case 0:
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case 1:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        break;
                }

                Console.SetCursorPosition(1 + (decalage * LARGEUR_CARTE), 3);
                Console.Write(_valeurTexte);
                Console.Write("    ");
                Console.SetCursorPosition(1 + (decalage * LARGEUR_CARTE), 4);
                Console.Write("  ♥  ");
                Console.SetCursorPosition(1 + (decalage * LARGEUR_CARTE), 5);
                Console.Write("    ");
                Console.Write(_valeurTexte);
            }
            else
            {
                Console.WriteLine($"\n{_valeurTexte} de {_sorteTexte}");
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
