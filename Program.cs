using Functions;
using System;

namespace Egglands
{
	/// <summary>
	/// The main class, the game
	/// </summary>
	public class Program
	{
		public static bool hardmode = false;
		public static Player player;
		public static void Main()
		{
			Console.WriteLine("EGGLANDS - THE LAND OF EGGS");
			Console.Write("Text written in ");
			FGame.Command('a', "this format", true);
			Console.WriteLine(" means a command. Press the corresponding key to execute the following action.");
			FMisc.Br();

			FGame.Command('s', "Start the game");
			FGame.Command('i', "Info and about");

			do
			{
				char[] options = { 's', 'i', 'a' };
				FGame.Wait(options);
				Console.WriteLine(cinput);
				if (cinput == 'i')
				{
					Console.WriteLine("Egglands is a game.");
				}
				else if (cinput == 'a')
				{
					Console.WriteLine("Start game in hard mode? (Y/N)");
					options = new char[] { 'y', 'n' };
					FGame.Wait(options);
					if (cinput == 'y')
					{
						hardmode = true;
					}
					else
					{
						Console.WriteLine(cinput);
						Console.WriteLine("Select one of the original options (s, i, a)");
						Console.Write("-> ");
					}
				}
			} while (cinput != 's' && hardmode == false);

			Console.Clear();

			Console.WriteLine("Pick a name for your character");
			Console.Write("-> ");
			player = new Player(Console.ReadLine());
			Console.Clear();

			Console.WriteLine($"You've named your character {player.Name}.");
			Console.WriteLine("To continue, press any key.");
			Console.ReadKey();
			Play();
		}

		public static void Play()
		{
			Console.Clear();

			FGame.RenderUI();
			Console.WriteLine(string.Join("\n", TerrainManager.GetAppearance(TerrainManager.GetTerrainFromPos(player.X, player.Y))));

			FGame.AwaitMovement(player);

			Play();
		}
		public static char cinput;
	}
}