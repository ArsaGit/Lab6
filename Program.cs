using System;
using System.Collections.Generic;
using System.Threading;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            int[] a6 = new int[] { 1, 2, 3, 4, 5 };
            int[] a1 = new int[] { 2, 3 };
            int[] a2 = new int[] { 1, 2, 4 };
            int[] a3 = new int[] { 2, 6 };

            int[,] z = { { 1, 2, 3 }, { 3, 4, 5 }, { 7, 8, 9 }};
            int[,] z1 = { { 3, 4, 5 }, { 7, 8, 9 }};
            int[,] z5 = { { 1, 2, 3 }, { 3, 4, 5 }};
            int[,] z2 = { { 3, 4, 5 } };
            int[] z3 = { 1, 2, 3 };
            int[,] z4 = { { 3, 4, 5 }, { 6,7, 8} };


            ShowResult(IsPartOf(a, a1));
            ShowResult(IsPartOf(a, a2));
            ShowResult(IsPartOf(a, a3));
            ShowResult(IsPartOf(z, z1));
            ShowResult(IsPartOf(z, z2));
            ShowResult(IsPartOf(z, z3));
            ShowResult(IsPartOf(z, z4));


        }
        
        static void ShowResult(bool res)
        {
            if (res) Console.WriteLine("true");
            else Console.WriteLine("false");
        }
        static bool IsPartOf(int[] arrBig, int[] arrSmall)
        {
            int count;
            for (int i = 0; i < arrBig.Length - arrSmall.Length + 1; i++)
            {
                count = 0;
                for (int j = 0; j < arrSmall.Length; j++)
                    if (arrBig[i + j] == arrSmall[j]) count++;
                if (count == arrSmall.Length) return true;
            }
            return false;
        }
        static int[] GetArray1D(int[,] array2D, int index = 0)
        {
            int size = array2D.GetLength(1);
            var array1D = new int[size];
            for (int i = 0; i < size; i++)
                array1D[i] = array2D[index, i];
            return array1D;
        }
        static bool IsPartOf(int[,] arrBig, int[] arrSmall)
        {
            for (int i = 0; i < arrBig.GetLength(0); i++)
            {
                int[] array1 = GetArray1D(arrBig, i);
                if (IsPartOf(array1, arrSmall)) return true;
            }
            return false;
        }
        static bool IsPartOf(int[,] arrBig, int[,] arrSmall)
        {
            int count;
            for (int i = 0; i < arrBig.GetLength(0) - arrSmall.GetLength(0)+1; i++)
            {
                count = 0;
                for (int j = 0; j < arrSmall.GetLength(0); j++)
                {
                    int[] array1 = GetArray1D(arrBig, i + j);
                    int[] array2 = GetArray1D(arrSmall, j);
                    if (IsPartOf(array1, array2)) count++;
                }
                if (count == arrSmall.GetLength(0)) return true;
            }
            return false;
        }
    }
}
