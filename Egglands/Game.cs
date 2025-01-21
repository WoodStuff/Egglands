using Egglands.Lists;

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

		var option = Control.Options(["Fight Zombie", "Exit"]);
		if (option == 1) Environment.Exit(0);

		FightEnemy(Enemies.Zombie);
	}

	public static void FightEnemy(Enemy enemy)
	{
		RenderUI();

		do
		{
			Control.Options(["Attack"]);

			Player.Damage(enemy.Attack);
			enemy.Damage(Player.Attack);

			RenderUI();
		} while (Player.HP > 0 && enemy.HP > 0);

		if (Player.HP > 0) Console.WriteLine("Player has won!");
		else Console.WriteLine("Enemy has won!");

		void RenderUI()
		{
			Console.Clear();

			Console.WriteLine(Player);
			Console.WriteLine();
			Console.WriteLine(enemy);
			Console.WriteLine();
		}
	}
}