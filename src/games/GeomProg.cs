using LR2_MRPO.src;
using System;

namespace LR2_MRPO
{
    internal class GeomProg
    {
        public void Main(string userName)
        {
            // Запуск игры через движок
            GameEngine.RunGame("Geometric Progression", GenerateRound, userName);
        }

        // Метод, генерирующий вопрос и правильный ответ
        private (string, string) GenerateRound()
        {
            Random r = new Random();
            int start = r.Next(1, 10);      // Начальное число прогрессии
            int ratio = r.Next(2, 5);       // Коэффициент прогрессии
            int length = 10;                // Длина прогрессии
            int hiddenIndex = r.Next(0, length); // Индекс спрятанного элемента

            // Генерируем геометрическую прогрессию
            int[] progression = GenerateProgression(start, ratio, length);

            // Получаем правильный ответ
            int correctAnswer = progression[hiddenIndex];

            // Формируем вопрос с заменой скрытого элемента на ".."
            string question = FormatProgression(progression, hiddenIndex);

            return (question, correctAnswer.ToString());
        }

        // Метод для генерации геометрической прогрессии
        private int[] GenerateProgression(int start, int ratio, int length)
        {
            int[] progression = new int[length];
            for (int i = 0; i < length; i++)
            {
                progression[i] = start * (int)Math.Pow(ratio, i);
            }
            return progression;
        }

        // Метод для формирования строки вопроса
        private string FormatProgression(int[] progression, int hiddenIndex)
        {
            string question = "";
            for (int i = 0; i < progression.Length; i++)
            {
                if (i == hiddenIndex)
                {
                    question += ".. ";
                }
                else
                {
                    question += $"{progression[i]} ";
                }
            }
            return question.Trim();
        }
    }
}