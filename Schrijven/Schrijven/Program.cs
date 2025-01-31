namespace Schrijven
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
            string path = @"C:\Users\steal\OneDrive - Mediacollege Amsterdam\ma\bewijzenmap\periode1.2\prg\C#\Schrijven\Schrijven\mijnregels.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Yellow leaves in the wind.", "Fluttering by beyond reach.", "Forever lost to fate.");
                    
                }
            }

            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            

        }


    }
}
