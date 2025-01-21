namespace Egglands;

public class Enemy
{
	public double Attack { get; set; }
	public double MaxHP { get; set; }
	public double HP { get; set; }

	public Enemy(double attack, double health)
	{
		Attack = attack;
		MaxHP = health;
		HP = health;
	}
}