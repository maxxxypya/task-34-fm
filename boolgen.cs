using System;


    internal class BoolGen : IElGen<bool>
    {
        private static Random random = new Random();
        public bool GenRandom()
        {
            bool a = false;
            int flag = random.Next(0, 2);
            if (flag == 1)
            {
                a = true;
            }
            return a;
        }

        public bool InputElements()
        {
            bool flag = Boolean.Parse(Console.ReadLine());
            return flag;
        }
    }

