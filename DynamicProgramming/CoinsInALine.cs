using System;
using System.Text;

namespace LeetCode.Algorithms.DynamicProgramming
{
    public class CoinsInALine
    {
        public int[][] MaxMoneyPlay(int[] coins)
        {
            var gameMoves = new int[100][];
            for (var i = 0; i < coins.Length; i++)
            {
                gameMoves[i] = new int[100];
            }

            for (var coinId = 0; coinId < coins.Length; coinId++)
            {
                var move = 0;
                for (var coin = coinId; coin < coins.Length; coin++)
                {
                    var a = move + 2 <= coins.Length - 1 ? gameMoves[move + 2][coin] : 0;
                    var b = move + 1 <= coins.Length - 1 && coin - 1 >= 0 ? gameMoves[move + 1][coin - 1] : 0;
                    var c = coin - 2 >= 0 ? gameMoves[move][coin - 2] : 0;
                    gameMoves[move][coin] = Math.Max(coins[move] + Math.Min(a, b), coins[coin] + Math.Min(b, c));
                    move++;
                }
            }
            return gameMoves;
        }

        public int MaxMoney(int[] coins)
        {
            return MaxMoneyPlay(coins)[0][coins.Length - 1];
        }

        public string PrintMoves(int[][] gameMoves, int[] coins)
        {
            var result = new StringBuilder();
            var moveIndex = 0;
            var coinIndex = coins.Length - 1;
            var myTurn = true;
            while (moveIndex <= coinIndex)
            {
                var playerOne = gameMoves[moveIndex + 1][coinIndex];
                var playerTwo = gameMoves[moveIndex][coinIndex - 1];
                result.Append(myTurn ? "P1:" : "P2:");
                if (playerOne <= playerTwo)
                {
                    result.Append($"{moveIndex + 1}({coins[moveIndex]})");
                    moveIndex++;
                }
                else
                {
                    result.Append($"{coinIndex + 1}({coins[coinIndex]})");
                    coinIndex--;
                }
                result.Append(myTurn ? "," : ".\n");
                myTurn = !myTurn;
            }
            return result.ToString();
        }
    }
}