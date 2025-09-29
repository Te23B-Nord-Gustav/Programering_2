using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

public class Tamagotchi
{
    private int hunger;
    private int boredom;
    List<string> words = [];
    bool isalive = true;
    public string name;







    public Tamagotchi()
    {



        Console.WriteLine("!After each finished option you will return to menu. And if your tama reaches 10 in hunger or boredom it dies ");
        Console.WriteLine("");
        Console.Write("Vad vill du att din tama ska heta -> ");
        name = Console.ReadLine();
        Console.WriteLine($"Name({name})");
        Console.WriteLine();

        // game loop
        while (isalive == true)
        {
            // stat fixare för negativa nummer. åter igen kolla inte på den här skit koden den är inte ens del av upgiften är bara en bug fix isch
            if (hunger < 0)
            {
                hunger++;
            }
            if (boredom < 0)
            {
                boredom++;
            }



            // menu Låt spelaren välja mellan att lära tamagotchin ett nytt ord, hälsa på den, mata den eller göra ingenting.
            Console.WriteLine($"Hunger={hunger} Boredom={boredom}");
            Console.WriteLine("Menu");
            Console.WriteLine($"1-Teach {name} a new word");
            Console.WriteLine($"2-Great {name}"); //HI metoden
            Console.WriteLine($"3-Feed {name}");
            Console.WriteLine($"4-do nothing");

            // game
            string svar = Console.ReadLine();
            if (svar == "1") // lär den ord
            {
                Console.WriteLine($"Vad vill du lära {name}");
                Teach(Console.ReadLine());
                Console.WriteLine($"{name}<({words[0]})");
            }
            else if (svar == "2") // hälsar på den 
            {
                Console.WriteLine($"Hello {name}");
                Console.Write($"{name}");
                Hi();
                Console.WriteLine($"''<3");

            }
            else if (svar == "3")
            {
                Console.WriteLine($"you fed {name}");
                Feed();
            }
            else if (svar == "4")
            {
                Console.WriteLine("pov inget hände");
            }

            Tick();

            if (hunger == 1 || boredom == 10)
            {
                isalive = false;
            }



        }



        Console.ReadLine();
    }














    public void Feed()
    {
        hunger--;

    }

    public void Hi()
    {
        int i = Random.Shared.Next(words.Count);
        Console.WriteLine(words[i]);
        Reduceboredom();
    }

    public void Teach(string word)
    {
        words.Add(word);
        Reduceboredom();
    }

    public void Tick()
    {
        // våga inte kolla på den här skiten man kan inte göra ngt i spelet utan den. för den ger plus 2 totalt boredom+hunger men nu så är det bara en eller inget 
        int test = Random.Shared.Next(0, 3);
        if (test == 0)
        {
            hunger++;
        }
        if (test == 1)
        {
            boredom++;
        }
        if (hunger > 10 || boredom > 10)
        {
            isalive = false;
        }

    }

    public void PrintStats()
    {
        Console.WriteLine($"Bordedom: {boredom}, Hunger: {hunger}");
    }

    public bool GetAlive()
    {
        return isalive;
    }

    private void Reduceboredom()
    {
        boredom--;
    }

}