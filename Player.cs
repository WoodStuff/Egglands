namespace Egglands
{
	public class Player
	{
		public Player(string name)
		{
			Name = name;
			Coins = 50;
			X = 4;
			Y = 3;
		}

		public ulong AddCoins(ulong val)
		{
			Coins += val;
			return Coins;
		}
		public ulong SubCoins(ulong val)
		{
			Coins -= val;
			return Coins;
		}
		public ulong SetCoins(ulong val)
		{
			Coins = val;
			return Coins;
		}
		public string Name;
		public ulong Coins;
		public long X;
		public long Y;
	}
}