

namespace ParprogrammeringUke5
{
    internal class Character
    {
        public string Name { get; set; }
        public string House { get; set; }
        public List<IItem> Inventory { get; set; }
        public Wand EquippedWand { get; set; }

        public Character(string name, string house)
        {
            Name = name;
            House = house;
            Inventory = new List<IItem>();
        }
        public void Select()
        {
            PrintInfo();
            Menu();
        }
        public void PrintInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(House);
            PrintInvntory();
        }
        public void PrintInvntory()
        {
            Console.Write("Inventory: ");
            for (int i = 0; i < Inventory.Count; i++)
            {
                if (i == Inventory.Count - 1) Console.Write($"{Inventory[i].Name}.\n");
                else Console.Write($"{Inventory[i].Name}, ");
            }
        }
        public void Menu()
        {
            bool inMenu = true;
            while (inMenu)
            {
                Console.WriteLine($"\nSelected character: {Name}");
                if (EquippedWand != null) Console.WriteLine($"Equipped wand: {EquippedWand.Name}");
                Console.WriteLine("\n[1] Go to magic shop");
                Console.WriteLine("[2] Perform magic");
                Console.WriteLine("[3] Show inventory");
                Console.WriteLine("[4] Equip different wand");
                Console.WriteLine("[5] Change selected character");
                var input = Console.ReadLine();
                    switch (input)
                    {
                        case "1": Shop.Menu(this); break;
                        case "2": SpellMenu(); break;
                        case "3": PrintInvntory(); break;
                        case "4": WandMenu(); break;
                        case "5": inMenu = false; break;
                    }
            }
        }
        public void WandMenu()
        {
            var purchasedWands = Inventory.Where(item => item is Wand).ToList();
            if (purchasedWands.Count > 0)
            {
                int selected;
                while (true)
                {
                    for (int i = 0; i < purchasedWands.Count; i++)
                    {
                        Console.WriteLine($"[{i + 1}] {purchasedWands[i].Name}");
                    }
                    string input = Console.ReadLine();
                    bool output = Int32.TryParse(input, out selected);
                    if (output && selected >= 1 && selected <= purchasedWands.Count)
                    {
                        EquippedWand = (Wand)purchasedWands[selected - 1];
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
            }
            else
            {
                Console.WriteLine("You don't have any wands!");
            }
        }
        public void SpellMenu()
        {
            if (!HasWand())
            {
                Console.WriteLine("You don't have a wand! Go to the shop to purchase one.");
                return;
            }
            Console.WriteLine("\nWrite a spell correctly to cast it!");
            var input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "wingardium leviosa": EquippedWand.CastSpell("You made a feather fly."); break;
                case "lumos": EquippedWand.CastSpell("The tip of your wand lights up."); break;
                case "expelliarmus": EquippedWand.CastSpell("A random stranger on the street's wand flew out of his hand!"); break;
                case "riddikulus": EquippedWand.CastSpell("The Boggart in front of you turned into a balloon animal!"); break;
                default: Console.WriteLine("Not a valid spell"); break;
            }
        }
        bool HasWand()
        {
            return Inventory.OfType<Wand>().Any();
        }
    }

}
