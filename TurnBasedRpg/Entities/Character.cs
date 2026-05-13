public class Character
{
    public string Name { get; set; }
    public int MaxHealth { get; protected set; }
    public int MaxMana { get; protected set; }

    public int CurrentMana { get; protected set; }
    public int AttackPoints { get; protected set; }
    public int DefensePoints { get; protected set; }
    public List<Skill> Skills { get; protected set; }
    public List<Item> Inventory { get; protected set; }

    public int CurrentHealth { get; protected set; }
    public int SpeedPoints { get; protected set; }
    public CharacterClass CharacterClass { get; protected set; }

    public Character(string name, CharacterClass characterClass)
    {
        Name = name;
        CharacterClass = characterClass;
        Inventory = new List<Item>();
        Skills = new List<Skill>();

        switch (characterClass)
        {
            case CharacterClass.Mago:
                MaxHealth = 70;
                CurrentHealth = 70;
                AttackPoints = 12;
                MaxMana = 120;
                CurrentMana = 120;
                DefensePoints = 6;
                SpeedPoints = 8;
                var fireball = new Skill(35, "Fireball", 25);
                Skills.Add(fireball);
                break;
            case CharacterClass.Guerreiro:
                MaxHealth = 140;
                CurrentHealth = 140;
                AttackPoints = 20;
                MaxMana = 20;
                CurrentMana = 20;
                DefensePoints = 18;
                SpeedPoints = 6;
                var sismicSmash = new Skill(45, "Sismic Smash", 10);
                Skills.Add(sismicSmash);
                break;
            case CharacterClass.Arqueiro:
                MaxHealth = 100;
                CurrentHealth = 100;
                AttackPoints = 16;
                MaxMana = 40;
                CurrentMana = 40;
                DefensePoints = 10;
                SpeedPoints = 12;
                var stormyArrow = new Skill(32, "Stormy Arrow", 15);
                Skills.Add(stormyArrow);
                break;
            case CharacterClass.Ladino:
                MaxHealth = 90;
                CurrentHealth = 90;
                AttackPoints = 18;
                MaxMana = 30;
                CurrentMana = 30;
                DefensePoints = 8;
                SpeedPoints = 18;
                var shadowStrike = new Skill(35, "Shadow Strike", 10);
                Skills.Add(shadowStrike);
                break;
            default:
                throw new ArgumentException("Classe inválida");
        }
    }

    public void Heal(int amount)
    {
        CurrentHealth += amount;
        if (CurrentHealth >= MaxHealth)
            CurrentHealth = MaxHealth;
    }

    public void RestoreMana(int amount)
    {
        CurrentMana += amount;
        if (CurrentMana >= MaxMana)
            CurrentMana = MaxMana;
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public void UseItem(Consumable item)
    {
        item.Use(this);
        Inventory.Remove(item);
    }

    public void RemoveItem(Item item)
    {
        Inventory.Remove(item);
    }

    // public void EquipWeapon(string name)
    // {
    //     var weapon = Inventory.FirstOrDefault(i => i.Name == name);
    //     if (weapon != null)
    //     {
    //         EquipedWeapon = true;
    //         AttackPoints += weapon.BonusAttack;
    //         DefensePoints += weapon.BonusDefense;
    //     }
    //     else
    //     {
    //         EquipedWeapon = false;
    //     }
    // }

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
