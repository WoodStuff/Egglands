namespace Egglands;

/// <summary>
/// Sets up the game.
/// </summary>
internal static class Program
{
	/// <summary>
	/// Entry point.
	/// </summary>
	public static async Task Main()
	{
		SetConsoleSettings();

		await Game.Menu();
	}
	
	/// <summary>
	/// Sets some console settings.
	/// </summary>
	private static void SetConsoleSettings()
	{
		Console.CursorVisible = false;
	}
}