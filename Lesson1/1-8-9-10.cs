// using System;

// class Program
// {
//     static void Main()
//     {
//         // ===== Opdracht 1.8 – Classes: Speler =====
//         // Speler mario = new Speler("Mario", 10, 1000);
//         // Speler luigi = new Speler("Luigi", 4, 500);

//         // Console.WriteLine($"Speler.name : {mario.Naam}");
//         // Console.WriteLine($"Speler.HP : {mario.HP}");
//         // Console.WriteLine($"Speler.Score : {mario.Score}");
//         // Console.WriteLine();

//         // Console.WriteLine($"Speler.name : {luigi.Naam}");
//         // Console.WriteLine($"Speler.HP : {luigi.HP}");
//         // Console.WriteLine($"Speler.Score : {luigi.Score}");
//         // Console.WriteLine();

//         // ===== Opdracht 1.9 – Adding Method =====
//         // mario.Vertel();
//         // luigi.Vertel();

//         // // ===== Opdracht 1.10 – Array of Spelers =====
//         Speler[] spelers = new Speler[]
//         {
//             new Speler("Mario", 10, 1000),
//             new Speler("Luigi", 4, 500),
//             new Speler("Peach", 8, 800)
//         };

//         DrukSpelersAf(spelers);
//     }

//     static void DrukSpelersAf(Speler[] spelers)
//     {
//         foreach (Speler speler in spelers)
//         {
//             speler.Vertel();
//         }
//     }
// }

// class Speler
// {
//     public string Naam;
//     public int HP;
//     public int Score;

//     public Speler(string naam, int hp, int score)
//     {
//         Naam = naam;
//         HP = hp;
//         Score = score;
//     }

//     public void Vertel()
//     {
//         Console.WriteLine($"Ik ben {Naam}, mijn HP is {HP} en mijn score is {Score}.");
//     }
// }