using System;

namespace LR2_MRPO.src
{
    internal class GameEngine
    {
        // Метод запуска игр
        public static void RunGame(string gameName, Func<(string, string)> generateRound, string userName)
        {
            Console.WriteLine($"Welcome to {gameName}!");

            // Количество раундов
            int roundCount = 3;
            for (int i = 0; i < roundCount; i++)
            {
                var (question, correctAnswer) = generateRound();
                Console.WriteLine($"Question: {question}");
                Console.Write("Your answer: ");
                // Чтение ответа пользователя с проверкой на null
                string? userAnswer = Console.ReadLine();
                if (string.IsNullOrEmpty(userAnswer))
                {
                    Console.WriteLine($"Invalid input. Please provide an answer.");
                    return;
                }
                CheckAnswer(userAnswer, correctAnswer, userName);
            }

            Console.WriteLine($"Congratulations, {userName}!");
        }
        // Метод проверки ответа на правильно/неправильно
        private static void CheckAnswer(string userAnswer, string correctAnswer, string userName)
        {            
            // Условие - ответ верен или не верен
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
    }
}