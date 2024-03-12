using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task34
{
    sealed class OneDimentioal<T> : BaseArr
    {
        private T[] Masiv;
        private IElGen<T> _elementGenerator;

        public Masiv1(bool avto_input, IElGen<T> ElementGen)
        {
            _elementGenerator = ElementGen;
            Create(avto_input);
        }

        public override void Create(bool avto_input)
        {
            Console.WriteLine("Введите количество элементов в массиве:");
            int len = int.Parse(Console.ReadLine());
            int[] Masiv = new int[len];
            base.Create(avto_input);
        }

        public override void SelfInput()
        {
            for (int i = 0; i < Masiv.Length; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + "-й элемент массива");
                Masiv[i] = int.Parse(Console.ReadLine());
            }
        }

        public override void AvtoInput()
        {
            for (int i = 0; i < Masiv.Length; i++)
            {
                Masiv[i] = rnd.Next(1, 33);
            }
        }

        public override void WriteArray()
        {
            for (int i = 0; i < Masiv.Length; i++)
            {
                Console.Write(Masiv[i] + " ");
            }
            Console.WriteLine();
        }
    }




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




    abstract class BaseArr : IBaseArr
    {

        public virtual void Create(bool avto_input = false)
        {
            if (avto_input)
            {
                AvtoInput();
            }
            else
            {
                SelfInput();
            }
        }

        public abstract void AvtoInput();

        public abstract void SelfInput();

        public abstract void WriteArray();
    }




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



    class StrGen : IElGen<string>
    {
        private const string alphabet = "abcdefghijklmnopqrstuvwxyz";
        private static Random random = new Random();
        public string GenRandom()
        {
            int length = random.Next(0, 10);
            string a = "";
            for (int i = 0; i < length; i++)
            {
                a += alphabet[random.Next(0, 26)];
            }
            return a;
        }

        public string InputElements()
        {
            string message = Convert.ToString(Console.ReadLine());
            return message;
        }
    }

   

    public interface IBaseArr : IPrinter
    {
        void Create(bool avto_input = false);
    }

    interface IElGen<T>
    {
        T GenRandom();
        T InputElements();
    }


    public interface IPrinter
    {
        void WriteArray();
    }

}
