using System;

namespace PracticoIntroduccion.Exercises
{
    public class Exercise11 : BaseExercise
    {
        public Exercise11() : base()
        {
            ExerciseNumber = 11;
            Description.Add("Dentro de un proyecto de tipo Consola solicitar 2 números enteros desde teclado.");
            Description.Add("Realizar la división del primer número leído por el segundo. Tomar en cuenta que debe");
            Description.Add("controlarse que el divisor sea distinto de 0. En caso de que sea 0, deberá desplegarse un");
            Description.Add("mensaje de error y la operación no deberá ser realizada.");
            Description.Add("    --> Desplegar el resultado de la división.");
            Description.Add("    --> Desplegar el resto de la división.");
        }

        public override void ExecuteExcerciseLogic()
        {
            Console.WriteLine();

            // Asks user to input both values.
            double dividend = GetDividend();
            double divider = GetDivider();

            if (divider != 0)
            {
                double result = dividend / divider;
                double remainder = dividend % divider;

                Console.WriteLine();
                Console.WriteLine($"Operación: {dividend} / {divider}");
                Console.WriteLine($"Resultado: {result}");
                Console.WriteLine($"    Resto: {remainder}");
            }
            else
            {
                Logger.Error("ERROR: No es posible dividir entre 0.");
            }
        }

        private double GetDividend()
        {
            double output;
            bool loop = true;
            do
            {
                Console.Write("Ingrese el dividendo: ");
                if (double.TryParse(Console.ReadLine(), out output))
                {
                    loop = false;
                }
                else
                {
                    Logger.Error("ERROR: El valor ingresado no es un número válido.");
                }
            } while (loop);

            return output;
        }

        private double GetDivider()
        {
            double output;
            bool loop = true;
            do
            {
                Console.Write("Ingrese el divisor: ");
                if (double.TryParse(Console.ReadLine(), out output))
                {
                    // TODO: here we can keep looping if zero, to provide
                    // a valid divider value.
                    /*
                    if (output == 0)
                        Console.WriteLine("ERROR: No es posible dividir entre 0.");

                    loop = output != 0;
                    */

                    loop = false;
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