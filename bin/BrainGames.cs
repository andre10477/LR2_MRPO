using LR2_MRPO.src;
using LR2_MRPO.src.games;

namespace LR2_MRPO.bin
{
    internal class BrainGames
    {
        static void Main(string[] args)
        {
            // Вызов приветствия и ввода имени
            string userName = CLI.GreetUser();
            // Выбор игры
            Console.WriteLine("Choose game:\n" +
                "1. Smallest common multiple\n" +
                "2. Geometric progression\n");

            //Ввод игры
            int game = Convert.ToInt32(Console.ReadLine());

            //Выбор игры, условие
            if (game == 1)
            {
                CSM csm = new();
                csm.Main(userName);  // Передаем имя пользователя в игру
                // Запуск игры через движок
                GameEngine.RunGame("Geometric Progression", csm.GenerateRound, userName);
            }
            else if (game == 2)
            {
                GeomProg gp = new();
                gp.Main(userName);  // Передаем имя пользователя в игру
                // Запуск игры через движок
                GameEngine.RunGame("Geometric Progression", gp.GenerateRound, userName);
            }
        }
    }
}