namespace Egglands;

/// <summary>
/// Represents the player character.
/// </summary>
public class Player : Entity
{
	/// <summary>
	/// The player's class, which affects the player's traits and moves.
	/// </summary>
	public Class Class { get; set; }

	public Player(double attack, double health)
	{
		Attack = attack;
		MaxHP = health;
		HP = health;
		Class = Class.Unspecified;
	}

	public override string ToString()
	{
		return $@"{Class.ToString().ToUpper()}
{HP}/{MaxHP} HP
{Attack} ATK";
	}
}

/// <summary>
/// The possible classes the player character can choose from.
/// </summary>
public enum Class
{
	Unspecified,
	Warrior,
}