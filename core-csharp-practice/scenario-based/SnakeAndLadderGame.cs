using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.Scenariobased
{
    internal class SnakeAndLadderGame
    {
        // Ladders: start -> end
        static int[,] ladders =
        {
            { 5, 27 }, { 9, 51 }, { 22, 60 }, { 28, 54 },
            { 44, 79 }, { 53, 69 }, { 66, 88 }, { 71, 92 }, { 85, 97 }
        };

        // Snakes: head -> tail
        static int[,] snakes =
        {
            { 13, 7 }, { 37, 19 }, { 80, 43 },
            { 86, 46 }, { 91, 49 }, { 99, 4 }
        };

        static Random random = new Random();

        static void Main(string[] args)
        {
            SnakeAndLadderGame game = new SnakeAndLadderGame();
            game.StartGame();
        }

        void StartGame()
        {
            Console.Write("Enter number of players (2 to 4): ");
            int playerCount = Convert.ToInt32(Console.ReadLine());

            if (playerCount < 2 || playerCount > 4)
            {
                Console.WriteLine("Invalid input. Players must be between 2 and 4.");
                return;
            }

            string[] playerNames = new string[playerCount];
            int[] playerPositions = new int[playerCount];

            // Taking player names
            for (int i = 0; i < playerCount; i++)
            {
                Console.Write($"Enter name of Player {i + 1}: ");
                playerNames[i] = Console.ReadLine();
                playerPositions[i] = 0;
            }

            bool hasWinner = false;

            // Main game loop
            while (!hasWinner)
            {
                for (int i = 0; i < playerCount; i++)
                {
                    Console.WriteLine($"\n{playerNames[i]}'s turn. Press ENTER to roll dice.");
                    Console.ReadLine();

                    int diceValue = RollDice();
                    Console.WriteLine("Dice rolled: " + diceValue);

                    int previousPosition = playerPositions[i];

                    playerPositions[i] = UpdatePosition(playerPositions[i], diceValue);
                    playerPositions[i] = CheckSnakeOrLadder(playerPositions[i]);

                    Console.WriteLine($"Position: {previousPosition} → {playerPositions[i]}");

                    if (IsWinner(playerPositions[i], playerNames[i]))
                    {
                        hasWinner = true;
                        break;
                    }
                }
            }
        }

        // Dice roll between 1 and 6
        static int RollDice()
        {
            return random.Next(1, 7);
        }

        // Move player if within limit
        int UpdatePosition(int currentPos, int dice)
        {
            if (currentPos + dice <= 100)
            {
                return currentPos + dice;
            }
            else
            {
                Console.WriteLine("Move skipped (exceeds 100).");
                return currentPos;
            }
        }

        // Check for snake or ladder
        int CheckSnakeOrLadder(int pos)
        {
            for (int i = 0; i < ladders.GetLength(0); i++)
            {
                if (pos == ladders[i, 0])
                {
                    Console.WriteLine($"Ladder found! {pos} → {ladders[i, 1]}");
                    return ladders[i, 1];
                }
            }

            for (int i = 0; i < snakes.GetLength(0); i++)
            {
                if (pos == snakes[i, 0])
                {
                    Console.WriteLine($"Snake bite! {pos} → {snakes[i, 1]}");
                    return snakes[i, 1];
                }
            }

            return pos;
        }

        // Win condition
        bool IsWinner(int position, string name)
        {
            bool win = position == 100 ? true : false;

            if (win)
            {
                Console.WriteLine(" Congratulations {name}, you won the game!");
            }

            return win;
        }
    }
}
