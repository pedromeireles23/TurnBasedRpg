public class Battle
{
    public Player Player { get; private set; }
    public Enemy Enemy { get; private set; }

    public int CountRounds { get; private set; } = 1;

    public Battle(Player player, Enemy enemy)
    {
        Player = player;
        Enemy = enemy;
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
        if (Player.SpeedPoints >= Enemy.SpeedPoints)
        {
            // Enemy.ReceiveDamage(Player.Attack());
            Console.WriteLine($"Player: {Player.Name} attacked {Enemy.Name} ");
            Console.WriteLine($"Damage caused: {Enemy.ReceiveDamage(Player.Attack())}");
            Console.WriteLine($"Enemy HP:{Enemy.CurrentHealth}");

            if (CheckDeath() == true)
            {
                Console.WriteLine("Enemy is Dead");
            }
            else
            {
                Console.WriteLine($"Enemy: {Enemy.Name} attacked {Player.Name} ");
                Console.WriteLine($"Damage caused: {Player.ReceiveDamage(Enemy.Attack())}");
                Console.WriteLine($"Player HP:{Player.CurrentHealth}");
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
            Console.WriteLine($"Enemy: {Enemy.Name} attacked {Player.Name} ");
            Console.WriteLine($"Damage caused: {Player.ReceiveDamage(Enemy.Attack())}");
            Console.WriteLine($"Player HP:{Player.CurrentHealth}");
            if (CheckDeath() == true)
            {
                Console.WriteLine("Player is Dead");
            }
            else
            {
                Console.WriteLine($"Player: {Player.Name} attacked {Enemy.Name} ");
                Console.WriteLine($"Damage caused: {Enemy.ReceiveDamage(Player.Attack())}");
                Console.WriteLine($"Enemy HP:{Enemy.CurrentHealth}");

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
        if (Player.CurrentHealth <= 0)
        {
            return true;
        }
        else if (Enemy.CurrentHealth <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
