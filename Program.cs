using LR2_MRPO.src.games;

namespace LR2_MRPO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = CLI.GreetUser();

            Console.WriteLine("Choose game:\n" +
                "1. Smallest common multiple\n" +
                "2. Geometric progression\n");

            int game = int.Parse(Console.ReadLine());

            if (game == 1)
            {
                CSM csm = new();
                csm.Main(userName);  // Передаем имя пользователя в игру
            }
            else if (game == 2)
            {
                GeomProg gp = new();
                gp.Main(userName);  // Передаем имя пользователя в игру
            }
        }
    }
}