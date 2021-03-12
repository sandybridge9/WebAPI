using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class NumberContainer
    {
        public int[] Numbers { get; set; }

        public int[] BubbleSort()
        {
            int[] numberArray = Numbers;
            int temp;
            for (int i = 0; i < numberArray.Length; i++)
            {
                for (int j = 0; j < numberArray.Length - 1; j++)
                {
                    if (numberArray[j] > numberArray[j + 1])
                    {
                        temp = numberArray[j + 1];
                        numberArray[j + 1] = numberArray[j];
                        numberArray[j] = temp;
                    }
                }
            }
            return numberArray;
        }

        public int[] QuickSort()
        {
            int[] numberArray = Numbers;
            QuickSort(numberArray, 0, numberArray.Length - 1);
            return numberArray;
        }

        private void QuickSort(int[] numberArray, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(numberArray, left, right);

                if (pivot > 1)
                {
                    QuickSort(numberArray, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(numberArray, pivot + 1, right);
                }
            }

        }

        private int Partition(int[] numberArray, int left, int right)
        {
            int pivot = numberArray[left];
            while (true)
            {
                while (numberArray[left] < pivot)
                {
                    left++;
                }
                while (numberArray[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (numberArray[left] == numberArray[right]) return right;

                    int temp = numberArray[left];
                    numberArray[left] = numberArray[right];
                    numberArray[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
