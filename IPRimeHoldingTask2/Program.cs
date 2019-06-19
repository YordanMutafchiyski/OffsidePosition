using System;

namespace IPRimeHoldingTask2
{
	class Program
	{
		public const int MIN_PLAYERS = 2;
		public const int TEAM_ONE = 0;
		public const int TEAM_TWO = 1;
		public static bool offsidePosition(int[][] teams)
		{
			Array.Sort(teams[0]);
			Array.Sort(teams[1]);
			return checkAttackingTeam(teams, TEAM_TWO, TEAM_ONE ) || checkDeffensiveTeam(teams ,TEAM_ONE, TEAM_TWO);

		}

		public static bool checkAttackingTeam(int[][] teams, int attackingTeam, int defensiveTeam)
		{
			int offsiePlayer = teams[attackingTeam][0];
			int numberOfOppositePlayers = 0;
			for (int i = 0; i < teams[1].Length; i++)
			{
				if (teams[defensiveTeam][i] <= offsiePlayer)
				{
					numberOfOppositePlayers++;
				}
			}
			if (numberOfOppositePlayers < MIN_PLAYERS)
			{
				return true;
			}
			return false;
		}

		public static bool checkDeffensiveTeam(int[][] teams, int attackingTeam, int defensiveTeam)
		{
			int offsiePlayer = teams[attackingTeam][teams[attackingTeam].Length - 1];
			int numberOfOppositePlayers = 0;
			for (int i = 0; i < teams[1].Length; i++)
			{
				if (teams[defensiveTeam][i] >= offsiePlayer)
				{
					numberOfOppositePlayers++;
				}
			}
			if (numberOfOppositePlayers < MIN_PLAYERS)
			{
				return true;
			}
			return false;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(offsidePosition(new int[][] { new int[] { 5, 22, 30, 40, 30, 50, 30, 50, 50, 60, 50 }, new int[] { 96, 20, 30, 25, 25, 40, 60, 70, 80, 70, 40 } }));
			Console.WriteLine(offsidePosition(new int[][] { new int[] { 5, 22, 30, 40, 30, 50, 30, 50, 50, 60, 50 }, new int[] { 96, 28, 30, 25, 25, 40, 60, 70, 80, 70, 40 } }));
			Console.WriteLine(offsidePosition(new int[][] { new int[] { 5, 20, 30, 40, 30, 50, 30, 50, 50, 60, 50 }, new int[] { 96, 20, 30, 25, 25, 40, 60, 70, 80, 70, 40 } }));

		}

	}
}
