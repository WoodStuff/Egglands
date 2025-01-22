namespace Egglands;

public static class Battle
{
	private static Player Player => Game.Player;

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

enum BattleResult
{
	Win,
	Loss,
}