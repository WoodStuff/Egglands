namespace Egglands;

/// <summary>
/// Logic for enemy battles.
/// </summary>
public static class Battle
{
	/// <summary>
	/// Reference to the game player.
	/// </summary>
	private static Player Player => Game.Player;

	/// <summary>
	/// Starts a battle with an enemy.
	/// </summary>
	/// <param name="enemy">The enemy to battle with.</param>
	public static void Start(Enemy enemy)
	{
		RenderUI();

		do
		{
			Control.Options(["Attack"]);

			Player.Damage(enemy.Attack);
			enemy.Damage(Player.Attack);

			RenderUI();
		} while (Player.Alive && enemy.Alive);

		BattleResult result = Player.Alive ? BattleResult.Win : BattleResult.Loss;
		End(result);

		void RenderUI()
		{
			Console.Clear();

			Console.WriteLine(Player);
			Console.WriteLine();
			Console.WriteLine(enemy);
			Console.WriteLine();
		}
	}

	/// <summary>
	/// Ends a battle.
	/// </summary>
	/// <param name="result">How the battle should end.</param>
	private static void End(BattleResult result)
	{
		switch (result)
		{
			case BattleResult.Win:
				Console.WriteLine("Player has won!");
				break;
			case BattleResult.Loss:
				Console.WriteLine("Enemy has won!");
				break;
			default:
				break;
		}
	}
}

/// <summary>
/// The possible outcomes of a battle.
/// </summary>
public enum BattleResult
{
	Win,
	Loss,
}