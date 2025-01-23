namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        internal void Run()
        {
            //01 Lists maken
            string[] characters =
            {
            "Samus",
            "Pac-man",
            "Crash Bandicoot",
            "Spyro the Dragon",
            "Donkey Kong",
            "Mario",
            "Luigi",
            "Astro",
            "Solid Snake",
            "Master Chief",
            "Kratos",
            "Sonic the Hedgehog",
            "Link",
            " "
            };

            List<string> characterList = new List<string>();
            characterList.Add("Zelda");

            foreach (string name in characters)
            {
                characterList.Add(name);
            }
            int p = new int();
            for (int i = 0; i < characterList.Count; i++)
            {
                Console.WriteLine(characterList[i]);
            }

            foreach (string item in characterList)
            {
                
                Console.WriteLine(characterList[p]);
                p++;
            }

            //02 Remove
            List<double> reviews = new List<double>() { 9.99, 4.68, 342.97, 12.2 };

            reviews.Remove(342.97);

            reviews.RemoveAt(0);

            for (int i = 0; i < reviews.Count; i++)
            {
                Console.WriteLine(reviews[i]);
            }

            //03 Remove in Loop.
            

            List<Pickup> pickups = new List<Pickup>();

            for (int i = 0; i < 10; i++)
            {
                Pickup pickup = new Pickup()
                {
                    x = i,
                    y = 0
                };

                pickups.Add(pickup);
            }

            //foreach (Pickup pickup in pickups)
            //{
            //    if (pickup.x == 4)
            //    {
            //        pickups.Remove(pickup);
            //    }
            //}

            for (int i = pickups.Count -1; i >= 0 ; i--)
            {
                if (i == 4)
                {
                    pickups.RemoveAt(i);
                    Console.WriteLine("Pickup " + i + " has been removed");
                } else {
                    Console.WriteLine("Pickup " + i + " is still here");
                }

            }

            //04 linq
            List<string> mobs = new List<string>() { "Goblin", "Orc", "Ogre" };

            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                foreach (Mob mob in mobs) 
                {
                    random.Next();
                    if (random.Next() < 30)
                    {

                        mob.DoDamage(1);
                    }
                }
            }
        }

    }
}
