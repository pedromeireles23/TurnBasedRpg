public class BattleAction
{
    public BattleActionType ActionType { get; private set; }
    public Skill? SkillUsed { get; private set; }
    public Item? ItemUsed { get; private set; }

    public BattleAction(BattleActionType actionType)
    {
        ActionType = actionType;
    }

    public BattleAction(Skill skill)
    {
        ActionType = BattleActionType.Skill;
        SkillUsed = skill;
    }

    public BattleAction(Item item)
    {
        ActionType = BattleActionType.Item;
        ItemUsed = item;
    }
}
