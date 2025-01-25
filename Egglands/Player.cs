namespace Egglands;

public enum Class
{
	Unspecified,
	Warrior,
}

public class Player : Entity
{
	public Class Class { get; init; }

	public Player(double attack, double health)
	{
		Attack = attack;
		MaxHP = health;
		HP = health;
		Class = Class.Unspecified;
	}

	public override string ToString()
	{
		return $@"PLAYER
{HP}/{MaxHP} HP
{Attack} ATK";
	}
}