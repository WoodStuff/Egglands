namespace Egglands;

public class Enemy : Entity
{
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
		return $@"{Name}
{HP}/{MaxHP} HP
{Attack} ATK";
	}
}