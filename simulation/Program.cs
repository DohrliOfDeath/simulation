using System;
using System.Collections.Generic;

namespace simulation
{
    class Program
    {
        private static int TNow { get; set; } = 0;

        private static int NQ { get => Queue.Count; }
        private static int NR { get; set; } = 0;

        public static List<Ereignis> EreignisListe = new();
        public static List<Guest> Queue = new();

        private static int InactiveTime;
        private static int ActiveTime;

        private static Random rnd = new();

        static void Main(string[] args)
        {
            for (var i = 0; i < 1000; i++) Queue.Add(new Guest(i));

            var machine1 = new Resource();
            while (TNow < 1000)
            {
                //gast kommt
                int ai = GetAnkunftsIntervall();
                TNow += ai;
                InactiveTime += ai;
                var isServed = machine1.Process(Queue[0], TNow); //gast ist gekommen
                NR = 1;

                //gast wird bedient
                int bz = GetBedienZeit();
                TNow += bz; 
                ActiveTime += bz;

                //gast geht
                machine1.Geht(isServed, TNow); //gast geht
                NR = 0;
                MakeBreak(5);
            }
            double loadFactor = Math.Round(Convert.ToDouble(ActiveTime) / Convert.ToDouble(ActiveTime + InactiveTime), 2);
            Console.WriteLine("Auslastungsrate: " + loadFactor);
        }

        static void MakeBreak(int s) => InactiveTime += s;
        static int GetBedienZeit() => rnd.Next(5, 10);
        static int GetAnkunftsIntervall() => rnd.Next(5, 10);
    }
}
