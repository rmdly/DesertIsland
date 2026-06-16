using System;

class Program
{
    static void Main()
    {
        Console.WriteLine();
        Console.WriteLine("You wash up on a deserted island.");
        Beat(1000);

        Console.WriteLine("In the distance, a figure approaches you...");
        Beat(500);

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Beat();

        ShowJenkins();
        Beat(1000);

        Say("Jenkins", "Well now... another soul washed ashore! The name's Jenkins. Who the hell are you?");
        Beat(500);

        Console.Write("Enter your name: ");
        string name = Console.ReadLine() ?? "";

        Beat(1000);
        Say("Jenkins", $"Nice to meet you, {name}!");

        Beat(1000);
        Say("Jenkins", $"So tell me... where in the world did you wash in from?");

        Beat(500);
        Console.Write("Where you're from: ");
        string location = Console.ReadLine() ?? "";

        Beat(500);
        Say(name, $"From {location}, still not sure how I got here.");

        Beat(1000);
        Say("Jenkins", $"I see... you're a long way from {location} anyways.");
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
      |  \___/   | <--- Old Man Jenkins!
       \  ~~~   /
        '.___.'
         /|||\
       _/ ||| \_
      /___|||___\
    """"");
    }
}
