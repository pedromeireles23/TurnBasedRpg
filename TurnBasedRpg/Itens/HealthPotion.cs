public class HealthPotion : Consumable
{
    public int HealAmount { get; private set; }

    public override void Use(Character target)
    {
        target.Heal(HealAmount);
    }
}
