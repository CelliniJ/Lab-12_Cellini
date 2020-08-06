using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_Cellini
{
    class DVD : Movie
    {
        public DVD(string Title, Genre Category, int RunTime, List<string> Scenes)
        {

        }

        public override void Play()
        {
            Console.WriteLine("\nWhat scene would you like to watch?:");
            PrintScenes();
            int select = int.Parse(Console.ReadLine());

            for (int i = 0; i < Scenes.Count; i++)
            {
                if (select == i)
                {
                    Console.WriteLine(Scenes[i]);
                }
            }

        }
    }
}
