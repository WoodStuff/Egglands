using Egglands.Lists;

namespace Egglands;

/// <summary>
/// Represents an enemy.
/// </summary>
public class Enemy : Entity
{
	/// <summary>
	/// The index containing every enemy in the game.
	/// </summary>
	public static EnemyFactory Index { get; } = new();

	/// <summary>
	/// The name of the enemy.
	/// </summary>
	public string Name { get; init; }

	public Enemy(string name, double attack, double health)
	{
		Name = name;
		Attack = attack;
		MaxHP = health;
		HP = health;
	}

	public override string ToString()
	{
		return $@"{Name.ToUpper()}
{HP}/{MaxHP} HP
{Attack} ATK";
	}
}