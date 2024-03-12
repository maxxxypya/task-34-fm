using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task34;

namespace ConsoleApp1
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
}
