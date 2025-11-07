using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessing_game
{
    public static class Utilidades
    {
        public static void Bienvenida()
        {
            Console.Write("Bienvenido al juego de adivinar el numero!\n" +
                "Para comenzar ingresa tu nombre: ");

            string? nombre = Console.ReadLine();
            Console.WriteLine($"\nHola {nombre}, espero que te diviertas jugando!");

        }
        public static void Reglas()
        {
            Console.WriteLine("Se escogera un numero al azar entre 1 y 100.");
            Console.WriteLine("Dependiedo la dificultad que elijas tendras ciertos intentos para adivinarlo.");
        }

        public static int Dificultad()
        {
            int intentos = 0;
            string? dificultad;

            Console.WriteLine("========================================");
            Console.WriteLine("----------TIPOS DE DIFICULTAD-----------");
            Console.WriteLine("  - facil (10 intentos)");
            Console.WriteLine("  - medio (5 intentos)");
            Console.WriteLine("  - dificil (3 intentos)");
            Console.WriteLine("========================================");


            do
            {
                Console.WriteLine("Elige una: ");
                dificultad = Console.ReadLine()?.ToLower().Trim();

                if (string.IsNullOrEmpty(dificultad)) {
                    Console.WriteLine("[ERROR] Dificultad no válida. Por favor, elige entre facil, medio o dificil.");
                    intentos = 0;
                }
                else
                {
                    switch (dificultad)
                    {
                        case "facil":
                            intentos = 10;
                            break;
                        case "medio":
                            intentos = 5;
                            break;
                        case "dificil":
                            intentos = 3;
                            break;
                        default:
                            Console.WriteLine($"[ERROR] Dificultad '{dificultad}' no válida. Elige entre facil, medio o dificil.");
                            intentos = 0;
                            break;
                    }
                }
            }while(intentos == 0);

            return intentos;

        }
    }
}
