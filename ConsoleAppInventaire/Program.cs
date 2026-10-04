namespace ConsoleAppInventaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Combien d'objets voulez-vous stocker ? ");
            int nombreObjets = int.Parse(Console.ReadLine());

            double poidsTotal = 0;
            int objetsLourds = 0;
            int objetsLegers = 0;

            for (int i = 1; i <= nombreObjets; i++)
            {
                Console.Write("Poids de l'objet " + i + " en kg : ");
                double poids = double.Parse(Console.ReadLine());

                poidsTotal = poidsTotal + poids;

                if (poids > 5)
                {
                    objetsLourds++;
                }
                else
                {
                    objetsLegers++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Poids total : " + poidsTotal + " kg");
            Console.WriteLine("Nombre d'objets lourds : " + objetsLourds);
            Console.WriteLine("Nombre d'objets légers : " + objetsLegers);

            if (poidsTotal > 30)
            {
                Console.WriteLine("[SURCHARGE] Votre sac est trop lourd, vous ne pouvez pas courir !");
            }
            else
            {
                Console.WriteLine("[OK] Votre inventaire est prêt pour l'aventure !");
            }
        }
    }
}
