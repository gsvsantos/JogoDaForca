using JogoDaForca.ConsoleApp.Entities;
using System.Threading.Channels;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=--=--=--=--=--=--=--=--=--=--=--=");
            Console.WriteLine("Boas vindas ao Jogo da Forca D:");
            Console.WriteLine("=--=--=--=--=--=--=--=--=--=--=--=\n");
            Console.WriteLine("1 >> Iniciar o Jogo");
            Console.WriteLine("S >> Fechar o Jogo");
            string option = Console.ReadLine()!;
            switch (option)
            {
                case "1":
                    Console.Clear();
                    HangMan.MainMenu();
                    break;
                case "S":
                    Console.Clear();
                    Console.WriteLine("Adeus (T_T)/");
                    break;
                default:
                    Console.WriteLine("Isso não é uma opção..");
                    break;
            }
        }
    }
}
