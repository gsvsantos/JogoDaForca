namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();
                string[] words =
                [
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "ABACATE",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
                ];

                int chosenIndice = random.Next(words.Length);
                string randomWord = words[chosenIndice];

                char[] findLetters = new char[randomWord.Length];

                for (int actualChar = 0; actualChar < findLetters.Length; actualChar++)
                {
                    findLetters[actualChar] = '_';
                }

                int errorsQuantity = 0;
                bool playerWin = false;
                bool playerLose = false;

                do
                {
                    string head = errorsQuantity >= 1 ? " O " : " ";
                    string body = errorsQuantity >= 2 ? "|" : " ";
                    string leftArm = errorsQuantity >= 3 ? "/" : " ";
                    string rightArm = errorsQuantity >= 4 ? @"\" : " ";
                    string leftLeg = errorsQuantity >= 5 ? "/ " : " ";
                    string rightLeg = errorsQuantity >= 6 ? "\\" : " ";

                    Console.Clear();
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine(" ___________         ");
                    Console.WriteLine(" |/        |         ");
                    Console.WriteLine(" |        {0}        ", head);
                    Console.WriteLine(" |        {0}{1}{2}  ", leftArm, body, rightArm);
                    Console.WriteLine(" |         {0}       ", body);
                    Console.WriteLine(" |        {0}{1}     ", leftLeg, rightLeg);
                    Console.WriteLine(" |                   ");
                    Console.WriteLine(" |                   ");
                    Console.WriteLine("_|____               ");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine($"Palavra escolhida: {String.Join("", findLetters)}");
                    Console.WriteLine("-------------------------------------");
                    if (errorsQuantity <= 5)
                    {
                        Console.WriteLine($"Erros do Jogador: {errorsQuantity}");
                        Console.WriteLine("-------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine($"Você errou {errorsQuantity} vezes...");
                        Console.WriteLine("-------------------------------------");
                    }

                    if (playerLose)
                    {
                        Console.WriteLine("Que pena, você enforcou o boneco =/");
                        Console.WriteLine("-------------------------------------");
                        break;
                    }

                    if (playerWin)
                    {
                        Console.WriteLine($"Você acertou a palavra {randomWord}, parabéns!");
                        Console.WriteLine("-------------------------------------");
                        break;
                    }

                    Console.Write("Digite uma letra: ");
                    string letter = Console.ReadLine()!.ToUpper();
                    if (letter.Length > 1)
                    {
                        Console.WriteLine("Precisa ser uma letra");
                        Console.Write("Pressione [Enter] e tente novamente!");
                        Console.ReadKey();
                        continue;
                    }

                    char guess = letter[0];

                    bool letterWasFound = false;

                    for (int charCount = 0; charCount < randomWord.Length; charCount++)
                    {

                        if (guess == randomWord[charCount])
                        {
                            findLetters[charCount] = randomWord[charCount];
                            letterWasFound = true;
                        }
                    }

                    if (letterWasFound == false)
                    {
                        errorsQuantity++;
                    }

                    string wordFound = String.Join("", findLetters);

                    playerWin = wordFound == randomWord;
                    playerLose = errorsQuantity > 5;
                } while (true);

                Console.Write("Deseja jogar novamente? (S/N): ");
                string optionContinue = Console.ReadLine().ToUpper();

                while (optionContinue != "S" && optionContinue != "N")
                {
                    Console.Write("\nOpção inválida!\n\nPressione <Enter> e selecione novamente.");
                    Console.Write("\nDeseja continuar? (S/N): ");
                    optionContinue = Console.ReadLine().ToUpper();
                }

                if (optionContinue != "S")
                    break;
            }
        }
    }
}
