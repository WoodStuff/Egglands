namespace Egglands;

public static class Game
{
	public static Player Player { get; } = new(5, 50);

	/// <summary>
	/// Triggers the main menu.
	/// </summary>
	public static async Task Menu()
	{
		Console.Clear();

		Console.WriteLine("====================");
		Console.WriteLine("      EGGLANDS      ");
		Console.WriteLine("====================");
		Console.WriteLine("");

		await Task.Delay(500);

		var option = Control.Options(["Fight Enemy", "Exit"]);
		if (option == 1) Environment.Exit(0);

		FightEnemy();
	}

	public static void FightEnemy()
	{
		Enemy enemy = new(2, 20);
		RenderUI();

		do
		{
			Control.Options(["Attack"]);

			Player.HP -= enemy.Attack;
			enemy.HP -= Player.Attack;

			RenderUI();
		} while (Player.HP > 0 && enemy.HP > 0);

		if (Player.HP > 0) Console.WriteLine("Player has won!");
		else Console.WriteLine("Enemy has won!");

		void RenderUI()
		{
			Console.Clear();
			
			Console.WriteLine("PLAYER");
			Console.WriteLine($"{Player.HP}/{Player.MaxHP} HP");
			Console.WriteLine($"{Player.Attack} ATK");
			Console.WriteLine("");

			Console.WriteLine("ENEMY");
			Console.WriteLine($"{enemy.HP}/{enemy.MaxHP} HP");
			Console.WriteLine($"{enemy.Attack} ATK");
			Console.WriteLine("");
		}
	}
}