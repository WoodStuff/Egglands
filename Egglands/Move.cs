using Egglands.Lists;

namespace Egglands;

/// <summary>
/// Represents a move that can be used in battle.
/// </summary>
public class Move
{
	/// <summary>
	/// The index containing every move in the game.
	/// </summary>
	public static MoveFactory Index { get; } = new();

	/// <summary>
	/// The move's display name.
	/// </summary>
	public string Name;
	/// <summary>
	/// The move's attack power.
	/// </summary>
	public double Power;

	public Move(string name, double power)
	{
		Name = name;
		Power = power;
	}
}