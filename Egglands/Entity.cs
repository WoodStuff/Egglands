namespace Egglands;

public abstract class Entity
{
	public double Attack { get; protected set; }
	public double HP { get; protected set; }
	public double MaxHP { get; protected set; }

	public bool Alive => HP > 0;

	public void Damage(double amount)
	{
		HP -= amount;
		if (HP < 0) HP = 0;
	}
}