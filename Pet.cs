namespace ParprogrammeringUke5
{
    internal class Pet : IItem
    {
        public string Name { get; set; }
        public Pet(string name)
        {
            Name = name;
        }
    }
}
