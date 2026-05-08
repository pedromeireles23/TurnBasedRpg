public class Player
{
  public string Name {get; set;}
  public int HpPoints {get; private set;}
  public int ManaPoints {get; private set;}
  public int AtackPoints {get; private set;}
  public int DefensePoints {get; private set;}
  public int SpeedPoints {get; private set;}
  public int CriticalChance {get; private set;}
  public CharacterClass CharacterClass {get; set;}

  public Player(string name, CharacterClass characterClass)
  {
    Name = name;
    CharacterClass = characterClass;
    switch(characterClass)
    {
      case CharacterClass.Mago:
      HpPoints = 70;
      AtackPoints = 12;
      ManaPoints = 120;
      DefensePoints = 6;
      break;
      case CharacterClass.Guerreiro:
      HpPoints = 70;
      AtackPoints = 12;
      ManaPoints = 120;
      DefensePoints = 6;
      break;
      case CharacterClass.Arqueiro:
      HpPoints = 70;
      AtackPoints = 12;
      ManaPoints = 120;
      DefensePoints = 6;
      break;
      case CharacterClass.Ladino:
      HpPoints = 70;
      AtackPoints = 12;
      ManaPoints = 120;
      DefensePoints = 6;
      break;

      
    }
    // if (characterClass == CharacterClass.Mago)
    // {
    //   HpPoints = 70;
    //   AtackPoints = 12;
    //   ManaPoints = 120;
    //   DefensePoints = 6;
    // }
    // else if (characterClass == CharacterClass.Guerreiro)
    // {
    //   HpPoints = 70;
    //   AtackPoints = 12;
    //   ManaPoints = 120;
    //   DefensePoints = 6;
    // }
    // else if (characterClass == CharacterClass.Arqueiro)
    // {
    //   HpPoints = 70;
    //   AtackPoints = 12;
    //   ManaPoints = 120;
    //   DefensePoints = 6;
    // }
    // else if (characterClass == CharacterClass.Ladino)
    // {
    //   HpPoints = 70;
    //   AtackPoints = 12;
    //   ManaPoints = 120;
    //   DefensePoints = 6;
    // }

  }
  
}