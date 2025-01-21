namespace Egglands;

public class Enemy : Entity
{
	public Enemy(double attack, double health)
	{
		Attack = attack;
		MaxHP = health;
		HP = health;
	}
}