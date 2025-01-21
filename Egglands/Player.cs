namespace Egglands;

public class Player
{
	public double Attack { get; set; }
	public double MaxHP { get; set; }
	public double HP { get; set; }

	public Player(double attack, double health)
	{
		Attack = attack;
		MaxHP = health;
		HP = health;
	}
}