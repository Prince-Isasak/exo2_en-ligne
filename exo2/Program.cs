using System;

namespace exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var NombreMaqique = 5;
                Console.WriteLine("entrer un nombre");
                var Uitilsateur = Console.ReadLine();
                var user = Convert.ToInt32(Uitilsateur);


                if (user > NombreMaqique)
                {
                    Console.WriteLine("Ce nombre est trop grand");
                }
                else if (user < NombreMaqique)
                {
                    Console.WriteLine("Ce nombre est trop petit");
                }
                else
                {
                    Console.WriteLine("Bravo vous avez trouvé le nombre magique");
                }
            }
            catch 
            {
                Console.WriteLine("entrer un nombre svp");

            }

            
        }
    }
}
