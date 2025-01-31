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
		if (obj == null) return;

		string str = obj.ToString() ?? "";
		string[] lines = str.Split('\n');

		for (int i = 0; i < lines.Length; i++)
		{
			Console.SetCursorPosition(position.x, position.y + i);
			Write(lines[i]);
		}
	}
	public static void Write(object? obj, ConsoleColor color, (int x, int y) position)
	{
		ConsoleColor oldColor = Console.ForegroundColor;
		Console.ForegroundColor = color;

		Write(obj, position);

		Console.ForegroundColor = oldColor;
	}
}