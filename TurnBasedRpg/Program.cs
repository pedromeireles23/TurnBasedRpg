Player player1 = new Player("Alemao", CharacterClass.Mago);

System.Console.WriteLine(player1.CurrentHealth);

Enemy enemy1 = new Enemy(CharacterClass.Mago);

player1.ReceiveDamage(enemy1.Attack());
System.Console.WriteLine(player1.CurrentHealth);
//TODO Retirar Lógica do console.cs
