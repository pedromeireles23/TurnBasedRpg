public class Battle
{
    public Character Character1 { get; private set; }
    public Character Character2 { get; private set; }

    public int CountRounds { get; private set; } = 1;

    public Battle(Character character1, Character character2)
    {
        Character1 = character1;
        Character2 = character2;
    }

    //TODO fazer lógica da batalha

    public void StartCombat()
    {
        while (CheckDeath() == false)
        {
            RunRound();
            CountRounds++;
        }
    }

    public void RunRound()
    {
        Console.WriteLine($"Round: {CountRounds}");
        if (Character1.SpeedPoints >= Character2.SpeedPoints)
        {
            // Enemy.ReceiveDamage(Player.Attack());
            Console.WriteLine($"Player: {Character1.Name} attacked {Character2.Name} ");
            Console.WriteLine($"{Character2.ReceiveDamage(Character1.UseSkill())}");
            Console.WriteLine($"Enemy HP:{Character2.CurrentHealth}");

            if (CheckDeath() == true)
            {
                Console.WriteLine("Enemy is Dead");
            }
            else
            {
                Console.WriteLine($"Enemy: {Character2.Name} attacked {Character1.Name} ");
                Console.WriteLine($"{Character1.ReceiveDamage(Character2.UseSkill())}");
                Console.WriteLine($"Player HP:{Character1.CurrentHealth}");
                if (CheckDeath() == true)
                {
                    Console.WriteLine("Player is Dead");
                }
                Console.WriteLine("Rodada Finalizada");
            }
        }
        else
        {
            // Player.ReceiveDamage(Enemy.Attack());
            Console.WriteLine($"Enemy: {Character2.Name} attacked {Character1.Name} ");
            Console.WriteLine($"{Character1.ReceiveDamage(Character2.UseSkill())}");
            Console.WriteLine($"Player HP:{Character1.CurrentHealth}");
            if (CheckDeath() == true)
            {
                Console.WriteLine("Player is Dead");
            }
            else
            {
                Console.WriteLine($"Player: {Character1.Name} attacked {Character2.Name} ");
                Console.WriteLine($"{Character2.ReceiveDamage(Character1.UseSkill())}");
                Console.WriteLine($"Enemy HP:{Character2.CurrentHealth}");

                if (CheckDeath() == true)
                {
                    Console.WriteLine("Enemy is Dead");
                }
                Console.WriteLine("Rodada Finalizada");
            }
        }
    }

    public bool CheckDeath()
    {
        if (Character1.CurrentHealth <= 0)
        {
            return true;
        }
        else if (Character2.CurrentHealth <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
