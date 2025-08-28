
using System.Formats.Asn1;

static void Fight()
{

    int p1hp = 100;
    int p2hp = 100;
    int p1lvl = 20;
    int p2lvl = 20;

    Console.WriteLine("Spelare etts namn...");
    string p1Name = Console.ReadLine();
    Console.WriteLine("Spelare tvås namn...");
    string p2Name = Console.ReadLine();;

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
                p2hp -= Random.Shared.Next(10, p1lvl); // gurre slår eddi 
            }
            if (p2hp > 0)
            {
                p1hp -= Random.Shared.Next(10, p2lvl); // eddi slår gurre
            }

            Console.WriteLine("v");
            Console.WriteLine($"{p1Name}: {p1hp}");
            Console.WriteLine($"{p2Name}: {p2hp}");

        }

        Console.WriteLine("v");

        if (p1hp > p2hp)
        {
            Console.WriteLine($"{p1Name} har vunnit via KO. +lvl");
            p1lvl++;
        }
        else if (p2hp > p1hp)
        {
            Console.WriteLine($"{p2Name} har vunnit via KO. +lvl");
            p2lvl++;
        }
        else
        {
            Console.WriteLine($"det blev oavjort {p1Name} och {p2Name} KO varandrae");
        }
    }
}

bool kor = true;

while (kor = true)
{
    Fight();
    Console.WriteLine("Do you want to finish? y or n");
    string repeat = Console.ReadLine();
    if (repeat == "y")
    {
        kor = true;
    }
    else if (repeat == "n")
    {
        break;
    }
}


Console.ReadLine();