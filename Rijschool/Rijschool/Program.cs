namespace Rijschool
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
            Auto auto1 = new Auto()
            {
                automaat = true,
                kenteken = "AA824H",
                kilometerStand = 20567,
                merk = "volkswagen"
            };

            Auto auto2 = new Auto()
            {
                automaat = false,
                kenteken = "KU786G",
                kilometerStand = 65739,
                merk = "volvo"
            };

            RijLeraar rijleraar = new RijLeraar()
            {
                leeftijd = 30,
                naam = "John",
                zzp = false
            };

            Student student1 = new Student()
            {
                naam = "Mellisa",
                leeftijd = 19,

                rijleraar = rijleraar,


            };

            Student student2 = new Student()
            {
                naam = "Bart",
                leeftijd = 25,

                rijleraar = rijleraar,


            };

            LesUur lesUur1 = new LesUur()
            {
                auto = auto1,
                rijleraar = rijleraar,
                student = student1,
                tijd = 1130
            };

            LesUur lesUur2 = new LesUur()
            {
                auto = auto2,
                rijleraar = rijleraar,
                student = student2,
                tijd = 1130
            };

            Dag dag = new Dag()
            {
                datum = DateTime.Today,
                lesuren = new LesUur[] {lesUur1, lesUur2},
            };
        }
    }
}
