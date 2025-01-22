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

		Battle.Start(Enemies.Zombie);
	}
}