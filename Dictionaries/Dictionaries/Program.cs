namespace Dictionaries
{
    internal class Program
    {
        Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();

        Dictionary<string, Room> rooms = new Dictionary<string, Room>();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        internal void Run()
        {
            personeelOpNummer.Add(382942, "Jim");
            personeelOpNummer.Add(789432, "Tim");

            string jim = personeelOpNummer[382942];
            string tim = personeelOpNummer[789432];
            foreach (KeyValuePair<int,string> item in personeelOpNummer)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            foreach (int key in personeelOpNummer.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (string value in personeelOpNummer.Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("");
            //breakline

            Room room0 = new Room(0, 0, [
                "xxxxx",
                "x   x",
                "x   x",
                "x   x",
                "xxxxx"
                ]);
            Room room1 = new Room(0, 1, [
                "  x  ",
                " xx  ",
                "x x  ",
                "  x  ",
                "xxxxx"
                ]);
            Room room2 = new Room(1, 0, [
                "xxxxx",
                "    x",
                "xxxxx",
                "x    ",
                "xxxxx"
                ]);
            Room room3 = new Room(1, 1, [
                "xxxxx",
                "    x",
                "xxxxx",
                "    x",
                "xxxxx"
                ]);

            rooms.Add(room0.GetRoomLocationKey(), room0);
            rooms.Add(room1.GetRoomLocationKey(), room1);
            rooms.Add(room2.GetRoomLocationKey(), room2);
            rooms.Add(room3.GetRoomLocationKey(), room3);

            ShowRoom(0, 0);
            ShowRoom(0, 1);
            ShowRoom(1, 0);
            ShowRoom(1, 1);
            ShowRoom(2, 0);
        }

        private void ShowRoom(int x, int y)
        {
            Room room = rooms[$"{x},{y}"];

            

            bool hasRoom = rooms.ContainsKey($"{x},{y}");

            if (hasRoom)
            {
                Console.WriteLine($"You are in room {x},{y}");
                foreach (string r in room.level)
                {
                    Console.WriteLine(r);
                }
            } else {
                Console.WriteLine($"Warning! Room Does not exist.");
            }
        }


        class Room
        {
            internal int x, y;
            internal string[] level;

            internal Room(int x, int y, string[] level)
            {
                this.x = x;
                this.y = y;
                this.level = level;
            }

            

            internal string GetRoomLocationKey()
            {
                return $"{x},{y}";
            }

            
        }
    }
}
