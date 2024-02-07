using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_101_2024
{
    internal class ExploFichier
    {
        const string FICHIER_POPULATION = @"d:\alainm\bd\population.txt";
        static List<Humain> _lstHumains = new List<Humain>();
        public static void Exec()
        {
            Util.Titrer("Exploration de la lecture et chargement de fichiers");

            if (File.Exists(FICHIER_POPULATION))
            {
                StreamReader reader = File.OpenText(FICHIER_POPULATION);
                int numLigne = 0;
                string? ligneCourante;

                while(reader.Peek() > -1)
                {
                    ligneCourante = reader.ReadLine();
                    Humain humain = new Humain();
                    if (parsingHumain(ligneCourante, ref humain))
                    {
                        _lstHumains.Add(humain);    
                    }

                    //Console.WriteLine(ligneCourante);
                    numLigne++;
                }
                reader.Close();
                Console.WriteLine($"\n{numLigne} lignes lues");
                AfficherListeHumain();


            }
            else
            {
                //Console.WriteLine("ERREUR {0} : Fichier inexistant", FICHIER_POPULATION);
                Console.WriteLine($"ERREUR {FICHIER_POPULATION} : Fichier inexistant" );
            }
        }

        static bool parsingHumain(string? infoBrute, ref Humain humain)
        {
            if (infoBrute == null || infoBrute.Length == 0 )
                return false;

            int nbChamps = CompterNbChamps(infoBrute);

            if (nbChamps == 1)
            {
                humain = new Humain(infoBrute);
                return true;
            }

            if (nbChamps == 2)
            {
                string[] tabInfoBrute = infoBrute.Split(';');
                if (parsingDate(tabInfoBrute[1], out DateTime naissance))
                {
                    humain = new Humain(tabInfoBrute[0], naissance);
                    return true;
                }
            }
            if (nbChamps == 7)
            {
                string[] tabInfoBrute = infoBrute.Split(';');
                if (parsingDate(tabInfoBrute[1], out DateTime naissance))
                {
                    Adresse adresse = new Adresse(tabInfoBrute[2], tabInfoBrute[3], tabInfoBrute[4], tabInfoBrute[5], tabInfoBrute[6]);
                    humain = new Humain(tabInfoBrute[0], naissance, adresse);
                    return true;    
                }
            }
            return false;
        }

        static bool parsingDate(string dateBrute, out DateTime date)
        {

            date = new DateTime(1,1,1);  
            
            // Hypothese Deorges: empty ferait l'Affaire
            if (dateBrute == null || dateBrute.Length == 0) 
                return false;

            string[] tabInfoDate = dateBrute.Split("-");

            date = new DateTime(int.Parse(tabInfoDate[0]), int.Parse(tabInfoDate[1]), int.Parse(tabInfoDate[2]) );
            return true;    
        }

        static int CompterNbChamps(string info)
        {
            if (info.Length == 0)
                return 0;

            int compteur = 0;
            foreach (char ch in info)
            {
                if (ch == ';')
                    compteur++;
            }
            return compteur+1;    
        }

        static void AfficherListeHumain()
        {
            for (int i = 0; i < _lstHumains.Count; i++)
            {
                if (_lstHumains[i] != null)
                {
                    _lstHumains[i].Afficher();
                }
                else
                {
                    Console.WriteLine("humain nul");
                }
            }
        }

    }
}
