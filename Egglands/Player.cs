namespace Egglands;

/// <summary>
/// Represents the player character.
/// </summary>
public class Player : Entity
{
	/// <summary>
	/// The player's class, which affects the player's traits and moves.
	/// </summary>
	public Class Class { get; private set; }

	public Player()
	{
		Class = Class.Unspecified;
	}

	public void InitializePlayerStats(Class c)
	{
		Class = c;

		switch (Class)
		{
			case Class.Warrior:
				Attack = 4;
				HP = 20;
				break;

			case Class.Mage:
				Attack = 3;
				HP = 15;
				break;

			default:
				break;
		}

		MaxHP = HP;
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
	Mage,
}