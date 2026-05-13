public class Enemy : Character
{
    public EnemyType EnemyType { get; private set; }

    public Enemy(string name, EnemyType enemyType)
        : base(name, CharacterClass.Guerreiro)
    {
        EnemyType = enemyType;
        switch (enemyType)
        {
            case EnemyType.Goblin:
                MaxHealth = 60;
                CurrentHealth = 60;
                AttackPoints = 10;
                DefensePoints = 4;
                SpeedPoints = 10;
                break;
            case EnemyType.Orc:
                MaxHealth = 120;
                CurrentHealth = 120;
                AttackPoints = 22;
                DefensePoints = 12;
                SpeedPoints = 5;
                break;
            case EnemyType.Skeleton:
                MaxHealth = 80;
                CurrentHealth = 80;
                AttackPoints = 14;
                DefensePoints = 8;
                SpeedPoints = 7;
                MaxMana = 20;
                CurrentMana = 20;
                break;
            case EnemyType.Slime:
                MaxHealth = 50;
                CurrentHealth = 50;
                AttackPoints = 8;
                DefensePoints = 2;
                SpeedPoints = 3;
                MaxMana = 0;
                CurrentMana = 0;
                break;
            default:
                throw new ArgumentException("Enemy type inválido");
        }
    }
}
