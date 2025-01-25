namespace Egglands;

public abstract class Entity
{
	/// <summary>
	/// The entity's attack power.
	/// </summary>
	public double Attack { get; protected set; }
	/// <summary>
	/// The entity's current health points. Cannot go over <see cref="MaxHP"/>.
	/// </summary>
	public double HP { get; protected set; }
	/// <summary>
	/// The entity's maximum health points.
	/// </summary>
	public double MaxHP { get; protected set; }

	/// <summary>
	/// Checks if the entity is alive (HP is positive).
	/// </summary>
	public bool Alive => HP > 0;

	/// <summary>
	/// Damages the entity by some amount.
	/// </summary>
	/// <param name="amount">The amount of damage to take.</param>
	/// <returns>If the entity is still alive.</returns>
	public bool Damage(double amount)
	{
		HP -= amount;
		if (HP < 0) HP = 0;
		return Alive;
	}
}