using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

public class Tamagotchi
{
    private int hunger;
    private int boredom;
    List<string> words = ["idkasså",];
    public string name = "";

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
        Console.WriteLine($"{name}<({words.Last()})");
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

        if (Isalive() == false)
        {   
            Console.WriteLine("du dog");
        }
        

    }

    public void PrintStats()
    {
        if (boredom < 0)
        {
            boredom++;
        }
        if (hunger < 0)
        {
            hunger++;
        }
        Console.WriteLine($"Bordedom: {boredom}, Hunger: {hunger}");
    }

    public bool GetAlive()
    {
        return Isalive();
    }

    public bool Isalive()
    {
        if (hunger > 10 || boredom > 10)
        {
            return false;
        }
        else
        {
            return true;
        }
        
    }

    private void Reduceboredom()
    {
        boredom--;
    }

}