using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskArray9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayTask 9");
            var array = new int[10];
            Console.Write("Count position to shift array: ");
            int positionShift = int.Parse(Console.ReadLine());
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
                array[i] = i + 1;
            foreach (int i in array)
                Console.Write(i + " ");
            for (int i = 0; i < positionShift; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                }

            }
            Console.WriteLine();
            foreach (int i in array)
                Console.Write(i + " ");
            Console.ReadKey();
        }
    }
}
