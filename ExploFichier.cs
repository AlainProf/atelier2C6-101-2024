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
            //EcritureDUneListe();
            ChargementDUneListe();
        }

        static void EcritureDUneListe()
        {
            Util.Titrer("Ecriture d'une liste d'humains");
            StreamWriter writer = new StreamWriter(FICHIER_POPULATION);
            int MAX_HUMAINS = 100;   
            int compteur = 0;
            StringBuilder infoHumain = new StringBuilder(); 

            while(compteur<MAX_HUMAINS)
            {
                compteur++;

                string nom = Util._noms[Util.rdm.Next(0, 10)];
                infoHumain.Append(nom);

                infoHumain.Append(";");
                infoHumain.Append(new DateTime(Util.rdm.Next(1964, 2005), 
                                               Util.rdm.Next(1,13), 
                                               Util.rdm.Next(1,29)).ToShortDateString());
                writer.WriteLine(infoHumain.ToString());
                infoHumain = new StringBuilder();
            }
            writer.Close();

            Console.WriteLine($"Production d'une liste de {MAX_HUMAINS} humains");
        }


      static void ChargementDUneListe()
      { 
            Util.Titrer("Chargement de la nouvelle liste");
            int codeErr = (int)Util.ERREUR.AUCUNE_ERREUR;

            
                if (File.Exists(FICHIER_POPULATION))
                {
                    StreamReader reader = File.OpenText(FICHIER_POPULATION);
                    int numLigne = 0;
                    int ligneCorrectes = 0;
                    string? ligneCourante;

                    while (reader.Peek() > -1)
                    {
                        numLigne++;
                        ligneCourante = reader.ReadLine();
                        Humain humain = new Humain();
                        //Console.WriteLine($"Ligne {numLigne}: {ligneCourante} ");
                        if (parsingHumain(ligneCourante, ref humain, ref codeErr))
                        {
                            _lstHumains.Add(humain);
                            ligneCorrectes++;
                        }
                        else
                        {
                            Console.WriteLine($"ERREUR {codeErr} {(Util.ERREUR)codeErr} : (ligne {numLigne}) : {ligneCourante}  ");
                        }
                        //Console.WriteLine(ligneCourante);

                    }
                    reader.Close();

                    _lstHumains.Sort(Humain.comparerAge);
                    Console.WriteLine($"\n{numLigne} lignes lues\n{ligneCorrectes} lignes correctes");
                    AfficherListeHumain();
                }
                else
                {
                    //Console.WriteLine("ERREUR {0} : Fichier inexistant", FICHIER_POPULATION);
                    Console.WriteLine($"ERREUR {FICHIER_POPULATION} : Fichier inexistant");
                }

        }

        static bool parsingHumain(string? infoBrute, ref Humain humain, ref int codeErr)
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
                if (parsingDate(tabInfoBrute[1], out DateTime naissance, ref codeErr))
                {
                    humain = new Humain(tabInfoBrute[0], naissance);
                    return true;
                }
                else
                {
                    return false;   
                }
            }
            if (nbChamps == 7)
            {
                string[] tabInfoBrute = infoBrute.Split(';');
                if (parsingDate(tabInfoBrute[1], out DateTime naissance,ref codeErr ))
                {
                    Adresse adresse = new Adresse(tabInfoBrute[2], tabInfoBrute[3], tabInfoBrute[4], tabInfoBrute[5], tabInfoBrute[6]);
                    humain = new Humain(tabInfoBrute[0], naissance, adresse);
                    return true;    
                }
                else
                {
                    Console.WriteLine($"ERREUR {codeErr} {(Util.ERREUR)codeErr} ");
                    return false;
                }

            }
            return false;
        }

        static bool parsingDate(string dateBrute, out DateTime date, ref int codeErr)
        {
            int an;
            int mois;
            int jour;

            date = new DateTime(1,1,1);

            // Hypothese Deorges: empty ferait l'Affaire
            if (dateBrute == null || dateBrute.Length == 0)
            {
                codeErr = (int) Util.ERREUR.ERR_DATE_NULLE;
                return false;
            }

            string[] tabInfoDate = dateBrute.Split("-");

            if (tabInfoDate.Length != 3)
            {
                codeErr = (int)Util.ERREUR.ERR_DATE_INCOMPLETE;
                return false;
            }

            if (int.TryParse(tabInfoDate[0], out an))
            {
                if (an < 1 || an > 9999)
                {
                    codeErr = (int)Util.ERREUR.ERR_ANNEE_HORS_LIMITE;
                    return false;
                }
            }
            else
            {
                codeErr = (int)Util.ERREUR.ERR_ANNEE_INVALIDE;
                return false;
                
            }

            if (int.TryParse(tabInfoDate[1], out mois))
            {
                if (mois > 12 || mois < 1)
                {
                    codeErr = (int)Util.ERREUR.ERR_MOIS_HORS_LIMITE;
                    return false;
                }

            }
            else
            {
                codeErr = (int)Util.ERREUR.ERR_MOIS_INVALIDE;
                return false;
            }

            if (int.TryParse(tabInfoDate[2], out jour))
            {
                if (jour < 1 || jour > 28)
                {
                    codeErr = (int)Util.ERREUR.ERR_JOUR_HORS_LIMITE;
                    return false;
                }
            }
            else
            {
                codeErr = (int)Util.ERREUR.ERR_JOUR_INVALIDE;
                return false;
            }

            date = new DateTime(an, mois, jour);
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
                  //  _lstHumains[i].Afficher();
                }
                else
                {
                    Console.WriteLine("humain nul");
                }
            }
        }


    }
}
