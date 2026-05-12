public class ManaPotion : Consumable
{
    public int RestoreMana { get; private set; }

    public override void Use(Character target)
    {
        target.RestoreMana(RestoreMana);
    }
}
