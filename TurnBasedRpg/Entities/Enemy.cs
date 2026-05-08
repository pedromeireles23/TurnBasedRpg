public class Enemy
{
    public string Name { get; private set; }
    public int HpPoints { get; private set; }
    public int ManaPoints { get; private set; }
    public int AttackPoints { get; private set; }
    public int DefensePoints { get; private set; }
    public int SpeedPoints { get; private set; }
    public int CurrentHealth { get; private set; }

    public CharacterClass CharacterClass { get; private set; }

    public Enemy(CharacterClass characterClass)
    {
        CharacterClass = characterClass;
        switch (characterClass)
        {
            case CharacterClass.Mago:
                HpPoints = 70;
                AttackPoints = 12;
                ManaPoints = 120;
                DefensePoints = 6;
                SpeedPoints = 8;
                Name = "Inimigo Mago";
                break;
            case CharacterClass.Guerreiro:
                HpPoints = 140;
                AttackPoints = 20;
                ManaPoints = 20;
                DefensePoints = 18;
                SpeedPoints = 6;
                Name = "Inimigo Guerreiro";
                break;
            case CharacterClass.Arqueiro:
                HpPoints = 100;
                AttackPoints = 16;
                ManaPoints = 40;
                DefensePoints = 10;
                SpeedPoints = 12;
                Name = "Inimigo Arqueiro";
                break;
            case CharacterClass.Ladino:
                HpPoints = 90;
                AttackPoints = 18;
                ManaPoints = 30;
                DefensePoints = 8;
                SpeedPoints = 18;
                Name = "Inimigo Ladino";
                break;
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
