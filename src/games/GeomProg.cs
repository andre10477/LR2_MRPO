using System;
using LR2_MRPO.src;

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

            int[] progression = new int[length];

            // Генерация геометрической прогрессии
            for (int i = 0; i < length; i++)
            {
                progression[i] = start * (int)Math.Pow(ratio, i);
            }

            // Спрятанный элемент
            int correctAnswer = progression[hiddenIndex];
            progression[hiddenIndex] = -1; // Заменяем на ..

            // Формируем вопрос
            string question = "";
            for (int i = 0; i < length; i++)
            {
                if (progression[i] == -1)
                {
                    question += ".. ";
                }
                else
                {
                    question += $"{progression[i]} ";
                }
            }

            // Возвращаем вопрос и правильный ответ
            return (question.Trim(), correctAnswer.ToString());
        }
    }
}
