using System;

namespace LR2_MRPO.src
{
    internal class GameEngine
    {
        public static void RunGame(string gameName, Func<(string, string)> generateRound, string userName)
        {
            Console.WriteLine($"Welcome to {gameName}!");

            int roundCount = 3;
            for (int i = 0; i < roundCount; i++)
            {
                var (question, correctAnswer) = generateRound();

                Console.WriteLine($"Question: {question}");
                Console.Write("Your answer: ");
                string userAnswer = Console.ReadLine();

                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine($"'{userAnswer}' is wrong answer ;(. Correct answer was '{correctAnswer}'.");
                    Console.WriteLine($"Let's try again, {userName}!");
                    return;
                }
            }

            Console.WriteLine($"Congratulations, {userName}!");
        }
    }
}
