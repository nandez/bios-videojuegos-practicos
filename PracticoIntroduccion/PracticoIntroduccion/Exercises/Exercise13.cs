using System;

namespace PracticoIntroduccion.Exercises
{
    public class Exercise13 : BaseExercise
    {
        public Exercise13() : base()
        {
            ExerciseNumber = 13;
            Description.Add("Dentro de un proyecto de tipo Consola solicitar el ingreso de los 3 lados de un triángulo.");
            Description.Add("Determinar si es equilátero, isósceles o escaleno.");
        }

        public override void ExecuteExcerciseLogic()
        {
            Console.WriteLine();

            double sideA = GetSideLength('a');
            double sideB = GetSideLength('b');
            double sideC = GetSideLength('c');

            Console.WriteLine();
            if (sideA == sideB && sideB == sideC)
            {
                Console.WriteLine($"El triángulo es equilátero: todos sus lados son iguales");
            }
            else if (sideA == sideB || sideA == sideC || sideB == sideC)
            {
                Console.WriteLine($"El triángulo es isósceles: 2 de sus lados son iguales.");
            }
            else
            {
                Console.WriteLine($"El triángulo es escaleno: todos sus lados son distintos.");
            }
        }

        private double GetSideLength(char side)
        {
            double output;
            bool loop = true;

            do
            {
                Console.Write($"Ingrese la medida del lado {side}: ");
                if (double.TryParse(Console.ReadLine(), out output))
                {
                    if (output > 0)
                        loop = false;
                    else
                        Logger.Error("ERROR: El valor ingresado no puede ser un número negativo.");
                }
                else
                {
                    Logger.Error("ERROR: El valor ingresado no es un número válido.");
                }
            } while (loop);

            return output;
        }
    }
}