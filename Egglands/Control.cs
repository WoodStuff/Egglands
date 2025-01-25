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
	public static ConsoleKeyInfo Wait(ConsoleKey[] keys)
	{
		if (keys.Length == 0) throw new ArgumentException("Key list cannot be empty.");

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
	/// <returns>The index of the option that was selected.</returns>
	public static int Options(string[] options)
	{
		if (options.Length == 0) throw new ArgumentException("Option list cannot be empty.");

		int start = Console.CursorTop; // position of the option list
		int selected = 0; // currently selected option id

		foreach (string option in options)
		{
			bool first = option == options[0];
			Writing.Write(option, first ? SELECTED_OPTION : UNSELECTED_OPTION);
		}

		ConsoleKeyInfo input;
		do
		{
			// up and down arrows for choosing options
			// enter to confirm option
			input = Wait([..OptionConfirmKeys, ConsoleKey.UpArrow, ConsoleKey.DownArrow]);

			if (!OptionConfirmKeys.Contains(input.Key))
				Writing.Write(options[selected], UNSELECTED_OPTION, (0, start + selected));

			if (input.Key == ConsoleKey.UpArrow) // move selected option up
			{
				selected--;
				if (selected < 0) selected = options.Length - 1; // wrapping
			}
			if (input.Key == ConsoleKey.DownArrow) // move selected option down
			{
				selected++;
				if (selected > options.Length - 1) selected = 0; // wrapping
			}

			if (!OptionConfirmKeys.Contains(input.Key))
				Writing.Write(options[selected], SELECTED_OPTION, (0, start + selected));
		} while (!OptionConfirmKeys.Contains(input.Key));

		return selected;
	}
}