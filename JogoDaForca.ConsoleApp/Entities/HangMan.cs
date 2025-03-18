using JogoDaForca.ConsoleApp.Entities.Utils;

namespace JogoDaForca.ConsoleApp.Entities
{
    class HangMan
    {
        public static Random randomizer = new Random();
        public static int chosenIndice;
        public static string wordType = "";
        public static int typeID = 0;
        public static string randomWord = Words.WordRandomizer(randomizer.Next(1, 5).ToString());

        public static void MainMenu()
        {
            bool mainMenu = true;
            do
            {
                Console.Clear();
                Console.WriteLine("=--=--=--=--=--=--=--=--=--=--=--=");
                Console.WriteLine("Menu Principal");
                Console.WriteLine("=--=--=--=--=--=--=--=--=--=--=--=\n");
                Console.WriteLine("1 >> Começar a Partida");
                Console.WriteLine("2 >> Configurações");
                Console.WriteLine("S >> Voltar à Tela Inicial");
                string option = Auxiliary.OptionVerify("\nOpção: ", ["1", "2", "S"]);

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        GameStart();
                        break;
                    case "2":
                        Console.Clear();
                        GameConfiguration();
                        break;
                    case "S":
                        Console.Clear();
                        mainMenu = false;
                        break;
                }
            } while (mainMenu);
        }
        public static void GameStart()
        {
            while (true)
            {
                if (randomWord == "")
                {
                    randomWord = Words.WordRandomizer(typeID.ToString());
                }
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
                    HangManDraw(ref errorsQuantity, ref findLetters);

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
                        Console.WriteLine($"A palavra era > {randomWord} <...");
                        Console.WriteLine("Que pena, você enforcou o boneco =/");
                        Console.WriteLine("-------------------------------------");
                        break;
                    }
                    if (playerWin)
                    {
                        Console.WriteLine($"Você acertou!! A palavra era > {randomWord} <, parabéns!");
                        Console.WriteLine("-------------------------------------");
                        break;
                    }

                    string letter = Auxiliary.LetterVerify("\nDigite uma letra: ");
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
                randomWord = "";

                Console.Write("Pressione [Enter] para voltar ao menu.");
                Console.ReadKey();
                break;
            }
        }
        public static void GameConfiguration()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("=--=--=--=--=--=--=--=--=--=--=--=");
                Console.WriteLine("Configurações");
                Console.WriteLine("=--=--=--=--=--=--=--=--=--=--=--=\n");
                Console.WriteLine("1 >> Selecionar o Tipo de Palavras");
                Console.WriteLine("S >> Voltar ao Menu Principal");

                string option = Auxiliary.OptionVerify("\nOpção: ", ["1", "S"]);
                if (option == "1")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=");
                        Console.WriteLine("Selecione com qual tipo de palavras você quer jogar");
                        Console.WriteLine($"Atualmente o tipo é > {wordType} <");
                        Console.WriteLine("=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=\n");
                        Console.WriteLine("Digite 1 para Frutas");
                        Console.WriteLine("Digite 2 para Animais");
                        Console.WriteLine("Digite 3 para Objetos");
                        Console.WriteLine("Digite 4 para Cores");
                        Console.WriteLine("Digite S para Voltar às Configurações");
                        string typeChosen = Auxiliary.OptionVerify("\nOpção: ", ["1", "2", "3", "4", "S"]);
                        if (typeChosen == "1" || typeChosen == "2" || typeChosen == "3" || typeChosen == "4")
                        {
                            randomWord = Words.WordRandomizer(typeChosen);
                            Console.WriteLine($"Será do tipo {wordType}, boa sorte!");
                        }
                        if (typeChosen == "S")
                        {
                            break;
                        }
                    } while (true);
                }
                if (option == "S")
                {
                    break;
                }
            } while (true);
        }
        public static void HangManDraw(ref int errorsQuantity, ref char[] findLetters)
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
        }
    }
}
