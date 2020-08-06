using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_Cellini
{
    class Blockbuster
    {
        public static void Main(string[] args)
        {
            List<Movie> Movies = new List<Movie>();
            VHS Shrek = new VHS("Shrek", Movie.Genre.Comedy, 90, new List<string>() { "Donkey", "Shrek does stuff" });
            Movies.Add(Shrek);

            DVD SavingPrivateRyan = new DVD("Saving Private Ryan", Movie.Genre.Drama, 104, new List<string>() { "Half of them all die", 
            "They save Private Ryan" });
            Movies.Add(SavingPrivateRyan);
            SavingPrivateRyan.Play();

            Shrek.Play();
            Console.WriteLine("Welcome to GC Blockbuster!");
            Console.WriteLine();
        }

        public static void PrintMovies(List<Movie> Movies)
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"{i}. {Movies[i]}");
            }
        }
        public override void PrintInfo()
        {
         
        }

        public static void CheckOut(List<Movie> Movies)
        {
            PrintMovies(Movies);
            Console.WriteLine("Which movie would you like to check out?:");
            int select = int.Parse(Console.ReadLine());

            for (int i = 0; i < Movies.Count; i++)
            {
                if (select == i)
                {
                    PrintInfo();
                }
            }
        }

    }
}
