
// intro
Tamagotchi tama = new();

Console.WriteLine("!After each finished option you will return to menu. And if your tama reaches 10 in hunger or boredom it dies ");
Console.WriteLine("");
Console.Write("Vad vill du att din tama ska heta -> ");
tama.name = Console.ReadLine();
Console.WriteLine($"Name({tama.name})");
Console.WriteLine();

// game loop
while (tama.GetAlive() == true)
{

    // menu Låt spelaren välja mellan att lära tamagotchin ett nytt ord, hälsa på den, mata den eller göra ingenting.
    tama.PrintStats();
    Console.WriteLine("Menu");
    Console.WriteLine($"1-Teach {tama.name} a new word");
    Console.WriteLine($"2-Great {tama.name}"); //HI metoden
    Console.WriteLine($"3-Feed {tama.name}");
    Console.WriteLine($"4-do nothing");

    // game
    string svar = Console.ReadLine();
    if (svar == "1") // lär den ord
    {
        Console.WriteLine($"Vad vill du lära {tama.name}");
        tama.Teach(Console.ReadLine());
        
    }
    else if (svar == "2") // hälsar på den 
    {
        Console.WriteLine($"Hello {tama.name}");
        Console.Write($"{tama.name}");
        tama.Hi();
        Console.WriteLine($"''<3");

    }
    else if (svar == "3")
    {
        Console.WriteLine($"you fed {tama.name}");
        tama.Feed();
    }
    else if (svar == "4")
    {
        Console.WriteLine("pov inget hände");
    }

    tama.Tick();
}
Console.ReadLine();
