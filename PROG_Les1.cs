class PROG_Les1
{
    static void Main(string[] args)
    {
        // string name = "Quin";
        // int score = 666;
        // bool isAlive = true;

        // Console.WriteLine($"Name : {name}");
        // Console.WriteLine($"Score : {score}");
        // Console.WriteLine($"Alive : {isAlive}");

        // int playerHP = 100;

        // playerHP -= 35;
        // Console.WriteLine($"Remaining HP after first attack: {playerHP}");

        // playerHP -= 80;
        // Console.WriteLine($"Remaining HP after second attack: {playerHP}");

        // if (playerHP > 0)
        // {
        //     Console.WriteLine("The player is still alive.");
        // }
        // else
        // {
        //     Console.WriteLine("The player has been defeated.");
        // }
        Console.Write("Voer je naam in: ");
        string naam = Console.ReadLine();
        Begroet(naam);
    }
    static void Begroet(string naam)
    {
        Console.WriteLine($"Welkom, {naam}!");
    }
}

    