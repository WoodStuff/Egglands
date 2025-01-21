namespace Egglands;

public class Player : Entity
{
	public Player(double attack, double health)
	{
		Attack = attack;
		MaxHP = health;
		HP = health;
	}
}