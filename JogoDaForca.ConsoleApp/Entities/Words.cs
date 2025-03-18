namespace JogoDaForca.ConsoleApp.Entities
{
    public class Words
    {
        public static string[] Fruits =
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

        public static string[] Animals =
            [
                "CACHORRO",
                "GATO",
                "ELEFANTE",
                "CAVALO",
                "LEAO",
                "TIGRE",
                "ZEBRA",
                "PANDA",
                "LAGARTO",
                "PASSARO",
                "CANGURU",
                "URSO",
                "JACARE",
                "GIRAFA",
                "HIPOPOTAMO",
                "BUFALO",
                "CROCODILO",
                "LULA",
                "TARTARUGA",
                "PEIXE",
                "PIRANHA",
                "GOLFINHO",
                "BALEIA",
                "PINGUIM",
                "CORVO",
                "GAIVOTA",
                "GAVIAO",
                "AGUIA"
            ];

        public static string[] Objects =
            [
                "CADEIRA",
                "MESA",
                "LAMPADA",
                "SOFA",
                "TV",
                "CELULAR",
                "TELEVISAO",
                "COMPUTADOR",
                "FORNO",
                "LIVRO",
                "CANETA",
                "LAPIS",
                "FONE",
                "RELOGIO",
                "ESPONJA",
                "TALHER",
                "COLHER",
                "FACAS",
                "TIGELA",
                "PRATO",
                "CUPOM",
                "ALMOFADA",
                "CARTAZ",
                "MAPA"
            ];

        public static string[] Colors =
            [
                "VERMELHO",
                "AZUL",
                "AMARELO",
                "VERDE",
                "ROXO",
                "LARANJA",
                "BRANCO",
                "PRETO",
                "CINZA",
                "MARROM",
                "BEGE",
                "DOURADO",
                "PRATEADO",
                "LILAS",
                "ROSA",
                "MAGENTA",
                "TURQUESA",
                "INDIGO",
                "CARAMELO",
                "LIMAO",
                "CASTANHO",
                "VIOLETA",
            ];
        public static string WordRandomizer(string option)
        {
            string randomWord = "";

            if (option == "1")
            {
                int chosenIndice = HangMan.randomizer.Next(Fruits.Length);
                randomWord = Fruits[chosenIndice];
                HangMan.wordType = "Frutas";
                HangMan.typeID = 1;
            }
            if (option == "2")
            {
                int chosenIndice = HangMan.randomizer.Next(Animals.Length);
                randomWord = Animals[chosenIndice];
                HangMan.wordType = "Animais";
                HangMan.typeID = 2;
            }
            if (option == "3")
            {
                int chosenIndice = HangMan.randomizer.Next(Objects.Length);
                randomWord = Objects[chosenIndice];
                HangMan.wordType = "Objetos";
                HangMan.typeID = 3;
            }
            if (option == "4")
            {
                int chosenIndice = HangMan.randomizer.Next(Colors.Length);
                randomWord = Colors[chosenIndice];
                HangMan.wordType = "Cores";
                HangMan.typeID = 4;
            }

            return randomWord;
        }
    }
}
