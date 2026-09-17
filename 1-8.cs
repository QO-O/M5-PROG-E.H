using System;
using System.Collections.Generic;

class PROG_Les1point8
{
    public static List<Player> players = new List<Player>();

public void Start()
    {
         Main2();
    }

    static void Main2()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine()!;
        Console.Write("Enter HP: ");
        int HP = int.Parse(Console.ReadLine()!);
        Console.Write("Enter score: ");
        int score = int.Parse(Console.ReadLine()!);

        players.Add(new Player(name, HP, score));
        Console.WriteLine("Player added successfully!");

        foreach (var player in players)
        {
            Console.WriteLine($"Speler.name : {player.Name}");
            Console.WriteLine($"Speler.HP : {player.HP}");
            Console.WriteLine($"Speler.Score : {player.Score}");
            Console.WriteLine();
        }
    }
}

class Player
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int Score { get; set; }

    public Player(string name, int HP, int score)
    {
        Name = name;
        HP = HP;
        Score = score;
    }
}