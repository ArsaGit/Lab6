using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[] { 1, 2 ,3,4,5};
            int[] a2 = new int[] { 1, 2 };
            int[] a3 = new int[] { 1, 3 };


            int[][] aa1 = new int[3][];
            aa1[0] = new int[] { 1, 2, 3 };
            aa1[1] = new int[] { 3, 4, 5 };
            aa1[2] = new int[] { 7, 8, 9 };

            int[][] aa2 = new int[2][];
            aa2[0] = new int[] { 3, 4, 5 };
            aa2[1] = new int[] { 7, 8, 9 };

            ShowResult(IsPartOf(aa1, aa2));

            

        }
        static void ShowResult(bool res)
        {
            if (res) Console.WriteLine("true");
            else Console.WriteLine("false");
        }
        static bool IsPartOf(int[] arrBig,int[] arrSmall)
        {
            int count;
            for(int i=0;i<arrBig.Length-arrSmall.Length+1;i++)
            {
                count = 0;
                for(int j=0;j<arrSmall.Length;j++)
                    if (arrBig[i+j] == arrSmall[j]) count++;
                if (count == arrSmall.Length) return true;
            }
            return false;
        }

        static bool IsPartOf(int[][] arrBig, int[] arrSmall)
        {
            for (int i = 0; i < arrBig.GetUpperBound(0)+1; i++)
                if (IsPartOf(arrBig[i], arrSmall)) return true;
            return false;
        }

        static bool IsPartOf(int[][] arrBig, int[][] arrSmall)
        {
            int count;
            for (int i = 0; i < arrBig.GetUpperBound(0) - arrSmall.GetUpperBound(0)+1; i++)
            {
                count = 0;
                for (int j = 0; j < arrSmall.GetUpperBound(0)+1; j++)
                    if (IsPartOf(arrBig[i + j],arrSmall[j])) count++;
                if (count == arrSmall.GetUpperBound(0)+1) return true;
            }
            return false;
        }
    }
}
