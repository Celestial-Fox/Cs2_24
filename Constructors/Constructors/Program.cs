namespace Constructors
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
            QuizVraag quizVraag = new QuizVraag("Hier komt de vraag", "Hier komt het antwoord");
            Quiz quiz = new Quiz(10,10);
        }
    }
}
