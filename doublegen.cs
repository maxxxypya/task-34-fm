using System;
  internal class DoubGen : IElGen<double>
    {
        private static Random _random = new Random();
        public double GenRandom()
        {
            double a = _random.NextDouble();
            return a;
        }

        public double InputElements()
        {
            double doub = Double.Parse(Console.ReadLine());
            return doub;
        }
    }

