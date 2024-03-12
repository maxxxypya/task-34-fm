using System;


    sealed class Array2D<T> : BaseArr
    {
        private T[,] arr;
        private IElGen<T> _elementGen;

        public Array2D(bool AvtoInput, IElGen<T> ElementGen)
        {
            _elementGen = ElementGen;
            Create(AvtoInput);
        }

        public override void Create(bool avto_input)
        {
            Console.WriteLine("Введите количество строк в массиве");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве");
            int b = int.Parse(Console.ReadLine());
            Masiv = new int[a, b];
        }

        public override void AvtoInput()
        {
            for (int i = 0; i < Masiv.GetLength(0); i++)
            {
                for (int j = 0; j < Masiv.GetLength(1); j++)
                {
                    Masiv[i, j] = rnd.Next(1, 33);
                }
            }
        }

        public override void SelfInput()
        {
            int count = 1;
            for (int i = 0; i < Masiv.GetLength(0); i++)
            {
                for (int j = 0; j < Masiv.GetLength(1); j++)
                {
                    Console.WriteLine("Введите " + count + "-й элемент массива");
                    Masiv[i, j] = int.Parse(Console.ReadLine());
                    count++;
                }
            }
        }

        public override void WriteArray()
        {
            for (int i = 0; i < Masiv.GetLength(0); i++)
            {
                for (int j = 0; j < Masiv.GetLength(1); j++)
                {
                    Console.Write(Masiv[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }