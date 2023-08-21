﻿using System;
using _3_Visszaszamlalas;

namespace VisszaszamlalasFW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int year = Int32.Parse(args[0]);
            int month = Int32.Parse(args[1]);
            int day = Int32.Parse(args[2]);
            Visszaszamlalas datum = new Visszaszamlalas(new DateTime(year, month, day));
            datum.Mennyimeg();
            Console.WriteLine(datum.Mennyimeg());
            Console.ReadKey();
        }
    }
}