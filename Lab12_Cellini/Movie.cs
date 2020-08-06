using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Lab12_Cellini
{
    abstract class Movie
    {
        public enum Genre
        {
            Drama,
            Comedy,
            Horror,
            Romance,
            Action
        }

        #region properties
        public string Title { get; set; }

        public Genre Category { get; set; }

        public int RunTime { get; set; }

        public List<string> Scenes { get; set; } = new List<string>() { };
        #endregion

        #region constructors
        public Movie() { }

        public Movie(string Title, Genre Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }
        #endregion


        #region methods
        public virtual void PrintInfo()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Category);
            Console.WriteLine(RunTime + "minutes");
        }

        public void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i} is {Scenes[i]}");
            }
        }

        public abstract void Play();
        #endregion

    }
}
