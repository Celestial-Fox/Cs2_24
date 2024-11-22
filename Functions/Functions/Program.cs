using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Text;
using System.Xml.Linq;
using System;
namespace Functions
{
    internal class Program
    {
        string[] vragen = new string[]
        {
            "What 1997 N64 video game features James Bond and is named after the 1995 film?",
            "What arcade game was called puckman in Japan?",
            "In July 2023, video game company EA announced that players will be able to explore Wakanda in an upcoming open-world video game based on the adventures of what Marvel superhero?",
            "Which spooky 2001 GameCube game starring Mario’s brother got a reboot for Nintendo Switch in 2019?",
            "In May 2022, the government of what European nation banned its employees from using American gaming terms such as 'e-sports,' instead using their domestic language counterparts like 'jeu video de competition?'",
            "Regarded as one of the greatest video games of all time, what 1981 arcade game features the titular amphibian trying to cross a road without getting squashed by cars, and a river,",
            "What is thought to be the first video game, created in 1958 and becoming popular in the 1970s?",
            "What Will Wright created video game series released in 2000 (with sequels in 2004, 2009, and 2014) saw players watching and directing characters to mundane things like eating, sleeping, and cleaning their houses?",
            "Making his debut in 1990's 'Super Mario World,' what is the name of the enemy-eating, egg-throwing green dinosaur who serves as a sidekick to Mario and Luigi in the Mario franchise?",
            "Which video game console released in 2006 pioneered the use of motion controls in its gameplay?",
            "2021 will see the release of what sixth game in the Halo franchise, continuing the adventures of Master Chief? Its name sounds as if the game’s story will continue in perpetuity.",
            "In 2014, Google partnered with Game Freak and Nintendo as part of an April Fool's Day prank to create a new version of Google Maps populated by small creatures. This prank inspired what massively popular 2016 video game?",
            "Mendicant Bias and Offensive Bias are fictional AIs in what 'holy' video game franchise that shares its name with a Beyonce´ song?",
            "Introduced on Wii consoles, Nintendo gamers can make their own in-game character by creating an avatar known by what three-letter name that sounds similar to a pronoun?",
            "What video game came with the Nintendo Entertainment System when it was released in the late 1980s, and was meant to be played with the NES Zapper gun? It shared a cartridge with 'Super Mario Bros.'",
            "The word Tetris is a combination of the Greek word Tetra(meaning four) and what 6-letter sport that was a favorite of game creator Alexy Pajitnov?",
            "What Konami game from September 1998 was initially released to the European arcade audience under the name 'Dancing Stage?'",
            "What North Carolina-based video game company created the 2018 breakout hit 'Fortnite'?"
        };

        static void Main(string[] args)
        {
            Program program = new Program();//Hier maak ik de variabel 'program', De type is Program.
            program.Run();//Deze functie zorgt dat de program kan runnen, De return is de program zelf.
        }

        internal string GetVraag(int vraagIndex)
        {
            return vragen[vraagIndex];
        }

        internal string GetRandomVraag()
        {
            Random rnd = new();
            int vraagIndex = rnd.Next(vragen.Length);
            return vragen[vraagIndex];
        }

        internal void Run()
        {
            Console.WriteLine("...");
            string vraag0 = GetRandomVraag();
            Console.WriteLine(vraag0);
            Console.ReadLine();
            Console.WriteLine("...");
            vraag0 = GetRandomVraag();
            Console.WriteLine(vraag0);
            Console.ReadLine();
            Console.WriteLine("...");
            vraag0 = GetRandomVraag();
            Console.WriteLine(vraag0);
            Console.ReadLine();
            Console.WriteLine("...");
            vraag0 = GetRandomVraag();
            Console.WriteLine(vraag0);
            Console.ReadLine();
        }

        internal void Vraag1()
        {
            Console.WriteLine("What would you do if you won a million dollars?");
            Console.ReadLine();
            string antwoord = "Hmph. Not what i would do.";

            Console.WriteLine(antwoord);
        }

        internal void Vraag2()
        {
            Console.WriteLine("What is the worst game you played but that you liked anyway?");
            string antwoord = Console.ReadLine() + "?! Aight, whatever you say.";

            Console.WriteLine(antwoord);
        }

        internal void Vraag3()
        {
            Console.WriteLine("What would you call a male ladybug?");
            Console.ReadLine();
            string antwoord = "Ha! Good one.";

            Console.WriteLine(antwoord);
        }

        internal void Vraag4()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocolypse?");
            string antwoord = "So, you'd survive " + Console.ReadLine() + "?";

            Console.WriteLine(antwoord);
        }

        internal void Vraag5()
        {
            Console.WriteLine("Which species would be the rudest if all animals could talk?");
            string antwoord = "Totaly agree with you. " + Console.ReadLine() + " suck!";

            Console.WriteLine(antwoord);
        }

        internal void Vraag6()
        {
            Console.WriteLine("Why do round pizzas come in square boxes?");
            Console.ReadLine();
            string antwoord = "You know what, imma just disagree with you.";

            Console.WriteLine(antwoord);
        }

        internal string Vraag7()
        {
            Console.WriteLine("By the by, what's your name? Forgot to ask.");
                string antwoord = Console.ReadLine();

            return antwoord;
        }

    }
}
