using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    internal static class Merge
    {
        public static void Merging(int[] arr, int left, int mid, int right)
        {
            int[] newArr = new int[arr.Length];
            int q = left;
            int p = mid;
            int k = left;
            while ((q < mid) && (p <= right))
            {
                if (arr[q] < arr[p])
                {
                    newArr[k++] = arr[q++];
                }
                else
                {
                    newArr[k++] = arr[p++];
                }
            }
            while (q < mid)
            {
                newArr[k++] = arr[q++];
            }
            while (p <= right)
            {
                newArr[k++] = arr[p++];
            }
            while (left <= right)
            {
                arr[left] = newArr[left];
                left++;
            }
        }
        public static void MergeSort(int[] arr, int left, int right)
        {
            int mid;
            if (left < right)
            {
                mid = (right + left) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, (mid + 1), right);
                Merging(arr, left, (mid + 1), right);
            }
        }
    }
}
