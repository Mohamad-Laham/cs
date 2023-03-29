//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace pr1
{
    internal class Q_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter 9 numbers: ");
int[] Arr1 = new int[9];
int[] Arr2 = new int[9];
for (int i = 0; i < Arr1.Length; i++)
{
    Arr1[i] = int.Parse(Console.ReadLine());
}

int k = 0, counter = 0;
for (int i = 1; i < Arr1.Length; i++)
{
    int j = 1;
    while (j != Arr1.Length)
    {
        if (j == i && i != Arr1.Length - 1)
        {
            j++;
        }
        if (Arr1[i] == Arr1[j])
        {
            counter++;
        }
        j++;
    }
    if (counter == 0)
    {
        Arr2[k] = Arr1[i];
        k++;
    }
    else
    {
        counter = 0;
    }
}
Console.WriteLine();
foreach (int i in Arr2)
{
    Console.Write($"{i}\t");
}
//        }
//    }
//}
