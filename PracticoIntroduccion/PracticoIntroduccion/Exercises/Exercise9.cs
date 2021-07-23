using System;

namespace PracticoIntroduccion.Exercises
{
    public class Exercise9 : BaseExercise
    {
        public Exercise9() : base()
        {
            ExerciseNumber = 9;
            Description.Add("Dada la siguiente sentencia if anidada, escribir una sola sentencia if que sea equivalente.");
            Description.Add(string.Empty);
            Description.Add("    if( a > b){");
            Description.Add("        if(a > c){");
            Description.Add("            Console.Write (“a es el grande”)");
            Description.Add("        }");
            Description.Add("    }");
        }

        public override void ExecuteExcerciseLogic()
        {
            Console.WriteLine();

            Console.WriteLine("La respuesta sería:");
            Console.WriteLine("  if(a > b && a > c)");
        }
    }
}