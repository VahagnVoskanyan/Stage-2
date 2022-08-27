namespace SortAlgorithms
{
    internal class Program
    {
        static int[] QuickSort(int[] arr, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
                return arr;
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
        static int[] BubleSort(int[] arr, int maxIndex)
        {
            if (maxIndex <= 0)
                return arr;
            for (int i = 0; i < maxIndex; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    Swap(ref arr[i], ref arr[i + 1]);
                }
            }
            maxIndex--;
            BubleSort(arr, maxIndex);
            return arr;
        }
        static int[] SelectionSort(int[] arr, int minIndex = 0)
        {
            if (minIndex >= arr.Length - 1)
                return arr;
            int CurrentMinimum = arr[minIndex];
            for (int i = minIndex + 1; i < arr.Length; i++)
            {
                if (arr[i] < CurrentMinimum)
                {
                    CurrentMinimum = arr[i];
                }
                Swap(ref arr[minIndex], ref CurrentMinimum);
            }
            SelectionSort(arr, minIndex + 1);
            return arr;
        }
        static int BinerySearch(int[] arr, int item, int maxIndex, int minIndex = 0)
        {
            int midIndex = (maxIndex + minIndex) / 2;
            if (item == arr[midIndex])
            {
                return midIndex;
            }
            if (minIndex >= maxIndex)
                return -1;
            if (item < arr[midIndex])
            {
                maxIndex = midIndex - 1;
            }
            else
            {
                if (item > arr[midIndex])
                    minIndex = midIndex + 1;
            }
            return BinerySearch(arr, item, maxIndex, minIndex);
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
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("Sorted by Quick Sort.");
            int[] outputArrayQ = QuickSort(inputArray, 0, inputArray.Length - 1);
            for (int i = 0; i < outputArrayQ.Length; i++)
            {
                Console.Write(outputArrayQ[i] + " ");
            }
            int[] outputArrayB = BubleSort(inputArray, inputArray.Length - 1);
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("Sorted by Buble Sort.");
            for (int i = 0; i < outputArrayB.Length; i++)
            {
                Console.Write(outputArrayB[i] + " ");
            }
            int[] outputArrayS = SelectionSort(inputArray);
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("Sorted by Selection Sort.");
            for (int i = 0; i < outputArrayS.Length; i++)
            {
                Console.Write(outputArrayS[i] + " ");
            }
            Console.WriteLine("");

            int index = BinerySearch(inputArray, inputArray[9], inputArray.Length - 1);
            Console.WriteLine("\nSearching item index: " + index);
        }
    }
}