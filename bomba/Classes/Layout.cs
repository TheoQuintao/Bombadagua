namespace Layout
{
    class Formatação
    {
        public static void Cor(ConsoleColor Letra)
        {
            Console.ForegroundColor = Letra;  
        }
        public static void ImprimirCabecalho(string txt)
        {
            int posicaoCentralizada = (Console.WindowWidth / 2) - (txt.Length / 2);
            Console.SetCursorPosition(posicaoCentralizada, Console.CursorTop);
            Console.Write("╔═");
            foreach (char i in txt)
            {
                Console.Write("═");
            }
            Console.WriteLine("═╗");
            Console.SetCursorPosition(posicaoCentralizada, Console.CursorTop);
            Console.WriteLine($"║ {txt} ║");
            Console.SetCursorPosition(posicaoCentralizada, Console.CursorTop);
            Console.Write("╚═");
            foreach (char i in txt)
            {
                Console.Write("═");
            }
            Console.WriteLine("═╝");
        }
    }
}