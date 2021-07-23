using System;
using System.Collections.Generic;

namespace PracticoIntroduccion.Exercises
{
    public class Exercise15 : BaseExercise
    {
        public Exercise15() : base()
        {
            ExerciseNumber = 15;
            Description.Add("Dentro de un proyecto de tipo Consola solicitar el ingreso de una fecha.");
            Description.Add("Se deberá validar si esta es correcta. En caso afirmativo, se deberá determinar si pertenece a un año bisiesto.");
        }

        public override void ExecuteExcerciseLogic()
        {
            Console.WriteLine();

            int year, month, day;

            #region Gets the Year

            bool loop = true;
            do
            {
                Console.Write("Ingrese el año: ");
                if (int.TryParse(Console.ReadLine(), out year))
                {
                    if (year > 0)
                        loop = false;
                    else
                        Logger.Error("ERROR: El valor debe ser mayor a cero.");
                }
            } while (loop);

            #endregion Gets the Year

            #region Gets the Month

            loop = true;
            do
            {
                Console.Write("Ingrese el número de mes [1-12]: ");
                if (int.TryParse(Console.ReadLine(), out month))
                {
                    if (month >= 1 && month <= 12)
                        loop = false;
                    else
                        Logger.Error("ERROR: Ingrese un valor entre 1 y 12.");
                }
            } while (loop);

            #endregion Gets the Month

            #region Gets the day

            // Checks if year is leap.
            bool isLeapYear = year % 4 == 0 && year % 100 != 0 || year % 400 == 0;

            // Stores months with 31 days.
            var monthsWith31Days = new List<int>() { 1, 3, 5, 7, 8, 10, 12 };

            int maxDayValue;
            if (month == 2)
            {
                // February can have 29 days on leap year, otherwhise 28 days.
                maxDayValue = isLeapYear ? 29 : 28;
            }
            else if (monthsWith31Days.Contains(month))
            {
                maxDayValue = 31;
            }
            else
            {
                maxDayValue = 30;
            }

            loop = true;
            do
            {
                Console.Write($"Ingrese el día [1-{maxDayValue}]: ");
                if (int.TryParse(Console.ReadLine(), out day))
                {
                    if (day >= 1 && day <= maxDayValue)
                        loop = false;
                    else
                        Logger.Error($"ERROR: Ingrese un valor entre 1 y {maxDayValue}.");
                }
            } while (loop);

            #endregion Gets the day

            Console.WriteLine();
            Console.WriteLine($"La fecha ingresada es: {day}/{month}/{year}");
            if (isLeapYear)
                Console.WriteLine($"y {year} corresponde a un año bisiesto.");
        }
    }
}