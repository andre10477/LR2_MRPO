using System;
using LR2_MRPO.src;

namespace LR2_MRPO.src.games
{
    internal class CSM
    {
        public void Main(string userName)
        {
            // Запуск игры через движок
            GameEngine.RunGame("Smallest Common Multiple", GenerateRound, userName);
        }

        // Метод, генерирующий вопрос и правильный ответ
        private (string, string) GenerateRound()
        {
            Random r = new Random();
            int num1 = r.Next(1, 100);
            int num2 = r.Next(1, 100);
            int num3 = r.Next(1, 100);

            // Вычисляем правильный ответ (НОК)
            int correctAnswer = FindLCM(FindLCM(num1, num2), num3);
            string question = $"{num1} {num2} {num3}";

            // Возвращаем вопрос и правильный ответ
            return (question, correctAnswer.ToString());
        }

        // Метод для нахождения НОК двух чисел
        private int FindLCM(int a, int b)
        {
            return a * b / FindGCD(a, b);
        }

        // Метод для нахождения НОД (наибольший общий делитель)
        private int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}