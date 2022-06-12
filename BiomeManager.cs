using System.Linq;
namespace Egglands
{
	enum Directions
	{
		North,
		East,
		South,
		West,
	}
	enum Biome
	{
		Forest,
		Desert,
		Mountain,
	}
	class BiomeManager
	{
		public static string[] GetAppearance(Biome biome) => biome switch
		{
			Biome.Forest => new string[] {
					"  ,        . ",
					"     .       ",
					"      o   .  ",
					"      ,      ",
					"   v         ",
					"      .      ",
					"          ,  ",
				},
			Biome.Desert => new string[] {
					"    -        ",
					"        ~    ",
					"  ~          ",
					"     -       ",
					"  o      -   ",
					"     -       ",
					"             ",
				},
			Biome.Mountain => new string[] {
					"    ^        ",
					"   ^    ^    ",
					"      ^  ^   ",
					"  ^        ^ ",
					"      ^   / \\",
					"     / \\     ",
					"             ",
				},
			_ => new string[] {
					"             ",
					" ?         ? ",
					"             ",
					"             ",
					"             ",
					" ?         ? ",
					"             ",
				},
		};
		public static Biome GetBiomeFromPos(long x, long y)
		{
			return GetMap()[y][x];
		}
		public static string GetBiomeName(Biome b) => b switch
		{
			Biome.Forest => "Forest",
			Biome.Desert => "Desert",
			Biome.Mountain => "Mountains",
			_ => "None",
		};
		private static Biome[][] GetMap() {
			Biome F = Biome.Forest;
			Biome D = Biome.Desert;

			Biome[][] map = {
				//              SPAWN v           1
				//            0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9
				new Biome[] { D,D,D,F,F,F }, // 0
				new Biome[] { D,F,F,F,F,F }, // 1
				new Biome[] { F,F,F,F,F,F }, // 2
				new Biome[] { F,F,F,F,F,F }, // 3 < SPAWN
				new Biome[] { F,F,F,F,F,F }, // 4
			};
			return map;
		}
	}
}