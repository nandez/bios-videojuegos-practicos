using System;

namespace PracticoIntroduccion.Exercises
{
    public class Exercise14 : BaseExercise
    {
        public Exercise14() : base()
        {
            ExerciseNumber = 14;
            Description.Add("Dentro de un proyecto de tipo Consola solicitar el ingreso de las notas de un alumno.");
            Description.Add("Estas serán: 3 obligatorios de una puntuación de 0 a 10, una prueba de puntuación de 0");
            Description.Add("a 50 y un obligatorio de puntuación de 0 a 20. Se deberá determinar si el alumno va a");
            Description.Add("examen (puntuación total de 0 a 69) o exonero el curso (puntuación de 70 a 100).");
        }

        public override void ExecuteExcerciseLogic()
        {
            Console.WriteLine();

            int totalScore = 0;

            // 3 Obligatorios 0 a 10.
            for (int i = 0; i < 3; i++)
                totalScore += GetEvaluationScore($"Obligatorio {i + 1}", 0, 10);

            // Prueba de 0 a 50
            totalScore += GetEvaluationScore("Obligatorio 'Prueba 50'", 0, 50);

            // Obligatorio de 0 a 20
            totalScore += GetEvaluationScore("Obligatorio 'Prueba 20'", 0, 20);

            Console.WriteLine();
            Console.WriteLine($"Puntaje Total: {totalScore}");
            Console.WriteLine($"El alumno {(totalScore >= 70 ? " exoneró el curso" : " debe rendir exámen")}.");
        }

        private int GetEvaluationScore(string evaluationName, int minScore, int maxScore)
        {
            int output;
            bool loop = true;

            do
            {
                Console.Write($"Ingrese la puntuación de la evaluacion {evaluationName} [{minScore}-{maxScore}]: ");
                if (int.TryParse(Console.ReadLine(), out output))
                {
                    if (output >= minScore && output <= maxScore)
                        loop = false;
                    else
                        Logger.Error($"ERROR: El valor ingresado debe ser un número entre {minScore} y {maxScore}.");
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