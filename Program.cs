//-------------------------------
//  Fichier Program.cs
//  Auteur: Alain Martel
//  Création: 2024-01-31 
//-------------------------------

using Atelier2C6_101_2024.Connect4;

namespace Atelier2C6_101_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            { 
               Ecran ecran = new Ecran();
               ecran.Init(0,15);
               bool go = true;
               while (go)
               {
                Util.Titrer("Atelier 2C6 gr 101");
                AfficherMenu();
                ExecuterChoix();
                go = false;
               }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"{e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Une exception inconnue est survenue {e.Message}");
            }
            finally 
            {
                //Console.WriteLine("Derniere du prog");
            }

        }

        //-------------------------------
        //
        //-------------------------------
        static void AfficherMenu()
        {
            Console.WriteLine("F- Financier");
            Console.WriteLine("H- Humanité");
            Console.WriteLine("T- Tableau (explo)");
            Console.WriteLine("L- Liste (explo)");
            Console.WriteLine("E- Explo de fichiers");
            Console.WriteLine("R- ref et out, comme,t ça marche");
            Console.WriteLine("X- TicTacToe");
            Console.WriteLine("O- Connect 4 ");
            Console.WriteLine("D- Dessiner à la console ");
            Console.WriteLine("I- HérItage");

            Console.WriteLine();

            Console.WriteLine("Q- Quitter");
            Console.Write("\nvotre choix:");
        }



        //-------------------------------
        //
        //-------------------------------
        static void ExecuterChoix()
        {
            char choix = Util.SaisirChar();
            string option = choix.ToString().ToUpper();

            switch(option)
            {
                case ("F"):
                    ExecFinancier();
                    break;
                case ("H"):
                    ExecHumanite();
                    break;
                case ("T"):
                    ExploTableau.Exec();
                    break;
                case ("L"):
                    ExploListe.Exec();
                    break;
                case ("E"):
                    ExploFichier.Exec();
                    break;
                case ("R"):
                    ExploRefEtOut();
                    break;
                case ("X"):
                    PartieTicTacToe pTTT = new PartieTicTacToe();
                    pTTT.Jouer();
                    break;
                case ("O"):
                    PartieConnect4 pConn4 = new PartieConnect4();
                    pConn4.Jouer();
                    break;

                case ("D"):
                    Ecran ecran = new Ecran();
                    ecran.Exec();
                    break;

                case ("I"):
                    ExecHeritage();
                    break;


                case ("Q"):
                default:
                    Environment.Exit(0);
                    break;
            }
        }

        //-------------------------------
        //
        //-------------------------------
        static void ExecHeritage()
        { 
            Util.Titrer("Héritage en C#");
            Etudiant etuA = new Etudiant("1234567");
            etuA.Afficher();

            Etudiant etuB = new Etudiant("Gus", "7654321");
            etuB.Afficher();

            Etudiant etuC = new Etudiant("Bob", "22222222", new DateTime(2001, 9, 11));
            etuC.Afficher();

            Universitaire etuU = new Universitaire("Iossef Visarionovicth Djougachvili", "Sciences politique");
            etuU.Afficher();
        }


        //-------------------------------
        //
        //-------------------------------
        static void ExploRefEtOut()
        {
            Util.Titrer("Exemple d'utilisation de ref et out");

            int p = 10;
            Console.WriteLine($"valeur initiale de P:{p}");

            f1(p);
            Console.WriteLine($"post f1():{p}");
            f2(ref p);
            Console.WriteLine($"post f2():{p}");
            f3(p, out int pOut);
            Console.WriteLine($"post f3():{pOut}");
            pOut *= pOut;
            Console.WriteLine($"Le carré {pOut}");
        }

        static void f1(int p)
        {
            p++;
        }
        static void f2(ref int p)
        {
            p++;
        }
        static void f3(int p, out int pOut)
        {
            pOut = p;
            pOut++;
        }


        //-------------------------------
        //
        //-------------------------------
        static void ExecFinancier()
        {
            Financier fin = new Financier();
            fin.Exec();
        }
        //-------------------------------
        //
        //-------------------------------
        static void ExecHumanite()
        {
            Util.Titrer("Humanité");

            Humain h1 = new Humain("Albert", new DateTime(1889, 1, 1));
            //h1.Afficher();

            Humain h2 = new Humain("Béatrice");
            //h2.Afficher();

            Humain h3 = new Humain();
            //h3.Afficher();


            Util.Pause();
        }


    }
}
