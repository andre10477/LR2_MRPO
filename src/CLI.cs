namespace LR2_MRPO
{
    public static class CLI
    {
        public static string GreetUser()
        {
            Console.WriteLine("Welcome to the Brain Games!");
            Console.Write("May I have your name? ");

            // Проверка на null
            string? name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                // Если имя не введено, используем значение по умолчанию
                name = "Player";
            }

            Console.WriteLine($"Hello {name}!");
            return name;
        }
    }
}