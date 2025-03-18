namespace JogoDaForca.ConsoleApp.Entities.Utils
{
    class Auxiliary
    {
        public static string LetterVerify(string prompt)
        {
            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine()!;
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine($"Precisa conter uma letra...");
                    continue;
                }
                if (!input.All(char.IsLetter))
                {
                    Console.WriteLine("Precisa ser uma letra!");
                    continue;
                }
                if (input.Length > 1)
                {
                    Console.WriteLine("Precisa ser apenas uma letra...");
                    continue;
                }
                return input = input.ToUpper();
            } while (true);
        }
        public static string OptionVerify(string prompt, string[] options)
        {
            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine()!;

                if (input == null)
                {
                    Console.WriteLine($"\nAcho que isso não é uma opção...");
                    continue;
                }
                input = input.ToUpper();
                for (int i = 0; i < options.Length; i++)
                {
                    if (input == options[i])
                    {
                        return input;
                    }
                }

                Console.WriteLine($"Acredito que ({input}) não é uma das opções...");
            } while (true);
        }
    }
}
