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
	enum Terrain
	{
		Forest,
		Desert,
		Mountain,
	}
	class TerrainManager
	{
		public static string[] GetAppearance(Terrain terrain) => terrain switch
		{
			Terrain.Forest => new string[] {
					"  ,        . ",
					"     .       ",
					"      o   .  ",
					"      ,      ",
					"   v         ",
					"      .      ",
					"          ,  ",
				},
			Terrain.Desert => new string[] {
					"    -        ",
					"        ~    ",
					"  ~          ",
					"     -       ",
					"  o      -   ",
					"     -       ",
					"             ",
				},
			Terrain.Mountain => new string[] {
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
		public static Terrain GetTerrainFromPos(long x, long y)
		{
			//return GetMap()[y][x];
		}
		public static string GetTerrainName(Terrain b) => b switch
		{
			Terrain.Forest => "Forest",
			Terrain.Desert => "Desert",
			Terrain.Mountain => "Mountains",
			_ => "None",
		};
	}
}