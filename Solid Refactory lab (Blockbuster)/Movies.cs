using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_Refactory_lab__Blockbuster_
{
    class Movies
    {
        public IPlay Play { get; set; }
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; }

        public Movies(string Title, Genre Category, int Runtime, List<string> Scenes, IPlay Play)
        {
            this.Title = Title;
            this.Category = Category;
            this.Runtime = Runtime;
            this.Scenes = Scenes;
            this.Play = Play;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Category: " + Category);
            Console.WriteLine("Run Time: " + Runtime);
        }

        public void PrintScenes()
        {
            Console.WriteLine("Scenes: ");
            foreach (string scene in Scenes)
            {
                Console.WriteLine(scene);
            }
        }

        public void Play1(List<string> Scenes)
        {
             Play.Play(Scenes);
        }

        public virtual void PlayWholeMovie()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                string scene = Scenes[i];
                Console.WriteLine($"{i}:{scene}");
            }
        }
    }
}
