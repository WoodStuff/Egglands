namespace Egglands;

internal static class Program
{
	/// <summary>
	/// Entry point.
	/// </summary>
	public static void Main()
	{
		Console.CursorVisible = false;

		Menu();
	}

	/// <summary>
	/// Triggers the main menu.
	/// </summary>
	private static void Menu()
	{
		Console.Clear();

		Console.WriteLine("====================");
		Console.WriteLine("      EGGLANDS      ");
		Console.WriteLine("====================");
		Console.WriteLine("");

		var option = Control.Options(["Play", "Exit"]);
		if (option == 1) Environment.Exit(0);
	}
}