public class Skill
{
    public int Damage { get; private set; }
    public string Name { get; private set; }
    public int Cost { get; private set; }

    public Skill(int damage, string name, int cost)
    {
        Damage = damage;
        Name = name;
        Cost = cost;
    }
}
