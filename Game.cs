using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessing_game
{
    public class Game
    {
        public void ShowHelp()
        {
            Utilidades.Reglas();
        }
        public void GuessingGame()
        {
            Random rand = new Random();
            int random = rand.Next(1, 101);

            int intentos = Utilidades.Dificultad();

            bool encontrado = false;
            int contador = 0;

            while(intentos > 0)
            {
                contador++;
                Console.WriteLine("Ingresa un numero entre 1 y 100: ");
                string? entrada = Console.ReadLine();
                int numero;

                if(!int.TryParse(entrada, out numero) || numero<1 || numero>100)
                {
                    Console.WriteLine("Por favor ingresa un numero valido entre 1 y 100.");
                }
                else
                {
                    if (numero > random)
                    {
                        intentos--;
                        Console.WriteLine($"Incorrecto, el numero es menor a {numero}. Te quedan {intentos} intentos!");
                    }
                    else if (numero < random)
                    {
                        intentos--;
                        Console.WriteLine($"Incorrecto, el numero es mayor a {numero}. Te quedan {intentos} intentos!");
                    }
                    else
                    {
                        Console.WriteLine($"Felicidades! Adivinaste el numero en {contador} intentos! ");
                        encontrado = true;
                        intentos = 0;
                    }
                }
            }
            if (!encontrado)
            {
                Console.WriteLine($"Lo siento, no lograste adivinar el numero. El numero era {random}.");
            }
        }
    }
}
