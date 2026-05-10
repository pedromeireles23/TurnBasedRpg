public class Player
{
    public string Name { get; set; }
    public int HpPoints { get; private set; }
    public int ManaPoints { get; private set; }
    public int AttackPoints { get; private set; }
    public int DefensePoints { get; private set; }
    public int CurrentHealth { get; private set; }
    public int SpeedPoints { get; private set; }

    //TODO melhorar atributos

    // private bool _isDeath;
    // public bool IsDeath
    // {
    //     get { return _isDeath; }
    //     private set
    //     {
    //         if (CurrentHealth <= 0)
    //         {
    //             _isDeath = true;
    //         }
    //         else
    //         {
    //             _isDeath = false;
    //         }
    //     }
    // }
    public CharacterClass CharacterClass { get; set; }

    public Player(string name, CharacterClass characterClass)
    {
        Name = name;
        CharacterClass = characterClass;
        switch (characterClass)
        {
            case CharacterClass.Mago:
                HpPoints = 70;
                CurrentHealth = 70;
                AttackPoints = 12;
                ManaPoints = 120;
                DefensePoints = 6;
                SpeedPoints = 8;
                break;
            case CharacterClass.Guerreiro:
                HpPoints = 140;
                CurrentHealth = 140;
                AttackPoints = 20;
                ManaPoints = 20;
                DefensePoints = 18;
                SpeedPoints = 6;
                break;
            case CharacterClass.Arqueiro:
                HpPoints = 100;
                CurrentHealth = 100;
                AttackPoints = 16;
                ManaPoints = 40;
                DefensePoints = 10;
                SpeedPoints = 12;
                break;
            case CharacterClass.Ladino:
                HpPoints = 90;
                CurrentHealth = 90;
                AttackPoints = 18;
                ManaPoints = 30;
                DefensePoints = 8;
                SpeedPoints = 18;
                break;
            default:
                throw new ArgumentException("Classe inválida");
        }
    }

    public int Attack()
    {
        return AttackPoints;
    }

    public void ReceiveDamage(int attackPoints)
    {
        var dano = Math.Max(1, attackPoints - DefensePoints);
        CurrentHealth -= dano;
        if (CurrentHealth <= 0)
            CurrentHealth = 0;
    }
}
