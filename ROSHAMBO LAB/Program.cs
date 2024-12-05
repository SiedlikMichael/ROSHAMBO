using ROSHAMBO_LAB;
using System;
using System.Reflection.Metadata.Ecma335;

using System;

namespace ROSHAMBO_LAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the ROSHAMBO GAME");
                HumanPlayer humanPlayer = new HumanPlayer();

                Console.WriteLine("Choose your opponent:");
                Console.WriteLine("1. RockPlayer");
                Console.WriteLine("2. RandomPlayer");

                int opponentChoice = GetValidInput(1, 2);

                Player opponentPlayer;
                if (opponentChoice == 1)
                {
                    opponentPlayer = new RockPlayer();
                }
                else
                {
                    opponentPlayer = new RandomPlayer();
                }

                Console.WriteLine("Pick your move:");
                Console.WriteLine("0. Rock");
                Console.WriteLine("1. Paper");
                Console.WriteLine("2. Scissors");

                humanPlayer.selected = GetValidInput(0, 2);

                Roshambo humanMove = humanPlayer.GenerateRoshambo();
                Roshambo opponentMove = opponentPlayer.GenerateRoshambo();

                Console.WriteLine($"You chose: {humanMove}");
                Console.WriteLine($"Opponent chose: {opponentMove}");

            

            }
            catch (Exception ex)
            {
                Console.WriteLine($"error occurred: {ex.Message}");
            }
        }

        static int GetValidInput(int min, int max)
        {
            int choice;
            while (true)
            {
                Console.Write("Enter your choice: ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= min && choice <= max)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Please enter a valid number between {min} and {max}.");
                }
            }
            return choice;
        }
    }
}











