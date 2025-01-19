namespace Egglands;

internal class Program
{
	static void Main()
	{
		Console.CursorVisible = false;

		Console.WriteLine("====================");
		Console.WriteLine("      EGGLANDS      ");
		Console.WriteLine("====================");
		Console.WriteLine("");

		var option = Control.Options(["Play", "Exit"]);
		if (option == 1) Environment.Exit(0);
	}
}