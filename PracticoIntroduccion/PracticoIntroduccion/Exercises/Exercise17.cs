using System;

namespace PracticoIntroduccion.Exercises
{
    public class Exercise17 : BaseExercise
    {
        public Exercise17() : base()
        {
            ExerciseNumber = 17;
            Description.Add("Dentro de un proyecto de tipo Consola definir un enumerado para los días de la semana");
            Description.Add("(siendo Domingo el primer día) y otro enumerado para los meses del año. Definir una");
            Description.Add("variable de cada tipo enumerado indicado anteriormente, asignarle un valor y");
            Description.Add("desplegarla en pantalla.");
        }

        public override void ExecuteExcerciseLogic()
        {
            Console.WriteLine();

            Days selectedDay = Days.Domingo;
            Months selectedMonth = Months.Enero;

            #region Days

            Console.WriteLine("Días:");
            Console.WriteLine();
            Console.WriteLine($"  {(int)Days.Domingo} - {Days.Domingo}");
            Console.WriteLine($"  {(int)Days.Lunes} - {Days.Lunes}");
            Console.WriteLine($"  {(int)Days.Martes} - {Days.Martes}");
            Console.WriteLine($"  {(int)Days.Miercoles} - {Days.Miercoles}");
            Console.WriteLine($"  {(int)Days.Jueves} - {Days.Jueves}");
            Console.WriteLine($"  {(int)Days.Viernes} - {Days.Viernes}");
            Console.WriteLine($"  {(int)Days.Sabado} - {Days.Sabado}");
            Console.WriteLine();
            bool loop = true;
            do
            {
                Console.Write("Seleccione un día: ");

                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    if (value >= 0 && value <= 6)
                    {
                        selectedDay = (Days)value;
                        loop = false;
                    }
                    else
                    {
                        Logger.Error("ERROR: Ingrese un valor entre 0 y 6");
                    }
                }
            } while (loop);

            #endregion Days

            #region Months

            Console.WriteLine("Meses:");
            Console.WriteLine();
            Console.WriteLine($"  {(int)Months.Enero} - {Months.Enero}");
            Console.WriteLine($"  {(int)Months.Febrero} - {Months.Febrero}");
            Console.WriteLine($"  {(int)Months.Marzo} - {Months.Marzo}");
            Console.WriteLine($"  {(int)Months.Abril} - {Months.Abril}");
            Console.WriteLine($"  {(int)Months.Mayo} - {Months.Mayo}");
            Console.WriteLine($"  {(int)Months.Junio} - {Months.Junio}");
            Console.WriteLine($"  {(int)Months.Julio} - {Months.Julio}");
            Console.WriteLine($"  {(int)Months.Agosto} - {Months.Agosto}");
            Console.WriteLine($"  {(int)Months.Setiembre} - {Months.Setiembre}");
            Console.WriteLine($"  {(int)Months.Octubre} - {Months.Octubre}");
            Console.WriteLine($"  {(int)Months.Noviembre} - {Months.Noviembre}");
            Console.WriteLine($"  {(int)Months.Diciembre} - {Months.Diciembre}");
            Console.WriteLine();

            loop = true;
            do
            {
                Console.Write("Seleccione un mes: ");

                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    if (value >= 0 && value <= 11)
                    {
                        selectedMonth = (Months)value;
                        loop = false;
                    }
                    else
                    {
                        Logger.Error("ERROR: Ingrese un valor entre 0 y 11");
                    }
                }
            } while (loop);

            #endregion Months

            Console.WriteLine();
            Console.WriteLine("Ha seleccionado:");
            Console.WriteLine($"  Día: {selectedDay}");
            Console.WriteLine($"  Mes: {selectedMonth}");
        }
    }

    public enum Days
    {
        Domingo,
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado,
    }

    public enum Months
    {
        Enero,
        Febrero,
        Marzo,
        Abril,
        Mayo,
        Junio,
        Julio,
        Agosto,
        Setiembre,
        Octubre,
        Noviembre,
        Diciembre
    }
}