namespace ParprogrammeringUke5
{
    internal class Wand : IItem
    {
        public string Name { get; set; }
        ConsoleColor Color { get; set; }
        public Wand(string name, ConsoleColor color)
        {
            Name = name;
            Color = color;
        }
        public void CastSpell(string message)
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
