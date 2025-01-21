namespace Egglands;

public static class Game
{
	public static Player Player { get; } = new(5, 50);

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
		if (option == 1) Environment.Exit(0);
	}
}