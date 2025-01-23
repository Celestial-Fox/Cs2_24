using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Quiz
    {
        internal QuizVraag[] vragen;
        internal QuizVraagAntwoord[] ingevuldeAntwoorden;

        internal Quiz(int aantalVragen, int aantalIngevuldeAntwoorden)
        {
            vragen = new QuizVraag[aantalVragen];
            ingevuldeAntwoorden = new QuizVraagAntwoord[aantalIngevuldeAntwoorden];
        }

        internal void VoegVraagToeOpindex(int index, QuizVraag vraag)
        {
            vragen[index] = vraag;
        }

        internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
        {

        }
    }
}
