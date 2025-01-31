using Egglands.Lists;

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
	/// <summary>
	/// The moves that the player can use in battle.
	/// </summary>
	public List<Move> Moves { get; }

	/// <summary>
	/// Creates a new instance of the <see cref="Player"/> class. To set the player up, use <see cref="InitializePlayerStats(Class)"/>.
	/// </summary>
	public Player()
	{
		Class = Class.Unspecified;
		Moves = [];
	}

	/// <summary>
	/// Sets the player to the default stats depending on the selected class.
	/// </summary>
	/// <param name="c">The player's class.</param>
	public void InitializePlayerStats(Class c)
	{
		Class = c;

		Moves.Add(Move.Index.Attack); // default attack

		switch (Class)
		{
			case Class.Warrior:
				Attack = 4;
				HP = 200;
				break;

			case Class.Mage:
				Attack = 3;
				HP = 150;
				Moves.Add(Move.Index.Fireball); // extra attack
				break;

			default:
				break;
		}

		MaxHP = HP;
	}

	/// <summary>
	/// Retrieves the display names of the player's moves.
	/// </summary>
	/// <returns>A list containing the display names in <see cref="Moves"/>.</returns>
	public List<string> GetMoveNames() => Moves.Select(move => move.Name).ToList();

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