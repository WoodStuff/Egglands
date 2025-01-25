using Egglands.Lists;

namespace Egglands;

/// <summary>
/// Most of the game logic is stored here.
/// </summary>
public static class Game
{
	/// <summary>
	/// The player character.
	/// </summary>
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