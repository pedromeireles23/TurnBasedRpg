public class Battle
{
    public Player Player { get; private set; }
    public Enemy Enemy { get; private set; }

    public Battle(Player player, Enemy enemy)
    {
        Player = player;
        Enemy = enemy;
    }

    //TODO fazer lógica da batalha
    public void StartCombat() { }

    public void RunRound() { }

    public void CheckDeath() { }
}
