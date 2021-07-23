using PracticoIntroduccion.Exercises;
using System;
using System.Collections.Generic;

namespace PracticoIntroduccion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                var menuOption = GetMenuOption();

                if (menuOption == 'x')
                {
                    exit = true;
                }
                else
                {
                    var exercise = ExerciseFactory.Create(menuOption);
                    exercise?.Run();

                    Console.WriteLine();
                    Console.Write("Presione una tecla para volver al menú principal...");
                    Console.ReadLine();
                }
            } while (!exit);
        }

        private static char GetMenuOption()
        {
            char output = 'x';

            // Inicializa el diccionario con las opciones de menú.
            var menuOptions = new Dictionary<char, string>
            {
                { 'a', "Ejercicio 6" },
                { 'b', "Ejercicio 7" },
                { 'c', "Ejercicio 8" },
                { 'd', "Ejercicio 9" },
                { 'e', "Ejercicio 10" },
                { 'f', "Ejercicio 11" },
                { 'g', "Ejercicio 12" },
                { 'h', "Ejercicio 13" },
                { 'i', "Ejercicio 14" },
                { 'j', "Ejercicio 15" },
                { 'k', "Ejercicio 16" },
                { 'l', "Ejercicio 17" },
                { 'm', "Ejercicio 22" },
                { 'x', "Salir" }
            };

            bool exit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Practico Introducción");
                Console.WriteLine();
                foreach (var menu in menuOptions)
                    Console.WriteLine($"{(menu.Key == 'x' ? Environment.NewLine : string.Empty)} ({menu.Key}) - {menu.Value}");

                Console.WriteLine();
                Console.Write("Seleccione una opción: ");

                if (char.TryParse(Console.ReadLine(), out char selectedOption))
                {
                    if (menuOptions.ContainsKey(selectedOption))
                    {
                        output = selectedOption;
                        exit = true;
                        break;
                    }
                }

                Logger.Error("ERROR: La opción seleccionada no es correcta.");
                Console.WriteLine("Presione una tecla para intentar nuevamente.");
                Console.ReadLine();
            } while (!exit);

            return output;
        }
    }
}