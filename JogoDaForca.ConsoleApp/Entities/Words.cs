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
                "URSOS",
                "JACARE",
                "GIRAFA",
                "HIPOPOTAMO",
                "REINDEER",
                "BUFALO",
                "CROCODILO",
                "LULA",
                "TARTARUGA",
                "PEIXE",
                "PIRANHA",
                "AQUARIO",
                "GOLFINHO",
                "BALLENA",
                "PINGUIM",
                "CORVO",
                "EAGLE",
                "GAVIAO",
                "AGUIA"
            ];

        public static string[] Objects =
            [
                "CADEIRA",
                "MESA",
                "LAMPADE",
                "SOFA",
                "TV",
                "CELULAR",
                "TELEVISAO",
                "COMPUTADOR",
                "MICRO-ONDAS",
                "FORNO",
                "LIVRO",
                "CANETA",
                "LAPIS",
                "FONE",
                "RELOGIO",
                "MAQUIAGEM",
                "ESPONJA",
                "TALHER",
                "COLHER",
                "FACAS",
                "TIGELA",
                "TACA",
                "PRATO",
                "CUPOM",
                "ALMOFADA",
                "PENDENTE",
                "LIVRARIA",
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
                "MARRON",
                "BEGE",
                "DOURADO",
                "PRATEADO",
                "AZUL_CLARO",
                "VERDE_CLARO",
                "LILAS",
                "PINK",
                "MAGENTA",
                "TURQUESA",
                "INDIGO",
                "CARAMELHO",
                "LIMAO",
                "PELE",
                "FUCIA",
                "CASTANHO",
                "VIOLETA",
                "MARROM_ESCURO",
                "BRANCO_QUENTE",
                "PRETO_ESCURO",
                "AMARELO_CLARO"
            ];
        public static string WordRandomizer(string option)
        {
            Random random = new Random();
            string randomWord = "";

            if (option == "1")
            {
                int chosenIndice = random.Next(Fruits.Length);
                randomWord = Fruits[chosenIndice];
            }
            if (option == "2")
            {
                int chosenIndice = random.Next(Fruits.Length);
                randomWord = Animals[chosenIndice];
            }
            if (option == "3")
            {
                int chosenIndice = random.Next(Fruits.Length);
                randomWord = Objects[chosenIndice];
            }
            if (option == "4")
            {
                int chosenIndice = random.Next(Fruits.Length);
                randomWord = Colors[chosenIndice];
            }

            return randomWord;
        }
    }
}
