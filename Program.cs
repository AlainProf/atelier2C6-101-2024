namespace atelier2C6_101_2024
{
    internal class Program
    {
        static double detteInitiale;
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\n\n\n__________________________________\nLe Financier");

            saisirParametres();

            double tauxInteretAnnuel = 0.21;
            double tauxInteretMensuel = tauxInteretAnnuel / 12;

            Console.WriteLine("Dette initiale:" + detteInitiale + "$\nTaux intérêt annuel:" + tauxInteretAnnuel);

            bool go = true;
            int mois = 1;

            double interetCum = 0;
            double paiementCum = 0;
            double solde = detteInitiale;
            while (go)
            {
                double paiementMin = 0.04 * solde;
                double interetCourant = solde * tauxInteretMensuel;
                paiementCum += paiementMin;
                interetCum += interetCourant;

                if (mois % 10 == 0)
                {
                    Console.WriteLine(mois.ToString("N0").PadLeft(6) + " "
                               + solde.ToString("N2").PadLeft(9) + " "
                               + paiementMin.ToString("N2").PadLeft(7) + " "
                               + paiementCum.ToString("N2").PadLeft(9) + " "
                               + interetCourant.ToString("N2").PadLeft(7) + " "
                               + interetCum.ToString("N2").PadLeft(9));
                }
                solde -= paiementMin - interetCourant;
                mois++;



                if (solde < 1)
                    go = false;
            }
        }

        static void saisirParametres()
        {
            detteInitiale = saisirUnDouble("Montant de la dette");
            //Console.WriteLine("Votre dette saisie:" + dette + "$");

        }

        static double saisirUnDouble(string nomDuDouble)
        {
            Console.WriteLine(nomDuDouble + ":");
            string input = Console.ReadLine();


            if (double.TryParse(input, out double resultat))
            {
                return resultat;
            }
            else
                return 0.0;
        }
    }
}
