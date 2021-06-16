using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_Refactory_lab__Blockbuster_
{
    class DVD : IPlay
    {
        public void Play(List<string> Scenes)
        {
            int index = 0;
            foreach(string Scene in Scenes)
            {
                Console.WriteLine($"{index} : {Scene}");
                index++;
            }
            Console.WriteLine($"Select what scene you'd like to watch: 0 to {Scenes.Count - 1}");
            string input = Console.ReadLine();
            int input2 = int.Parse(input);

            string scene = Scenes[input2];
            Console.WriteLine(scene);
        }
    }
}
