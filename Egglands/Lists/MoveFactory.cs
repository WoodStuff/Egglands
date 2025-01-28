namespace Egglands.Lists;

/// <summary>
/// Contains every move in the game. Access this through <see cref="Move.Index"/>.
/// </summary>
public class MoveFactory
{
	public readonly Move Attack = new("Attack", 1);
	public readonly Move Fireball = new("Fireball", 2);
}