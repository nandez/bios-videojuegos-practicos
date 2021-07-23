namespace PracticoIntroduccion.Exercises
{
    public static class ExerciseFactory
    {
        public static BaseExercise Create(char exerciseIndex)
        {
            switch (exerciseIndex)
            {
                case 'a': return new Exercise6();
                case 'b': return new Exercise7();
                case 'c': return new Exercise8();
                case 'd': return new Exercise9();
                case 'e': return new Exercise10();
                case 'f': return new Exercise11();
                case 'g': return new Exercise12();
                case 'h': return new Exercise13();
                case 'i': return new Exercise14();
                case 'j': return new Exercise15();
                case 'k': return new Exercise16();
                case 'l': return new Exercise17();
                case 'm': return new Exercise22();

                default: return null;
            }
        }
    }
}