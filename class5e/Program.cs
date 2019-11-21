using System;

namespace class5e
{
    interface IMexico
    {
        decimal Cost(decimal weight);
    }
    interface IJapan
    {
        decimal Cost(decimal weight);
    }

    class Parcel : IMexico, IJapan
    {
        decimal IJapan.Cost(decimal weight)
        { // Explicitly use IJapan.
            const decimal RATE = 2.54m;
            return weight * RATE;
        }
        decimal IMexico.Cost(decimal weight)
        { // Explicitly use IMexico.
            const decimal RATE = 1.84m;
            return weight * RATE;
        }
    }

    class Program
    {
        public static void Main()
        {
            Parcel parcel = new Parcel(); // Declare Parcel object.
            IJapan toJapan = (IJapan)parcel; // Use IJapan interface.
            IMexico toMexico = (IMexico)parcel; // Use IMexico interface.
            const decimal WEIGHT = 3.89m; // Compare mail costs.

            Console.WriteLine("Mailing to Mexico costs " + toMexico.Cost(WEIGHT).ToString("C"));
            Console.WriteLine("Mailing to Japan costs " + toJapan.Cost(WEIGHT).ToString("C"));

            Console.ReadLine();
        }

    }

}
