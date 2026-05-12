public class Character
{
    public string Name { get; set; }
    public int HpPoints { get; private set; }
    public int ManaPoints { get; private set; }

    public int CurrentMana { get; private set; }
    public int AttackPoints { get; private set; }
    public int DefensePoints { get; private set; }
    public List<Skill> Skills { get; private set; }
    public int CurrentHealth { get; private set; }
    public int SpeedPoints { get; private set; }
    public CharacterClass CharacterClass { get; private set; }

    public Character(string name, CharacterClass characterClass)
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
                CurrentMana = 120;
                DefensePoints = 6;
                SpeedPoints = 8;
                Skills = new List<Skill>();
                var fireball = new Skill(35, "Fireball", 25);
                Skills.Add(fireball);
                break;
            case CharacterClass.Guerreiro:
                HpPoints = 140;
                CurrentHealth = 140;
                AttackPoints = 20;
                ManaPoints = 20;
                CurrentMana = 20;
                DefensePoints = 18;
                SpeedPoints = 6;
                Skills = new List<Skill>();
                var sismicSmash = new Skill(45, "Sismic Smash", 10);
                Skills.Add(sismicSmash);
                break;
            case CharacterClass.Arqueiro:
                HpPoints = 100;
                CurrentHealth = 100;
                AttackPoints = 16;
                ManaPoints = 40;
                CurrentMana = 40;
                DefensePoints = 10;
                SpeedPoints = 12;
                Skills = new List<Skill>();
                var stormyArrow = new Skill(32, "Stormy Arrow", 15);
                Skills.Add(stormyArrow);
                break;
            case CharacterClass.Ladino:
                HpPoints = 90;
                CurrentHealth = 90;
                AttackPoints = 18;
                ManaPoints = 30;
                CurrentMana = 30;
                DefensePoints = 8;
                SpeedPoints = 18;
                Skills = new List<Skill>();
                var shadowStrike = new Skill(35, "Shadow Strike", 10);
                Skills.Add(shadowStrike);
                break;
            default:
                throw new ArgumentException("Classe inválida");
        }
    }

    public int Attack()
    {
        return AttackPoints;
    }

    public int ReceiveDamage(int attackPoints)
    {
        var dano = Math.Max(1, attackPoints - DefensePoints);
        CurrentHealth -= dano;
        if (CurrentHealth <= 0)
            CurrentHealth = 0;
        System.Console.WriteLine($"Damage Caused:{dano}");
        return dano;
    }

    //TODO ADICIONAR LOG DAS SKILLS
    //TODO -- SKILLS NÃO NECESSARIAMENTE SÓ DÃO DANO.. PENSAR NISSO DEPOIS
    public int UseSkill()
    {
        var skill = Skills
            .Where(s => s.Cost <= CurrentMana)
            .OrderByDescending(s => s.Cost)
            .FirstOrDefault();

        if (skill == null)
            return Attack();

        CurrentMana -= skill.Cost;
        System.Console.WriteLine($"{skill.Name}");
        System.Console.WriteLine($"Current Mana: {CurrentMana}");
        System.Console.WriteLine($"Damage Caused: {skill.Damage}");
        return skill.Damage;
    }
}
