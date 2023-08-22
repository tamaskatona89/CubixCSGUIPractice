using System;
namespace _3_Visszaszamlalas
{
    public class Visszaszamlalas
    {
        public DateTime DateToCompare { get; set; }
        public DateTime DateNOW { get; } = DateTime.Now;

        public Visszaszamlalas(DateTime date)
        {
            this.DateToCompare = date;
        }

        public string Mennyimeg()
        {
            // V A K Á C I Ó ! = 8 chars

            if (DateToCompare.Date >= DateNOW.Date)
            {
                //dateToCompare is after NOW
                return "Vakáció!";
            }
            else
            {
                //dateToCompare is before NOW

                int businessDaysDiff = (int)GetBusinessDaysDifferenceBetweenTwoDates(DateToCompare, DateNOW);

                if (businessDaysDiff >8)
                {
                    return "Hol van az még!";
                }
                else
                {
                    return "Vakáció!".Substring(businessDaysDiff-1);
                }
            }
        }

        public bool IsWeekend(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                return true;

            return false;
        }

        public int DaysBetweenTwoDates(DateTime StartDate, DateTime EndDate)
        {
            return (EndDate.Date - StartDate.Date).Days;
        }

        public double GetBusinessDaysDifferenceBetweenTwoDates(DateTime StartDate, DateTime EndDate)
        {
            double calcBusinessDays =
                1 + ((EndDate - StartDate).TotalDays * 5 -
                (StartDate.DayOfWeek - EndDate.DayOfWeek) * 2) / 7;

            if (EndDate.DayOfWeek == DayOfWeek.Saturday) calcBusinessDays--;
            if (StartDate.DayOfWeek == DayOfWeek.Sunday) calcBusinessDays--;

            return calcBusinessDays;
        }

    }
}
