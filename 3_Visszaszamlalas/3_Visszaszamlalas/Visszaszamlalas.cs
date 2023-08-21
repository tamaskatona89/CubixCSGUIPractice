using System;

namespace _3_Visszaszamlalas
{
    public class Visszaszamlalas
    {
        public DateTime dateToCompare { get; set; }
        public DateTime dateNOW { get; } = DateTime.Now;

        public Visszaszamlalas(DateTime date)
        {
            this.dateToCompare = date;
        }

        public string Mennyimeg()
        {
            // V A K Á C I Ó = 7 chars



            if (dateToCompare.Date >= dateNOW.Date)
            {
                //dateToCompare is after NOW
                return "Vakáció!";
            }
            else
            {
                //dateToCompare is before NOW

                int businessDaysDiff = (int)GetBusinessDaysDifferenceBetweenTwoDates(dateToCompare, dateNOW);

                if (businessDaysDiff >=7)
                {
                    return "Hol van az még!";
                }
                else
                {
                    return "Vakáció".Substring(businessDaysDiff) + "!";
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
