using System;

class Program
{
    public static void Main(string[] args)
    {
        int nombre = 0;
        int nombreDonne = 0;
        Random rnd = new Random();

        nombre = rnd.Next(0, 1000);
        Console.WriteLine("Devinez le nombre entre 0 et 1000 :");
      Console.WriteLine("Écrivez un premier nombre pour commencer");

        while (nombreDonne != nombre)
        {
            nombreDonne = Convert.ToInt32(Console.ReadLine());

            if (nombreDonne > nombre)
            {
                Console.WriteLine("Votre nombre est supérieur au nombre à trouver.");
            }
            else if (nombreDonne < nombre)
            {
                Console.WriteLine("Votre nombre est inférieur au nombre à trouver.");
            }
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Bravo, vous avez trouvé le nombre !");
    }
}
