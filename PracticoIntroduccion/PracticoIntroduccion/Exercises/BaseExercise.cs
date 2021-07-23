using System;
using System.Collections.Generic;

namespace PracticoIntroduccion.Exercises
{
    public abstract class BaseExercise
    {
        /// <summary>
        /// Indicates the exercise number.
        /// </summary>
        public int ExerciseNumber { get; protected set; }

        /// <summary>
        /// Returns the exercise title.
        /// </summary>
        public string Title => $"Ejercicio {ExerciseNumber}";

        /// <summary>
        /// Contains the string lines to print the exercise description.
        /// </summary>
        public List<string> Description { get; protected set; }

        public BaseExercise()
        {
            // Initializes the list.
            Description = new List<string>();
        }

        public void Run()
        {
            Console.Clear();
            PrintExerciseTitle();

            Console.WriteLine();
            PrintExerciseDescription();

            Console.WriteLine();
            ExecuteExcerciseLogic();
        }

        public virtual void PrintExerciseTitle()
        {
            Console.WriteLine(new string('-', Console.WindowWidth));
            Console.WriteLine(Title);
            Console.WriteLine(new string('-', Console.WindowWidth));
        }

        public virtual void PrintExerciseDescription()
        {
            Console.WriteLine(string.Join(Environment.NewLine, Description));
        }

        /// <summary>
        /// Executes the exercise logic.
        /// Abstract intentionally to force extended classes to provide own implementation.
        /// </summary>
        public abstract void ExecuteExcerciseLogic();
    }
}