using System;

namespace PracticoIntroduccion.Exercises
{
    public class Exercise8 : BaseExercise
    {
        public Exercise8() : base()
        {
            ExerciseNumber = 8;
            Description.Add("Considerando la siguiente sentencia if, determinar cuál será el resultado");
            Description.Add("en caso de que la variable 'Calificacion' contenga los valores: 90, 70 y -10.");
            Description.Add(string.Empty);
            Description.Add("    if (Calificacion >= 90) || (Calificacion < 60) {");
            Description.Add("        Console.Write(“Extrema”);");
            Description.Add("    } else {");
            Description.Add("        Console.Write(“Media”);");
            Description.Add("    }");
        }

        public override void ExecuteExcerciseLogic()
        {
            Console.WriteLine();

            Console.WriteLine("El output sería:");
            Console.WriteLine("  Calificacion = 90 ---> “Extrema”");
            Console.WriteLine("  Calificacion = 70 ---> “Media”");
            Console.WriteLine("  Calificacion = -10 --> “Extrema”");
        }
    }
}