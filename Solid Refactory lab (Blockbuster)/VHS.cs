using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_Refactory_lab__Blockbuster_
{
    class VHS : IPlay
    {
        public int CurrentTime { get; set; } = 0;
        public void Play(List<string> Scenes)
        {
            bool again = true;
            while (again == true)
            {
                if (CurrentTime < Scenes.Count)
                {
                    string scene = Scenes[CurrentTime];
                    Console.WriteLine($"Time ({CurrentTime}) : {scene}");
                    CurrentTime++;
                    Console.Write("\nWould you like to play next scene? Y/N");
                    string input = Console.ReadLine();

                    if (input.ToUpper() == "Y" || input.ToUpper() == "YES")
                    {
                        again = true;
                    }
                    else if (input.ToUpper() == "N" || input.ToUpper() == "NO")
                    {
                        again = false;
                    }
                }
                else
                {
                    Console.WriteLine("The movie has ended");
                    Rewind();
                    again = false;
                }
            }
        }
        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
