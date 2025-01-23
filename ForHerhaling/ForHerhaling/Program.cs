namespace ForHerhaling
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
            double[] prijzen = new double[] { 0.99, 5.60, 10.11, 2.69 };

            string[] artiekelen = { "snoepjes", "luxe broodjes", "lunch menu", "chess burger" };

            Formulier[] formulieren = new Formulier[2];

            formulieren[0] = new Formulier()
            {
                Feedback = "'Prijzig maar lekker.'",
                Sterren = 5
            };

            formulieren[1] = new Formulier()
            {
                Feedback = "'Ziet er veel aantrekelijker uit dan het smaakt.'",
                Sterren = 2
            };

            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.WriteLine("$" + prijzen[i]);
                Console.WriteLine(artiekelen[i]);
            }

            foreach (Formulier formulier in formulieren)
            {
               Console.WriteLine(formulier.Feedback);
                Console.WriteLine(formulier.Sterren + " sterren");
            }
        }
    }
}
