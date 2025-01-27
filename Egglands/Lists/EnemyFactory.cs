namespace Egglands.Lists;

/// <summary>
/// Contains every enemy in the game. Access this through <see cref="Enemy.Index"/>.
/// </summary>
public class EnemyFactory
{
	public readonly Enemy Zombie = new("Zombie", 2, 200);
}