namespace Egglands;

internal static class Program
{
	/// <summary>
	/// Entry point.
	/// </summary>
	public static async Task Main()
	{
		Console.CursorVisible = false;

		await Game.Menu();
	}
}