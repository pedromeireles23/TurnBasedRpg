Character player1 = new Character("Alemao", CharacterClass.Mago);

System.Console.WriteLine(player1.CurrentHealth);

Character enemy1 = new Character("Slime", CharacterClass.Mago);

// player1.ReceiveDamage(enemy1.Attack());
// System.Console.WriteLine(player1.CurrentHealth);
//TODO Retirar Lógica do console.cs

Battle battle1 = new Battle(player1, enemy1);
battle1.StartCombat();
