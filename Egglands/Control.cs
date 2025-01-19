namespace Egglands
{
	internal static class Control
	{
		public static void Wait(char[] keys)
		{
			ConsoleKeyInfo key;
			do
			{
				key = Console.ReadKey(true);
			}
			while (!keys.Contains(key.KeyChar));
		}
	}
}
