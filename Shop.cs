namespace ParprogrammeringUke5
{
    internal class Shop
    {
        public static void Menu(Character character)
        {
            Console.WriteLine("\nWelcome to the Magic Shop!");
            bool inShop = true;
            while (inShop) {
                Console.WriteLine("[1] Pets");
                Console.WriteLine("[2] Wands");
                Console.WriteLine("[3] Leave shop");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1": PetMenu(character); break;
                    case "2": WandMenu(character); break;
                    case "3": inShop = false; break;
                    default: Console.WriteLine("Invalid input!\n"); break;
                }
            }
        }
        public static void PetMenu(Character character)
        {
            Console.WriteLine("\nSelect your preferred pet:");
            bool inShop = true;
            while (inShop)
            {
                Console.WriteLine("[1] Owl");
                Console.WriteLine("[2] Rat");
                Console.WriteLine("[3] Cat");
                Console.WriteLine("[4] Cancel");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        character.Inventory.Add(new Pet("Owl"));
                        Console.WriteLine("You purchased an owl!");
                        inShop = false;
                        break;
                    case "2":
                        character.Inventory.Add(new Pet("Rat"));
                        Console.WriteLine("You purchased a rat!");
                        inShop = false;
                        break;
                    case "3":
                        character.Inventory.Add(new Pet("Cat"));
                        Console.WriteLine("You purchased a cat!");
                        inShop = false;
                        break;
                    case "4": inShop = false; break;
                    default: Console.WriteLine("Invalid input!\n"); break;
                }
            }
        }
        public static void WandMenu(Character character) {
            Console.WriteLine("\nSelect your preferred wand:");
            bool inShop = true;
            while (inShop)
            {
                Console.WriteLine("[1] Phoenix wand");
                Console.WriteLine("[2] Unicorn wand");
                Console.WriteLine("[3] Ogre wand");
                Console.WriteLine("[4] Cancel");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        PurchaseWand(new Wand("Phoenix wand", ConsoleColor.Red), character);
                        Console.WriteLine("You purchased a phoenix wand!");
                        inShop = false;
                        break;
                    case "2":
                        PurchaseWand(new Wand("Unicorn wand", ConsoleColor.Magenta), character);
                        Console.WriteLine("You purchased a unicorn wand!");
                        inShop = false;
                        break;
                    case "3":
                        PurchaseWand(new Wand("Ogre wand", ConsoleColor.Green), character);
                        Console.WriteLine("You purchased an ogre wand!");
                        inShop = false;
                        break;
                    case "4": inShop = false; break;
                    default: Console.WriteLine("Invalid input!\n"); break;
                }
            }
        }
        public static void PurchaseWand(Wand wand, Character character)
        {
            character.Inventory.Add(wand);
            if (character.EquippedWand == null)
            {
                character.EquippedWand = wand;
            }
        }
    }
}
