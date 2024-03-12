using System;


    class IntGen : IElGen<int>
    {
        private static Random random = new Random();
        public int GenRandom()
        {
            return random.Next(0, 100);
        }

        public int InputElements()
        {
            int a = int.Parse(Console.ReadLine());
            return a;
        }
    }
