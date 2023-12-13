using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParprogrammeringUke5
{
    internal class MainMenu
    {
        public List<Character> Characters = new List<Character>
            {
                new Character("Harry Potter", "Gryffindor"),
                new Character("Hermione Granger", "Gryffindor"),
                new Character("Voldemort", "Slytherin"),
            };
        public void Run()
        {
            int selected;
            while (true)
            {
                Console.WriteLine("Choose a character");
                for (int i = 0; i < Characters.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] - {Characters[i].Name}");
                }
                var input = Console.ReadLine();
                bool output = Int32.TryParse(input, out selected);
                if (output && selected >= 1 && selected <= Characters.Count)
                {
                    Characters[selected - 1].Select();
                }
            }
        }
    }
}
