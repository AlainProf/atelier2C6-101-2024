﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_101_2024
{
    internal class Ecran
    {
        int _hauteur;
        int _largeur;
        public void Exec()
        {
            Init();
            Util.Titrer("Dessiner avec la console de C#");

            _hauteur = Console.WindowHeight;
            _largeur = Console.WindowWidth;

            Console.WriteLine("Largeur:" + _largeur + "\nHauteur:" +  _hauteur);


/*            for(int b = 0; b < 1; b++)
            {
                for(int f = 0; f < 16; f++) 
                {
                    Init(b, f);
                    Thread.Sleep(500);
                }
            }*/
            Init();

            //Parcours();
            Epilepsis();
    
        }

        void Epilepsis()
        {
            Init();
            while (true)
            {
                for (int y = 0; y < _hauteur; y++)
                {
                    Console.BackgroundColor = (ConsoleColor)(y % 16);
                    for (int x = 0; x < _largeur; x++)
                        Console.Write(' ');
                    Thread.Sleep(1);
                }

                for (int x = 0; x < _largeur; x++)
                {
                    Console.BackgroundColor = (ConsoleColor)(x % 16);
                    for (int y = 0; y < _hauteur; y++)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(' ');
                    }
                    Thread.Sleep(1);
                }
            }
        }



        void Parcours()
        {
            int x = 0;
            int y = 0;
            Init();

            Console.BackgroundColor = ConsoleColor.Red;

            for (; x < _largeur - 1; x++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(' ');
                Thread.Sleep(1);
            }

            for (; y < _hauteur - 1; y++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(' ');
                Thread.Sleep(1);
            }

            for (; x > 0; x--)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(' ');
                Thread.Sleep(1);
            }

            for (; y > 0; y--)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(' ');
                Thread.Sleep(1);
            }


        }

        void Init(int back = (int) ConsoleColor.DarkBlue, int fore = (int)ConsoleColor.Yellow)
        {
            Console.BackgroundColor = (ConsoleColor) back;
            Console.ForegroundColor = (ConsoleColor)fore;
            Util.ViderEcran();
        }


    }
}
