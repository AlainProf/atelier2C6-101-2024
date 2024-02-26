//-------------------------------
//  Fichier Program.cs
//  Auteur: Alain Martel
//  Création: 2024-01-31 
//-------------------------------

using Atelier2C6_101_2024.Application;
using Atelier2C6_101_2024.Classes;
using Atelier2C6_101_2024.Connect4;
using Atelier2C6_101_2024.Exploration;

namespace Atelier2C6_101_2024
{
    internal class Program
    {
        static int _nbRang =0;
        static int _nbCol = 0;
        static Util u = new Util();
        //--------------------------------------------
        //
        //--------------------------------------------
        static void Main(string[] args)
        {
            bool ExecOK = true;
            try 
            {
              TraiterParam(args);
              Ecran ecran = new Ecran();
               ecran.Init(0,15);
               bool go = true;
               while (go)
               {
                u.Titrer("Atelier 2C6 gr 101");
                AfficherMenu();
                ExecuterChoix();
                go = false;
               }
            }
            catch(ArgumentOutOfRangeException e)
            {
                ExecOK = false;
                Console.WriteLine($"ERREUR indice dépasse la taille d'un tableau {e.Message}");
            }
            catch (FileNotFoundException e)
            {
                ExecOK = false;
                Console.WriteLine($"{e.Message}");
            }
            catch(FormatException e)
            {
                ExecOK = false;
                Console.WriteLine($"Une conversion a échoué {e.Message}");
            }
            catch (Exception e)
            {
                ExecOK = false;
                Console.WriteLine($"Une exception inconnue est survenue {e.Message}");
            }
            finally 
            {
                if (ExecOK)
                {
                    Console.WriteLine("Fin normale!");
                }
                else
                {
                    Console.WriteLine("ATTENTION Programme avorté...");    
                }
                //Console.WriteLine("Derniere du prog");
            }
        }

        //-------------------------------
        //
        //-------------------------------
        static void TraiterParam(string[] tabParams)
        {
            if (tabParams.Length == 0) 
            {
                return;
            }
            Console.WriteLine($"{tabParams.Length} paramètres:");
            for (int i = 0; i < tabParams.Length; i++) 
            {
                Console.WriteLine($"args[{i}]: {tabParams[i]}");
            }

            Console.WriteLine($"Largeur: {(Console.WindowWidth / 4) -1}");
            Console.WriteLine($"Hauteur: {(Console.WindowHeight -6) -1 }");


            _nbCol = int.Parse(tabParams[0]);
            _nbRang = int.Parse(tabParams[1]);

            if (_nbCol > Console.WindowWidth / 4)
            {
                //throw (new Exception($"Param 0 trop grand maximum = {Console.WindowWidth / 4}"));
            }
            if (_nbRang > Console.WindowHeight - 6)
            {
                //throw (new Exception($"Param 1 trop grand maximum = {Console.WindowHeight - 6}"));
            }
            u.Pause();
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
            Console.WriteLine("A- tAbleau 2D");
            Console.WriteLine("P- Pile et File (Stack % Queue");

            Console.WriteLine();

            Console.WriteLine("Q- Quitter");
            Console.Write("\nvotre choix:");
        }



        //-------------------------------
        //
        //-------------------------------
        static void ExecuterChoix()
        {
            char choix = u.SaisirChar();
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
                    ExploTableau();
                    break;
                case ("L"):
                    ExploListe();
                    break;
                case ("E"):
                    ExploFichier();
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
                case ("A"):
                    ExecTableau2D();
                    break;
                case ("P"):
                    ExecPileFile();
                    break;

                case ("Q"):
                default:
                    Environment.Exit(0);
                    break;
            }
        }

        //--------------------------------------------
        //
        //--------------------------------------------
        static void ExploFichier()
        {
            ExploFichier exploFichier = new ExploFichier();
            exploFichier.Exec();
        }
        //--------------------------------------------
        //
        //--------------------------------------------
        static void ExploTableau()
        {
            ExploTableau exploTableau = new ExploTableau();
            exploTableau.Exec();
          
        }
        //--------------------------------------------
        //
        //--------------------------------------------
        static void ExploListe()
        {
            ExploListe exploListe = new ExploListe();
            exploListe.Exec();
          
        }


        //-------------------------------
        //
        //-------------------------------
        static void ExecPileFile()
        {
            u.Titrer("Piles et Files en C#");

            Queue<Voiture> laveAuto = new Queue<Voiture>();

            Voiture vA = new Voiture();
            vA._Marque = "GT3 RS";
            vA._Couleur = "noire";
            Voiture vB = new Voiture();
            vB._Marque = "Ford Focus";
            vB._Couleur = "blanche";
            Voiture vC = new Voiture();
            vC._Marque = "Pinto";
            vC._Couleur = "mauve";

            laveAuto.Enqueue(vA);
            laveAuto.Enqueue(vB);
            laveAuto.Enqueue(vC);


            Console.WriteLine("-----Sortie du lave auto-----------");


            Voiture vPropre = laveAuto.Dequeue();
            vPropre.Afficher();

            vPropre = laveAuto.Dequeue();
            vPropre.Afficher();

            vPropre = laveAuto.Dequeue();
            vPropre.Afficher();

            Stack<Voiture> _AlleeStationnement = new Stack<Voiture>();

            Console.WriteLine("------Sortie du stationnement----------");

            _AlleeStationnement.Push(vA);
            _AlleeStationnement.Push(vB);
            _AlleeStationnement.Push(vC);

            Voiture vQuittante;
            vQuittante = _AlleeStationnement.Pop();
            vQuittante.Afficher();
            vQuittante = _AlleeStationnement.Pop();
            vQuittante.Afficher();
            vQuittante = _AlleeStationnement.Pop();
            vQuittante.Afficher();
        }

        //-------------------------------
        //
        //-------------------------------
        static void ExecTableau2D()
         {
            u.Titrer("Tableau à deux dimension en C#");
            Tableau2D tab2D = new Tableau2D(_nbCol, _nbRang);

            tab2D.Afficher();
            u.Pause();

            u.Titrer("Affichage horizontal"); 
            tab2D.AfficherHorizontalement();
            u.Pause();

            u.Titrer("Affichage vertical");
            tab2D.AfficherVertical();
            u.Pause();

            u.Titrer("Affichage aléatoire");
            tab2D.AfficherAleatoire();
            u.Pause();

        }
        //-------------------------------
        //
        //-------------------------------
        static void ExecHeritage()
            {
                u.Titrer("Héritage en C#");
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
            u.Titrer("Exemple d'utilisation de ref et out");

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
            u.Titrer("Humanité");

            Humain h1 = new Humain("Albert", new DateTime(1889, 1, 1));
            //h1.Afficher();

            Humain h2 = new Humain("Béatrice");
            //h2.Afficher();

            Humain h3 = new Humain();
            //h3.Afficher();
            u.Pause();
        }
    }
}
