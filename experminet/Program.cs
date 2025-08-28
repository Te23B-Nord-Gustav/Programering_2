
static void Fight()
{

    int p1hp = 100;
    int p2hp = 100;

    string p1Name = "gurre";
    string p2Name = "eddi";

    Console.WriteLine($"{p1Name}: {p1hp}");
    Console.WriteLine($"{p2Name}: {p2hp}");

    for (int i = 0; i < 10; i++)
    {
        p1hp = 100;
        p2hp = 100;
        while (p1hp > 0 && p2hp > 0)
        {
            if (p1hp > 0)
            {
                p2hp -= Random.Shared.Next(10, 25); // gurre slår eddi 
            }
            if (p2hp > 0)
            {
                p1hp -= Random.Shared.Next(10, 25); // eddi slår gurre
            }

            Console.WriteLine("v");
            Console.WriteLine($"{p1Name}: {p1hp}");
            Console.WriteLine($"{p2Name}: {p2hp}");

        }

        Console.WriteLine("v");

        if (p1hp > p2hp)
        {
            Console.WriteLine($"{p1Name} har vunnit via KO");
        }
        else if (p2hp > p1hp)
        {
            Console.WriteLine($"{p2Name} har vunnit via KO");
        }
        else
        {
            Console.WriteLine($"det blev oavjort {p1Name} och {p2Name} KO varandrae");
        }
    }
}


Fight();

Console.ReadLine();