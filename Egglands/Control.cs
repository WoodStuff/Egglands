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
		/// <returns>The pressed key.</returns>
		public static ConsoleKeyInfo Wait(ConsoleKey[] keys)
		{
			ConsoleKeyInfo key;

			do
			{
				key = Console.ReadKey(true);
			}
			while (!keys.Contains(key.Key)); // only proceed if requested key is pressed

			return key;
		}

		/// <summary>
		/// Enforces a choice by writing out some options and allowing the user to pick one using arrow keys and enter.
		/// </summary>
		/// <param name="options">The selectable options.</param>
		/// <returns>The index of the option that was selected.</returns>
		public static int Options(string[] options)
		{
			//int start = Console.CursorTop; // position of the option list
			int selected = 0; // currently selected option id

			foreach (string option in options)
			{
				Console.WriteLine(option);
			}

			ConsoleKeyInfo key;
			do
			{
				// up and down arrows for choosing options
				// enter to confirm option
				key = Wait([ConsoleKey.UpArrow, ConsoleKey.DownArrow, ConsoleKey.Enter]);

				if (key.Key == ConsoleKey.UpArrow)   selected--; // move selected option up
				if (key.Key == ConsoleKey.DownArrow) selected++; // move selected option down

				// looping once selection goes off edge
				if (selected < 0) selected = options.Length - 1;
				if (selected > options.Length - 1) selected = 0;
			} while (key.Key != ConsoleKey.Enter);

			return selected;
		}
	}
}
