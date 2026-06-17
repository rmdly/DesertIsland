class Program
{
    static Player currentPlayer = new Player();

    static void Main()
    {
        Intro();
        MeetJenkins();
        UserDetails();
        QAWithJenkins();
        Camp();
    }

    static void Intro()
    {
        Console.Clear();

        Beat(1000);
        ShowTitle();
        Console.WriteLine();
        Beat(1000);
        TypeCentre("Press enter to begin...");
        Console.ReadLine();
        Console.Clear();
    }

    static void MeetJenkins()
    {
        Type("You wash up on a deserted island.");
        Beat(1000);

        Type("In the distance, a figure approaches you...");
        Beat(500);

        Continue();
        Beat(500);

        Type("It's Old Man Jenkins!");
        Beat(1000);

        ShowJenkins();
        Beat(1500);

        Say("Jenkins", "Well now... another soul washed ashore! The name's Jenkins. Who the hell are you?");
        Beat(500);
    }

    static void UserDetails()
    {
        Console.Write("Enter your name: ");
        currentPlayer.Name = Console.ReadLine() ?? "";

        Beat(1000);
        Say("Jenkins", $"Nice to meet you, {currentPlayer.Name}!");
        Thread.Sleep(1000);
        Say("Jenkins", $"So tell me... where in the world did you wash in from?");

        Beat(500);
        Console.Write("> ");
        currentPlayer.Origin = Console.ReadLine() ?? "";

        Beat(1000);
        Say(currentPlayer.Name, $"From {currentPlayer.Origin}, still not sure how I got here.");

        Beat(1000);
        Say("Jenkins", $"I see... you're a long way from {currentPlayer.Origin} anyways.");
        Beat(500);
        Continue();
    }

    static void QAWithJenkins()
    {
        Console.Clear();
        Beat(500);
        Say(currentPlayer.Name, "So, what is this place?");

        Beat(1000);
        Say("Jenkins", "This? This is Bonecreek Isle, lad.\n" +
            "The sea spits ships onto her rocks and keeps what's left.\n" +
            "Pretty, ain't she? Pretty... and patient.", 20);
        Thread.Sleep(1000);
        Say("Jenkins", "Ask me anything you like — I've naught but time.");

        Beat(1000);
        bool asked1 = false;
        bool asked2 = false;
        bool asked3 = false;

        while (!asked1 || !asked2 || !asked3)
        {
            Console.WriteLine("What do you ask Jenkins?");
            if (!asked1) Console.WriteLine("1. How long have you been here?");
            if (!asked2) Console.WriteLine("2. Are you the only person here?");
            if (!asked3) Console.WriteLine("3. How do I get off this island?");

            string choice = ReadChoice();

            Beat(500);
            if (choice == "1")
            {
                asked1 = true;
                Console.WriteLine();
                Say("Jenkins", "How long? ... what year is it now? Long enough to name every crab on this beach. That one's Geoffrey — he owes me money.");
                Beat(1000);
            }
            else if (choice == "2")
            {
                asked2 = true;
                Console.WriteLine();
                Say("Jenkins", "Only one? Ha! There's others scattered about. You'll cross paths with 'em soon enough.");
                Beat(1000);
            }
            else if (choice == "3")
            {
                asked3 = true;
                Console.WriteLine();
                Say("Jenkins", "Off? You don't just walk off, lad. First you stay alive — water, food, or the island has you. Then you take what she gives: wood, rope, whatever washes up. Build. And when you've cobbled together something that'll carry you... well. The tide brought you in. Reckon it can take you home.");
                Beat(1000);
            }
            else
            {
                Say("Jenkins", "Eh? Didn't catch that — give me a 1, 2, or 3.");
                Beat(1000);
            }
        }
    }

    static void Camp()
    {
        while (true)
        {
            currentPlayer.CurrentLocation = "Camp";

            Console.WriteLine();
            Console.WriteLine($"Your current location: {currentPlayer.CurrentLocation}");
            Beat(1000);
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Go to the Beach");
            Console.WriteLine("2. Go to the Jungle");
            Console.WriteLine("3. Open Inventory");
            Console.WriteLine("0. Rest for now");
            Beat(500);

            string choice = ReadChoice();

            if (choice == "1")
            {
                Beach();
            }
            else if (choice == "2")
            {
                Jungle();
            }
            else if (choice == "3")
            {
                OpenInventory();
            }
            else if (choice == "0")
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
            }
        }
    }

    static void Beach()
    {
        currentPlayer.CurrentLocation = "The Beach";

        Beat();
        Type("You pick your way down to the beach. Waves hiss over the sand and tangled debris.");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine($"Your current location: {currentPlayer.CurrentLocation}");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. Look around");
            Console.WriteLine("2. Open Inventory");
            Console.WriteLine("0. Head back to camp");

            string choice = ReadChoice();

            if (choice == "1")
            {
                Beat();
                Type("Driftwood and broken debris litter the tideline. Further along, the crafter's lean-to sits quiet for now.");
            }
            else if (choice == "2")
            {
                OpenInventory();
            }
            else if (choice == "0")
            {
                Beat();
                Type("You head back to camp.");
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
            }
        }
    }

    static void Jungle()
    {
        currentPlayer.CurrentLocation = "The Jungle";

        Beat();
        Type("You push into the jungle. The air is thick and green, alive with unseen things.");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine($"Your current location: {currentPlayer.CurrentLocation}");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. Look around");
            Console.WriteLine("2. Open Inventory");
            Console.WriteLine("0. Head back to camp");

            string choice = ReadChoice();

            if (choice == "1")
            {
                Beat();
                Type("Fruit hangs from the canopy and coconuts lie half-buried in the undergrowth. Something rustles, deeper in.");
                Type("Would you like to pick up a banana? [y/n]");
                string bananaChoice = ReadChoice();
                if (bananaChoice == "y")
                {
                    currentPlayer.Inventory.Add(new Item("Banana"));
                    Type("You picked up a banana and added it to your inventory.");
                }
            }
            else if (choice == "2")
            {
                OpenInventory();
            }
            else if (choice == "0")
            {
                Beat();
                Type("You head back to camp.");
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
            }
        }
    }

    static void OpenInventory()
    {
        if (currentPlayer.Inventory.Count == 0)
        {
            Beat(1000);
            Type("Your inventory is empty.");
        }
        else
        {
            Beat(1000);
            Type("You open your inventory.");
            foreach (var item in currentPlayer.Inventory)
            {
                Console.WriteLine(item.Name);
            }
        }
    }

    static string ReadChoice()
    {
        Console.Write("> ");
        return (Console.ReadLine() ?? "").Trim();
    }

    static void Say(string speaker, string line, int delay = 30)
    {
        Type($"{speaker}: \"{line}\"", delay);
    }

    static void Beat(int ms = 1500)
    {
        Console.WriteLine();
        Thread.Sleep(ms);
    }

    static void Type(string text, int delay = 30)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }

    static void Continue()
    {
        Type("Press any key to continue...");
        Console.ReadKey(true);
    }

    static void TypeCentre(string text, int delay = 30)
    {
        int left = (Console.WindowWidth - text.Length) / 2;
        Console.SetCursorPosition(Math.Max(0, left), Console.CursorTop);
        Type(text, delay);
    }

    static void TypeCentreBlock(string block, int delay = 2)
    {
        string[] lines = block.Split('\n');
        int width = 0;
        foreach (string line in lines)
            if (line.Length > width) width = line.Length;
        int left = Math.Max(0, (Console.WindowWidth - width) / 2);
        foreach (string line in lines)
        {
            Console.SetCursorPosition(left, Console.CursorTop);
            Type(line, delay);
        }
    }

    static void ShowTitle()
    {
        TypeCentreBlock("""

            ____  _____ ____  _____ ____ _____
           |  _ \| ____/ ___|| ____|  _ \_   _|
           | | | |  _| \___ \|  _| | |_) || |
           | |_| | |___ ___) | |___|  _ < | |
           |____/|_____|____/|_____|_| \_\|_|
            ___ ____  _        _    _   _ ____
           |_ _/ ___|| |      / \  | \ | |  _ \
            | |\___ \| |     / _ \ |  \| | | | |
            | | ___) | |___ / ___ \| |\  | |_| |
           |___|____/|_____/_/   \_\_| \_|____/
    """, 2);
        Beat();
        TypeCentre("Welcome to Desert Island!");
        TypeCentre("Made by @rmdly.");
    }

    static void ShowJenkins()
    {
        Console.WriteLine("""""

        .-""""-.
       /  _  _  \
      |-[o]-[o]--|
      |    ^     |  <--- Old Man Jenkins
      |  \___/   |
       \  ~~~   /
        '.___.'
         /|||\
       _/ ||| \_
      /___|||___\

    """"");
    }
}
