//-------------------------------
//  Fichier Util.cs
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
    internal class Util
    {
        public static string[] _noms = new string[] {"Esteban", "Etienne", "Raphael", "Liliane", "Samuel", "Félix", "Georges",
        "Charles-Etienne", "Fernando", "Nizar"};

        public static Random rdm = new Random();

        public const int ERR_DATE_NULLE = -1;
        public const int ERR_DATE_INCOMPLETE = -2;
        public const int ERR_ANNEE_HORS_LIMITE = -3;
        public const int ERR_ANNEE_INVALIDE = -4;
        public const int ERR_MOIS_HORS_LIMITE = -5;


        //-------------------------------
        //
        //-------------------------------
        public static void ViderEcran()
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
        }

        //-------------------------------
        //
        //-------------------------------
        public static void Titrer(string leTitre)
        {
            ViderEcran();
            Console.WriteLine(leTitre);
            for(int i = 0; i < leTitre.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();    
        }

        //-------------------------------
        //
        //-------------------------------
        public static char SaisirChar()
        {
            ConsoleKeyInfo keyInfo;
            keyInfo = Console.ReadKey();
            return keyInfo.KeyChar;
        }

        //-------------------------------
        //
        //-------------------------------
        public static double SaisirUnDouble(string nomDuDouble)
        {
            Console.WriteLine(nomDuDouble + ":");
            string? input = Console.ReadLine();


            if (double.TryParse(input, out double resultat))
            {
                return resultat;
            }
            return 0.0;
        }

        //-------------------------------
        //
        //-------------------------------
        public static void Pause()
        {
            Console.WriteLine(" appuyer une touche...");
            Console.ReadKey();
        }

        //-------------------------------
        //
        //-------------------------------
        public static void SepST(string s)
        {
            Console.WriteLine("------------" + s + "------------");
        }
        //-------------------------------
        //
        //-------------------------------
        public void Sep(string s)
        {
            Console.WriteLine("***********" + s + "************");
        }

    }
}
