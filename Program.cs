using guessing_game;

internal class Program
{
    private static void Main(string[] args)
    {
        Game game = new Game();
        Utilidades.Bienvenida();
       
        bool salir = false;

        while (!salir) { 
            Console.WriteLine("Ingrese: start-game para iniciar.\n\thelp para recibir ayuda.\n\tend-game para terminar.");
            string? comando = Console.ReadLine();
            switch (comando)
            {
                case "start-game":
                    game.GuessingGame();
                    break;
                case "help":
                    game.ShowHelp();
                    break;
                case "end-game":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Comando desconocido.\nIngrese: start-game para iniciar.\n\thelp para recibir ayuda.\n\tend-game para terminar.");
                    break;
            }
        }
    }
}