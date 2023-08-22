using System;
using _3_Visszaszamlalas;

namespace VisszaszamlalasCORE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                throw new ArgumentException("Csak 3 argumentummal működök! (ÉV HÓ NAP) (2023 8 22)");
            }
            int year = Int32.Parse(args[0]);
            int month = Int32.Parse(args[1]);
            int day = Int32.Parse(args[2]);
            Visszaszamlalas datum = new Visszaszamlalas(new DateTime(year, month, day));
            datum.Mennyimeg();
            Console.WriteLine(datum.Mennyimeg());
        }
    }
}
