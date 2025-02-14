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
	public static Player Player { get; } = new();

	/// <summary>
	/// Triggers the main menu.
	/// </summary>
	public static void Menu()
	{
		Console.Clear();

		Console.WriteLine("====================");
		Console.WriteLine("      EGGLANDS      ");
		Console.WriteLine("====================");
		Console.WriteLine("");

		var option = Control.Options(["Start Game", "Exit"]);
		if (option == 1) Environment.Exit(0); // exit game

		SelectClass();
		if (Player.Class == Class.Unspecified)
			throw new InvalidOperationException("An error happened while selecting a class.");

		option = Control.Options(["Fight Zombie", "Fight Skeleton"]);
		Enemy enemy = option switch
		{
			0 => Enemy.Index.Zombie,
			1 => Enemy.Index.Skeleton,
			_ => throw new InvalidOperationException()
		};
		Battle.Start(enemy);
	}

	/// <summary>
	/// Triggers the class picker.
	/// </summary>
	private static void SelectClass()
	{
		Console.Clear();

		Console.WriteLine("Pick your class:");
		var option = Control.Options(["Warrior", "Mage"]);

		Class c = option switch
		{
			0 => Class.Warrior,
			1 => Class.Mage,
			_ => throw new ArgumentOutOfRangeException(nameof(option), "Invalid class picked.")
		};

		Player.InitializePlayerStats(c);
		Console.Clear();
	}
}