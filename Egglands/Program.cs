namespace Egglands;

/// <summary>
/// Sets up the game.
/// </summary>
internal static class Program
{
	/// <summary>
	/// Entry point.
	/// </summary>
	public static void Main()
	{
		SetConsoleSettings();

		Game.Menu();
	}

	/// <summary>
	/// Sets some console settings.
	/// </summary>
	private static void SetConsoleSettings()
	{
		Console.CursorVisible = false;
	}
}