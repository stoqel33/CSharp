using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    class Sortowanie
    {
        public void EnterData(int[] number)
        {
            Console.WriteLine("Numbers in your array: ");
            for (int i = 0; i < number.Length; i++)
            {
                if(i < number.Length -1)
                    Console.Write(number[i] + ", ");
                else
                    Console.Write(number[i] + ". ");
            }
            Console.WriteLine();
        }

        public void Process(int[] number)
        {
            int temp;

            for (int i = 1; i <= number.Length - 1; i++)
            {
                for (int j = number.Length - 1; j >= i; j--)
                {
                    if (number[j - 1] > number[j])
                    {
                        temp = number[j - 1];
                        number[j - 1] = number[j];
                        number[j] = temp;
                    }
                }
            }

        }

        public void Show(int[] number)
        {
            Console.WriteLine();
            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < number.Length; i++)
            {
                if (i < number.Length - 1)
                    Console.Write(number[i] + ", ");
                else
                    Console.Write(number[i] + ". ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 50, 202, -13, -1200, 0, 33 };

            var bubbleSort  = new Sortowanie();
            bubbleSort.EnterData(arr);
            bubbleSort.Process(arr);
            bubbleSort.Show(arr);
        }
    }
}
