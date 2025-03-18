using JogoDaForca.ConsoleApp.Entities;
using JogoDaForca.ConsoleApp.Entities.Utils;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool onMainMenu = true;
            do
            {
                Console.Clear();
                Console.WriteLine("=--=--=--=--=--=--=--=--=--=--=--=");
                Console.WriteLine("Boas vindas ao Jogo da Forca D:");
                Console.WriteLine("=--=--=--=--=--=--=--=--=--=--=--=\n");
                Console.WriteLine("1 >> Iniciar o Jogo");
                Console.WriteLine("S >> Fechar o Jogo");
                string option = Auxiliary.OptionVerify("\nOpção: ", ["1", "S"]);

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        HangMan.MainMenu();
                        break;
                    case "S":
                        Console.Clear();
                        Console.WriteLine("Adeus (T_T)/");
                        onMainMenu = false;
                        break;
                }
            } while (onMainMenu);
        }
    }
}
