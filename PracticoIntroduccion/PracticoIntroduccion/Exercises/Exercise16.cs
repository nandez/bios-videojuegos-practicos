using System;

namespace PracticoIntroduccion.Exercises
{
    public class Exercise16 : BaseExercise
    {
        public Exercise16() : base()
        {
            ExerciseNumber = 16;
            Description.Add("Dentro de un proyecto de tipo Consola generar el código necesario para resolver");
            Description.Add("ecuaciones de segundo grado.El objetivo es encontrar el/los valores de x que hacen");
            Description.Add("que la ecuación efectivamente dé cero, pidiéndole al usuario los valores de a, b y c.");
            Description.Add("Se tomarán solamente las soluciones que sean números reales, no imaginarios.");
            Description.Add("Para ayudar a calcular la solución definiremos un valor llamado discriminante el cual");
            Description.Add("tiene la siguiente forma para calcularlo: b2 – 4ac");
        }

        public override void ExecuteExcerciseLogic()
        {
            Console.WriteLine();

            // Gets all the terms..
            var a = GetTerm("a");
            var b = GetTerm("b");
            var c = GetTerm("c");

            double discr = b * b - 4 * a * c;
            double x, x1, x2;

            Console.WriteLine();
            Console.WriteLine($"La ecuación {a}x2 + {b}x + {c} = 0");
            if (discr > 0)
            {
                x1 = (-b + Math.Sqrt(discr)) / (2 * a);
                x2 = (-b - Math.Sqrt(discr)) / (2 * a);

                Console.WriteLine("tiene 2 soluciones:");
                Console.WriteLine("   {0,8:f4}", x1);
                Console.WriteLine("   {0,8:f4}", x2);
            }
            else if (discr < 0)
            {
                Console.WriteLine("no tiene solucion.");
            }
            else
            {
                x = (-b + Math.Sqrt(discr)) / (2 * a);

                Console.WriteLine("tiene 2 soluciones:");
                Console.WriteLine("   {0,8:f4}", x);
            }
        }

        private double GetTerm(string termName)
        {
            double output;
            bool loop = true;

            do
            {
                Console.Write($"Ingrese el valor para el término en {termName}: ");
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
    }
}