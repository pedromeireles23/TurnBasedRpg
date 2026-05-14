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

        Character firstAttacker;
        Character secondAttacker;

        if (Character1.SpeedPoints >= Character2.SpeedPoints)
        {
            firstAttacker = Character1;
            secondAttacker = Character2;
        }
        else
        {
            firstAttacker = Character2;
            secondAttacker = Character1;
        }

        ExecuteAttack(firstAttacker, secondAttacker);

        if (CheckDeath() == true)
        {
            Console.WriteLine($"{secondAttacker.Name} is Dead");
        }
        else
        {
            ExecuteAttack(secondAttacker, firstAttacker);

            if (CheckDeath() == true)
            {
                Console.WriteLine($"{firstAttacker.Name} is Dead");
            }

            Console.WriteLine("Rodada Finalizada");
        }
    }

    private void ExecuteAttack(Character attacker, Character target)
    {
        System.Console.WriteLine($"{attacker.Name} attacked {target.Name}");
        var result = target.ReceiveDamage(attacker.UseSkill());
        System.Console.WriteLine(result);
        System.Console.WriteLine($"{target.Name} Hp: {target.CurrentHealth}");
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
