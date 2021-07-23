using System;

namespace PracticoIntroduccion.Exercises
{
    public class Exercise6 : BaseExercise
    {
        public Exercise6() : base()
        {
            ExerciseNumber = 6;
            Description.Add("Dentro de un proyecto de tipo Consola, solicitar ingreso del Nombre, Fecha de Nacimiento y Cantidad de Hijos.");
            Description.Add("Desplegar todos los datos ingresados con una sola sentencia 'Console.Write'");
        }

        public override void ExecuteExcerciseLogic()
        {
            Console.WriteLine();
            Console.Write("Ingrese su nombre: ");
            string name = Console.ReadLine();

            Console.Write("Ingrese la fecha de nacimiento: ");
            string birthDate = Console.ReadLine();

            bool invalidChildrenCount;
            int children;
            do
            {
                Console.Write("Ingrese la cantidad de hijos: ");
                invalidChildrenCount = !int.TryParse(Console.ReadLine(), out children);

                if (invalidChildrenCount)
                    Logger.Error("Error: el valor ingresado no es válido.");
            } while (invalidChildrenCount);

            Console.WriteLine();
            // var message = "Nombre: " + name + ...
            var message = $"Nombre: {name} | Fecha Nacimiento: {birthDate} | Hijos: {children}";
            Console.WriteLine(message);
        }
    }
}