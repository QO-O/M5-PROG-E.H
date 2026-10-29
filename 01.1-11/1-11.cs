using System;
using System.Collections.Generic;

class PROG_Les1point11
{
    static void Main()
    {
        List<string> vijanden = new List<string>();

        vijanden.Add("Goomba");
        vijanden.Add("Koopa Troopa");
        vijanden.Add("Bowser");
        vijanden.Add("Boo");
        vijanden.Add("Wario");

        vijanden.Remove("Wario");

        foreach (string vijand in vijanden)
        {
            Console.WriteLine(vijand);
        }

        Console.WriteLine($"Number of enemies: {vijanden.Count}");
    }
    
}
