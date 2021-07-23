using System;

namespace PracticoIntroduccion.Exercises
{
    public class Exercise12 : BaseExercise
    {
        public Exercise12() : base()
        {
            ExerciseNumber = 12;
            Description.Add("Dentro de un proyecto de tipo Consola solicitar la edad y el nombre de una persona.");
            Description.Add("Mostrar un mensaje con los datos pedidos en el caso que sea mayor de edad, o un");
            Description.Add("mensaje acorde en caso contrario. Verificar la validez de la edad.");
        }

        public override void ExecuteExcerciseLogic()
        {
            Console.WriteLine();

            Console.Write("Ingrese su nombre: ");
            string name = Console.ReadLine();

            int age;
            bool loop = true;
            do
            {
                Console.Write("Ingrese su edad: ");
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    if (age >= 0)
                    {
                        loop = false;
                    }
                    else
                    {
                        Logger.Error("ERROR: La edad no puede ser un valor negativo.");
                    }
                }
                else
                {
                    Logger.Error("ERROR: El valor ingresado no es un número válido.");
                }
            } while (loop);

            Console.WriteLine();
            Console.WriteLine("Sus datos son:");
            Console.WriteLine();
            Console.WriteLine($"   Nombre: {name}");
            Console.WriteLine($"   Edad: {name}");
            Console.WriteLine();
            Console.WriteLine($"Usted es {(age >= 18 ? "mayor" : "menor")} de edad.");
        }
    }
}