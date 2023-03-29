using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
    internal class Q_3
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[7];
            Console.WriteLine("Enter 7 numbers:");
            for (int index = 0; index < Arr.Length; index++)
            {
                Arr[index] = int.Parse(Console.ReadLine());
            }
            int[,] Arr_2 = new int[6, 3];
            int index1 = 0, index2 = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = i + 1; j < Arr.Length; j++)
                {
                    for (int k = j + 1; k < Arr.Length; k++)
                    {

                        if ((Arr[i] + Arr[j] + Arr[k]) == 0 && i != j && i != j + 1 && j != j + 1)
                        {
                            Arr_2[index1, index2] = Arr[i];
                            Arr_2[index1, index2 + 1] = Arr[j];
                            Arr_2[index1, index2 + 2] = Arr[k];
                            index1++;
                        }
                    }
                }
            }

            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                for (int h = 0; h < 3; h++)
                {
                    Console.Write(Arr_2[i, h] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
