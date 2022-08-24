namespace SortAlgorithms
{
    internal class Program
    {
        static int[] QuickSort(int[] arr, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
                return arr;
            int pivotIndex = maxIndex; //Comparison element index.
            int wallIndex = minIndex; //Wall left side is small than "pivot" and right is big.
            int pivot = arr[maxIndex]; //Comparison element.
            for (int i = minIndex; i < maxIndex; i++)
            {
                if (arr[i] <= pivot)
                {
                    if (i != wallIndex)
                    {
                        Swap(ref arr[wallIndex], ref arr[i]);
                    }
                    wallIndex++;
                }
            }
            if (wallIndex != maxIndex) //Puts "pivot" to his place.
            {
                Swap(ref arr[wallIndex], ref arr[maxIndex]);
            }
            QuickSort(arr, minIndex, wallIndex - 1);
            QuickSort(arr, wallIndex + 1, maxIndex);
            return arr;
        }
        static int[] BubleSort(int[] arr, int maxindex)
        {
            if (maxindex <= 0)
                return arr;
            for (int i = 0, j = 1; j <= maxindex; i++, j++)
            {
                if (arr[i] > arr[j])
                {
                    Swap(ref arr[i], ref arr[j]);
                }
            }
            maxindex--;
            BubleSort(arr, maxindex);
            return arr;
        }
        static void Swap(ref int leftItem, ref int rightItem)
        {
            int temp = leftItem;
            leftItem = rightItem;
            rightItem = temp;
        }
        static void Main(string[] args)
        {
            int[] inputArray = new int[10];
            Random random = new Random();
            Console.WriteLine("Your input array.");
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = random.Next(0, 99);
                Console.Write(inputArray[i] + " ");
            }
            Console.WriteLine("\nSorted by Quick Sort.");
            int[] outputArrayQ = QuickSort(inputArray, 0, inputArray.Length - 1);
            for (int i = 0; i < outputArrayQ.Length; i++)
            {
                Console.Write(outputArrayQ[i] + " ");
            }
            int[] outputArrayB = BubleSort(inputArray, inputArray.Length - 1);
            Console.WriteLine("\nSorted by Buble Sort.");
            for (int i = 0; i < outputArrayB.Length; i++)
            {
                Console.Write(outputArrayB[i] + " ");
            }
            Console.WriteLine();
        }
    }
}