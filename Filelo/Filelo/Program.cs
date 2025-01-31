namespace Filelo
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
            //Console.WriteLine(Environment.CurrentDirectory);

            string[] lines = File.ReadAllLines("quiz.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }

            string[] news = File.ReadAllLines("dutchNews.txt");

            for (int i = 0; i < news.Length; i++)
            {
                Console.WriteLine(news[i]);
            }
        }
    }
}
