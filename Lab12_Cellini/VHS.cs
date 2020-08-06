using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_Cellini
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string Title, Genre Category, int RunTime, List<string> Scenes)
        {
       
        }

        public override void Play()
        {
            for (int i = CurrentTime; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i + 1} is {Scenes[i]}");
            }
            CurrentTime++;
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
