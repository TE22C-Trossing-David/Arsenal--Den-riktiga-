global using System.Text.Json;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;


int monkeyChosen = 0;
bool gameOver = false;

// Monke supermonkey = new Monke()
// {
//     Name = "Supermonkey",
//     Damage = 1,
//     NumberOfAttacks = 10,
//     Pierce = 1,
//     Cost = 100
// };

// Monke mermonkey = new Monke()
// {
//     Name = "Mermonkey",
//     Damage = 3,
//     NumberOfAttacks = 4,
//     Pierce = 3,
//     Cost = 20
// };

string textMonke = File.ReadAllText("monke1.json");
List<Monke> jsonMonke = JsonSerializer.Deserialize<List<Monke>>(textMonke);


while (true)
{

    while (true)
    {

        Console.WriteLine("Welcome to Bloons TD Battles");
        Console.WriteLine("What monkey do you want to choose");
        Console.WriteLine("1. Supermonkey\n2. Mermonkey");
        string monkeyChoice = Console.ReadLine();
        if (monkeyChoice == "1")
        {
            Console.Clear();
            monkeyChosen = 0;
            Console.WriteLine("You chose the " + jsonMonke[monkeyChosen].Name);
            break;
        }
        else if (monkeyChoice == "2")
        {
            Console.Clear();
            monkeyChosen = 1;
            Console.WriteLine("You chose the " + jsonMonke[monkeyChosen].Name);
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Write 1 or 2 idiot");
        }
    }

    Console.WriteLine("You are fighting a MOAB.");
    Console.WriteLine("Press ENTER to start the fight");
    Console.ReadLine();
    Console.Clear();

    while (!gameOver)
    {
        Console.WriteLine("Number of attacks: " + jsonMonke[monkeyChosen].NumberOfAttacks);
        Console.WriteLine("How many attacks do you want to do?");
        int attacksChosen = int.Parse(Console.ReadLine());
        if (attacksChosen > jsonMonke[monkeyChosen].NumberOfAttacks)
        {
            attacksChosen = jsonMonke[monkeyChosen].NumberOfAttacks;
        }
        Console.Clear();
        int randomDamage = Random.Shared.Next(1, jsonMonke[monkeyChosen].Pierce);
        int totalDamage = randomDamage * attacksChosen;
        Console.WriteLine("You did " + totalDamage + " Damage!");
    }

}


Console.ReadLine();