using System;
using System.Globalization;

namespace PracticoIntroduccion.Exercises
{
    public class Exercise22 : BaseExercise
    {
        public Exercise22() : base()
        {
            ExerciseNumber = 22;
            Description.Add("Dentro de un proyecto de tipo Consola implementar el código necesario para calcular el");
            Description.Add("factorial de un número entero. Se denomina factorial de un número al resultado de");
            Description.Add("multiplicar ese número por todos los enteros anteriores hasta el 1. El signo de factorial");
            Description.Add("es '!' por lo que el factorial de 6 se escribe 6! y se calcula de la siguiente manera:");
            Description.Add(string.Empty);
            Description.Add("    6! = 6*5*4*3*2*1 = 720");
        }

        public override void ExecuteExcerciseLogic()
        {
            Console.WriteLine();

            int number;

            // Obtiene el nombre.
            bool loop = true;
            do
            {
                Console.Write("Ingrese un número positivo > 0: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number >= 0)
                    {
                        loop = false;
                    }
                    else
                    {
                        Logger.Error("ERROR: El valor debe ser postivo y mayor a cero.");
                    }
                }
                else
                {
                    Logger.Error("ERROR: El valor ingresado no es un número válido.");
                }
            } while (loop);

            // Calculates the factorial.
            double factorial = number;
            for (var i = number; i > 1; i--)
                factorial *= (i - 1);

            Console.WriteLine();
            Console.WriteLine($"    !{number} = {factorial.ToString("e16", CultureInfo.InvariantCulture)}");
        }
    }
}