namespace Egglands;

/// <summary>
/// Contains helper methods for writing to the console.
/// </summary>
internal static class Writing
{
	public static void Write(object? obj) => Console.WriteLine(obj);
	public static void Write(object? obj, ConsoleColor color)
	{
		ConsoleColor oldColor = Console.ForegroundColor;
		Console.ForegroundColor = color;

		Write(obj);

		Console.ForegroundColor = oldColor;
	}
	public static void Write(object? obj, (int x, int y) position)
	{
		(int x, int y) = Console.GetCursorPosition();
		Console.SetCursorPosition(position.x, position.y);

		Write(obj);

		Console.SetCursorPosition(x, y);
	}
	public static void Write(object? obj, ConsoleColor color, (int x, int y) position)
	{
		ConsoleColor oldColor = Console.ForegroundColor;
		Console.ForegroundColor = color;

		(int x, int y) = Console.GetCursorPosition();
		Console.SetCursorPosition(position.x, position.y);

		Write(obj);

		Console.SetCursorPosition(x, y);

		Console.ForegroundColor = oldColor;
	}
}