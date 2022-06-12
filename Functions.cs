using Egglands;
using System;
using System.Linq;
namespace Functions
{
	public class FGame
	{
		public static void Command(char name, string desc, bool nlb = false)
		{
			ConsoleColor color = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.DarkGray;
			if (nlb == false)
			{
				Console.WriteLine("<" + name.ToString() + " - " + desc + ">");
			}
			else
			{
				Console.Write("<" + name.ToString() + " - " + desc + ">");
			}
			Console.ForegroundColor = color;
		}
		public static void Wait(char[] options)
		{
			do
			{
				ConsoleKeyInfo infoput = Console.ReadKey();
				Program.cinput = infoput.KeyChar;
				FMisc.ClearLine();
			} while (!options.Contains(Program.cinput));
		}
		public static void RenderUI()
		{
			Console.WriteLine(Program.player.Name);
			Console.WriteLine($"{Program.player.X},{Program.player.Y}: {BiomeManager.GetBiomeName(BiomeManager.GetBiomeFromPos(Program.player.X, Program.player.Y))}");
			Console.WriteLine($"{Program.player.Coins}C");
		}
		public static void AwaitMovement(Player player, char[] inputs = null)
		{
			inputs ??= new char[] { 'w', 'a', 's', 'd' };
			Wait(inputs);
			switch (Program.cinput)
			{
				case 'w':
					player.Y--;
					break;
				case 'a':
					player.X--;
					break;
				case 's':
					player.Y++;
					break;
				case 'd':
					player.X++;
					break;
				default:
					break;
			}
		}
	}
	public class FMisc
	{
		public static char AlphaChar(int input)
		{
			if (input < 27 && input > 0)
			{
				char[] choices = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
				int index = input - 1;
				return choices[index];
			}
			else
			{
				throw new ArgumentOutOfRangeException("There are only 26 letters in the alphabet but ok");
			}
		}
		public static string Repeat(char character, int repeated)
		{
			string x;
			for (x = character.ToString(); x.Length < repeated;) { x += character.ToString(); }
			return x;
		}
		public static void Br()
		{
			Console.WriteLine();
		}
		public static void ClearLine()
		{
			int currentLineCursor = Console.CursorTop;
			Console.SetCursorPosition(0, Console.CursorTop);
			Console.Write(new string(' ', Console.WindowWidth));
			Console.SetCursorPosition(0, currentLineCursor);
		}
		public static void WriteColor(ConsoleColor color, string text, bool nlb = true)
		{
			ConsoleColor pastcolor = Console.ForegroundColor;
			Console.ForegroundColor = color;
			if (nlb == false)
			{
				Console.WriteLine(text);
			}
			else
			{
				Console.Write(text);
			}
			Console.ForegroundColor = pastcolor;
		}
	}
}