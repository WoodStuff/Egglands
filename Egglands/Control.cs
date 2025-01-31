namespace Egglands;

/// <summary>
/// Contains methods for controlling the flow of the game.
/// </summary>
internal static class Control
{
	private const ConsoleColor UNSELECTED_OPTION = ConsoleColor.White;
	private const ConsoleColor SELECTED_OPTION = ConsoleColor.Blue;

	/// <summary>
	/// The keys that confirm a choice in <see cref="Options(string[])"/>.
	/// </summary>
	private static readonly ConsoleKey[] OptionConfirmKeys = [ConsoleKey.Enter, ConsoleKey.Spacebar];

	/// <summary>
	/// Enforces a choice by waiting until one of some keys is pressed.
	/// </summary>
	/// <param name="keys">The acceptable keys.</param>
	/// <returns>The pressed input.</returns>
	public static ConsoleKeyInfo Wait(ICollection<ConsoleKey> keys)
	{
		if (keys.Count == 0) throw new ArgumentException("Key list cannot be empty.");

		ConsoleKeyInfo input;

		do
		{
			input = Console.ReadKey(true);
		}
		while (!keys.Contains(input.Key)); // only proceed if requested input is pressed

		return input;
	}

	/// <summary>
	/// Enforces a choice by writing out some options and allowing the user to pick one using arrow keys and enter.
	/// </summary>
	/// <param name="options">The selectable options.</param>
	/// <param name="startAt">The option to start at.</param>
	/// <returns>The index of the option that was selected.</returns>
	public static int Options(ICollection<string> options, int startAt = 0)
	{
		if (options.Count == 0) throw new ArgumentException("Option list cannot be empty.");

		int start = Console.CursorTop; // position of the option list
		int selected = startAt; // currently selected option id

		foreach (string option in options)
		{
			bool initSelected = option == options.ElementAt(startAt);
			Writing.Write(option, initSelected ? SELECTED_OPTION : UNSELECTED_OPTION);
		}

		ConsoleKeyInfo input;
		do
		{
			// up and down arrows for choosing options
			// enter to confirm option
			input = Wait([..OptionConfirmKeys, ConsoleKey.UpArrow, ConsoleKey.DownArrow]);

			if (!OptionConfirmKeys.Contains(input.Key))
				Writing.Write(options.ElementAt(selected), UNSELECTED_OPTION, (0, start + selected));

			if (input.Key == ConsoleKey.UpArrow) // move selected option up
			{
				selected--;
				if (selected < 0) selected = options.Count - 1; // wrapping
			}
			if (input.Key == ConsoleKey.DownArrow) // move selected option down
			{
				selected++;
				if (selected > options.Count - 1) selected = 0; // wrapping
			}

			if (!OptionConfirmKeys.Contains(input.Key))
				Writing.Write(options.ElementAt(selected), SELECTED_OPTION, (0, start + selected));
		} while (!OptionConfirmKeys.Contains(input.Key));

		Console.SetCursorPosition(0, start + options.Count);

		return selected;
	}
}