namespace MemSave
{
    internal class Program
    {
        string saveFile = "welkomState.txt";

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        internal void Run()
        {
            string welkomstTekst = "hello world";
            bool beastaatDeFile = File.Exists(saveFile);

            if (beastaatDeFile)
            {
                Console.WriteLine("Hij beastaat");
                File.ReadAllText(saveFile);
            }
            else
            {
                Console.WriteLine("Hij niet bestaat");
            }

            while (true)
            {
                Console.WriteLine("Enter a text, then press enter");
                welkomstTekst = Console.ReadLine();
                Console.WriteLine(welkomstTekst);
                File.WriteAllText(saveFile, welkomstTekst);
               
            }
        }
    }
}
