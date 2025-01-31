using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace ProductenLaden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.RunPlayer();
            
        }

        internal void Run()
        {
            string text = File.ReadAllText("Product.json");

            Product product = JsonSerializer.Deserialize<Product>(text);

            Console.WriteLine(product.Name);

            Console.WriteLine(product.Description);

            Console.WriteLine(product.Price);
        }
        internal void RunProducten()
        {
            string texten = File.ReadAllText("Producten.json");

            Product[] producten = JsonSerializer.Deserialize<Product[]>(texten);

            for (int i = 0; i < producten.Length; i++)
            {
                Console.WriteLine(producten[i].Name);

                Console.WriteLine(producten[i].Description);

                Console.WriteLine(producten[i].Price);
            }
        }

        internal void RunPlayer()
        {
            string text = File.ReadAllText("Player.json");

            Player[]  player = JsonSerializer.Deserialize<Player[]>(text);

            for (int i = 0; i < player.Length; i++)
            {
                Console.WriteLine(player[i].Name);

                Console.WriteLine(player[i].Lvl);

                Console.WriteLine(player[i].Job);

                Console.WriteLine(player[i].Race);

                Console.WriteLine(player[i].Age);
            }
        }
    }
}
