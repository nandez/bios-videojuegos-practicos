using System;

namespace PracticoIntroduccion.Exercises
{
    public class Exercise7 : BaseExercise
    {
        public Exercise7() : base()
        {
            ExerciseNumber = 7;
            Description.Add("Dentro de un proyecto de tipo Consola, solicitar ingreso del Nombre y el Apellido.");
            Description.Add("Mostrar en pantalla:");
            Description.Add(" --> nombre completo (compuesto por el nombre y el apellido)");
            Description.Add(" --> iniciales de la persona");
            Description.Add(" --> cantidad de letras del nombre y cantidad de letras del apellido");
        }

        public override void ExecuteExcerciseLogic()
        {
            Console.WriteLine();

            string firstName, lastName;

            // Obtiene el nombre.
            bool loop = true;
            do
            {
                Console.Write("Ingrese su nombre: ");
                firstName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(firstName))
                    loop = false;
            } while (loop);

            // Obtiene el apellido
            loop = true;
            do
            {
                Console.Write("Ingrese su apellido: ");
                lastName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(lastName))
                    loop = false;
            } while (loop);

            Console.WriteLine();
            Console.WriteLine($"Nombre Completo: {firstName} {lastName}");
            Console.WriteLine($"Iniciales: {firstName?.Substring(0, 1)}{lastName?.Substring(0, 1)}");
            Console.WriteLine($"{firstName} -> {firstName?.Length ?? 0} caracteres.");
            Console.WriteLine($"{lastName} -> {lastName?.Length ?? 0} caracteres.");
        }
    }
}