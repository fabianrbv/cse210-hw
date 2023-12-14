using System;
using System.Collections.Generic;

// Clase base para todas las habilidades
class Skill
{
    public string Name { get; set; }
    public int Power { get; set; }
}

// Clase adicional para representar hechizos
class Spell : Skill
{
    public Spell(string name, int power) 
    {
        Name = name;
        Power = power;
    }
}

// Clase base para los diferentes tipos de personajes
class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public List<Skill> Skills { get; set; }

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
        Skills = new List<Skill>();
    }

    public void Attack(Character target, Skill skill)
    {
        Console.WriteLine($"{Name} attacks {target.Name} with {skill.Name} for {skill.Power} damage.");
        target.ReceiveDamage(skill.Power);
    }

    public void ReceiveDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Console.WriteLine($"{Name} has been defeated!");
        }
    }
}

// Clases derivadas para diferentes tipos de personajes
class Warrior : Character
{
    public Warrior(string name) : base(name, 120)
    {
        Skills.Add(new Skill { Name = "Slash", Power = 20 });
    }
}

class Wizard : Character
{
    public Wizard(string name) : base(name, 80)
    {
        Skills.Add(new Skill { Name = "Fireball", Power = 30 });
        Skills.Add(new Spell("Lightning", 35));
    }
}

class Archer : Character
{
    public Archer(string name) : base(name, 98)
    {
        Skills.Add(new Skill { Name = "Arrow Shot", Power = 40 });
    }
}

class Dragon : Character
{
    public Dragon(String name) : base(name, 110)
    {
        Skills.Add(new Skill { Name = "Fly", Power = 32});
    }
}

// Clase para gestionar los combates
class Battle
{
    public void StartBattle(Character player, Character enemy)
    {
        Console.WriteLine($"Battle between {player.Name} and {enemy.Name} starts!");
        while (player.Health > 0 && enemy.Health > 0)
        {
            player.Attack(enemy, player.Skills[0]); // Player attacks
            if (enemy.Health > 0)
            {
                enemy.Attack(player, enemy.Skills[0]); // Enemy attacks if it's still alive
            }
        }
        Console.WriteLine("Battle ends!");
    }
}

// Clase principal
class Program
{
    static void Main()
    {
        bool repeatBattle = true;
        while (repeatBattle)
        {
            Console.WriteLine("Welcome to the Battle Arena");
            Console.WriteLine("\nChoose your character, type it: \nDragon \nArcher \nWizard \nWarrior");

            string playerChoice = Console.ReadLine();
            Character player;

            switch (playerChoice.ToLower().Trim())
            {
                case "dragon":
                    player = new Dragon("Dragon");
                    break;
                case "archer":
                    player = new Archer("Archer");
                    break;
                case "wizard":
                    player = new Wizard("Wizard");
                    break;
                case "warrior":
                    player = new Warrior("Warrior");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to Warrior.");
                    player = new Warrior("Warrior");
                    break;
            }

            Console.WriteLine("\nChoose your enemy, type it: \nDragon \nArcher \nWizard \nWarrior");
            string enemyChoice = Console.ReadLine();
            Character enemy;

            switch (enemyChoice.ToLower().Trim())
            {
                case "dragon":
                    enemy = new Dragon("Dragon");
                    break;
                case "archer":
                    enemy = new Archer("Archer");
                    break;
                case "wizard":
                    enemy = new Wizard("Wizard");
                    break;
                case "warrior":
                    enemy = new Warrior("Warrior");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to Warrior.");
                    enemy = new Warrior("Warrior");
                    break;
            }

            Battle battle = new Battle();
            battle.StartBattle(player, enemy);

            Console.WriteLine("\nDo you want to battle again? (yes/no)");
            string repeatChoice = Console.ReadLine().ToLower();
            repeatBattle = (repeatChoice == "yes");
        }
    }
}
