using System;

namespace FomtasksCsOOPStringAndArrayClasses2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Formtask-1 Addition
            int[] arr = { 52, 32, 34, 54 };
            foreach (var item in CustomSort(arr))
            {
                Console.WriteLine(item);
            }
            #endregion
        }
        //Formtask-1: Insertion sort
        static int[] CustomSort(int[] arr)
        {
            int temp = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
