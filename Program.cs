namespace atelier2C6_101_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool go = true;
            while (go)
            {
                util.titre("Atelier 2C6 gr 101\n__________________________________");
                AfficherMenu();
                ExecuterChoix();
            }
        }


        static void ExecuterChoix()
        {
            char choix = util.SaisirChar();
            string option = choix.ToString().ToUpper();

            switch(option)
            {
                case ("F"):
                    ExecFinancier();
                    break;
                case ("H"):
                    ExecHumanite();
                    break;
                case ("Q"):
                default:
                    Environment.Exit(0);
                    break;
            }
        }
        static void ExecFinancier()
        {
            financier fin = new financier();
            fin.exec();
        }
        static void ExecHumanite()
        {
            Console.WriteLine("Humanité");

            humain h1 = new humain("Albert", new DateTime(1889, 1, 1));
            h1.Afficher();



            util.pause();
        }

        static void AfficherMenu()
        {
            Console.WriteLine("f- Financier");
            Console.WriteLine("h- Humanité");
            Console.WriteLine("q- Quitter");
            Console.Write("\nvotre choix:");
        }

    }
}
