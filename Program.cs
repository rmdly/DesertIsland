using System;

class Program
{
    static void Main()
    {
        Console.Clear();

        Console.WriteLine("Welcome to Desert Island!");
        Console.WriteLine("Press any key to begin...");
        Console.ReadKey();
        Console.Clear();

        Beat(500);

        Console.WriteLine();
        Console.WriteLine("You wash up on a deserted island.");
        Beat(1000);

        Console.WriteLine("In the distance, a figure approaches you...");
        Beat(500);

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Beat();

        Console.WriteLine("It's Old Man Jenkins!");
        ShowJenkins();
        Beat(1000);

        Say("Jenkins", "Well now... another soul washed ashore! The name's Jenkins. Who the hell are you?");
        Beat(500);

        Console.Write("Enter your name: ");
        string name = Console.ReadLine() ?? "";

        Beat(1000);
        Say("Jenkins", $"Nice to meet you, {name}!");
        Thread.Sleep(500);
        Say("Jenkins", $"So tell me... where in the world did you wash in from?");

        Beat(500);
        Console.Write("Where you're from: ");
        string location = Console.ReadLine() ?? "";

        Beat(500);
        Say(name, $"From {location}, still not sure how I got here.");

        Beat(1000);
        Say("Jenkins", $"I see... you're a long way from {location} anyways.");

        Beat(500);
        Say(name, "So, what is this place?");

        Beat(700);
        Say("Jenkins", "This? This is Bonecreek Isle, lad. The sea spits ships onto her rocks and keeps what's left.");
        Beat(500);
        Say("Jenkins", "Pretty, ain't she? Pretty... and patient. Ask me what you like — I've naught but time.");

        Beat(700);
        bool asked1 = false;
        bool asked2 = false;
        bool asked3 = false;

        while (!asked1 || !asked2 || !asked3)
        {
            Console.WriteLine("What do you ask Jenkins?");
            if (!asked1) Console.WriteLine("1. How long have you been here?");
            if (!asked2) Console.WriteLine("2. Are you the only person here?");
            if (!asked3) Console.WriteLine("3. How do I get off this island?");

            Console.Write("Your answer: ");
            string choice = Console.ReadLine() ?? "";

            Beat(500);
            if (choice == "1")
            {
                asked1 = true;
                Say("Jenkins", "How long? Bah... what year is it now? Long enough to name every crab on this beach. That one's Geoffrey — he owes me money.");
            }
            else if (choice == "2")
            {
                asked2 = true;
                Say("Jenkins", "Only one? Ha! There's others scattered about — a half-mad botanist in the hills, a fella who only talks to the tide. You'll cross paths with 'em soon enough.");
            }
            else if (choice == "3")
            {
                asked3 = true;
                Say("Jenkins", "Off? You don't just walk off, lad. First you stay alive — water, food, or the island has you. Then you take what she gives: wood, rope, whatever washes up. Build. And when you've cobbled together something that'll carry you... well. The tide brought you in. Reckon it can take you home.");
            }
            else
            {
                Say("Jenkins", "Eh? Didn't catch that — give me a 1, 2, or 3.");
            }
        }
    }

    static void Say(string speaker, string line)
    {
        Console.WriteLine($"{speaker}: \"{line}\"");
    }

    static void Beat(int ms = 1500)
    {
        Console.WriteLine();
        Thread.Sleep(ms);
    }

    static void ShowJenkins()
    {
        Console.WriteLine("""""
        .-""""-.
       /  _  _  \
      |  [o]-[o] |
      |    ^     |
      |  \___/   | <--- Old Man Jenkins
       \  ~~~   /
        '.___.'
         /|||\
       _/ ||| \_
      /___|||___\
    """"");
    }
}
