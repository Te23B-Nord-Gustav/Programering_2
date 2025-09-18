
using System.Formats.Asn1;

static void Fight()
{
    // spelare hp
    int p1hp = 100;
    int p2hp = 100;

    // spelare namn
    string p1Name = "";
    string p2Name = "";

    bool Namecheck1 = true;
    bool Namecheck2 = true;
    while (Namecheck1 == true)
    {
        Console.WriteLine("ange p1 namn");
        p1Name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(p1Name))
        {
            Console.WriteLine("skriv ett namn yo");
        }
        else
        {
            Namecheck1 = false;
        }
    }
    while (Namecheck2 == true)
    {
        Console.WriteLine("ange p2 namn");
        p2Name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(p2Name))
        {
            Console.WriteLine("skriv ett namn yo");
        }
        else
        {
            Namecheck2 = false;
        }
    }



    // start av fighten display av hp
    Console.WriteLine($"{p1Name}: {p1hp}");
    Console.WriteLine($"{p2Name}: {p2hp}");

    // fight sekvensen
    while (p1hp > 0 && p2hp > 0)
    {
        if (p1hp > 0)
        {
            p2hp -= Random.Shared.Next(10, 20); // gurre slår eddi 
        }
        if (p2hp > 0)
        {
            p1hp -= Random.Shared.Next(10, 20); // eddi slår gurre
        }

        Console.WriteLine("v");
        Console.WriteLine($"{p1Name}: {p1hp}");
        Console.WriteLine($"{p2Name}: {p2hp}");

    }

    if (p1hp > p2hp)
    {
        Console.WriteLine($"{p1Name} har vunnit via KO.");
    }
    else if (p2hp > p1hp)
    {
        Console.WriteLine($"{p2Name} har vunnit via KO.");
    }
    else
    {
        Console.WriteLine($"det blev oavjort {p1Name} och {p2Name} KO varandrae");
    }

}

bool kor = true;
while (kor = true)
{
    Fight();
    Console.WriteLine("");
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