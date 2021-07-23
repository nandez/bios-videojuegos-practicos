using System;

namespace PracticoIntroduccion.Exercises
{
    public class Exercise10 : BaseExercise
    {
        public Exercise10() : base()
        {
            ExerciseNumber = 10;
            Description.Add("Dado el siguiente segmento de programa, determinar los valores finales de las variables X e Y.");
            Description.Add(string.Empty);
            Description.Add("    int x = 7;");
            Description.Add("    int y = 8;");
            Description.Add(string.Empty);
            Description.Add("    if (x > y) {");
            Description.Add("        x = x + 1;");
            Description.Add("    } else {");
            Description.Add("        y = y + 1;");
            Description.Add("    }");
        }

        public override void ExecuteExcerciseLogic()
        {
            Console.WriteLine();

            Console.WriteLine("La respuesta sería:");
            Console.WriteLine("  x: 7");
            Console.WriteLine("  y: 9");
        }
    }
}