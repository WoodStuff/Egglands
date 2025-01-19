namespace Egglands
{
	/// <summary>
	/// Contains methods for controlling the flow of the game.
	/// </summary>
	internal static class Control
	{
		/// <summary>
		/// Enforces a choice by waiting until one of some keys is pressed.
		/// </summary>
		/// <param name="keys">The acceptable keys.</param>
		public static ConsoleKeyInfo Wait(char[] keys)
		{
			ConsoleKeyInfo key;
			do
			{
				key = Console.ReadKey(true);
			}
			while (!keys.Contains(key.KeyChar));
			return key;
		}
	}
}
