namespace DSAndAlgorithmsProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearch binarySearch = new BinarySearch();
            BubbleSort bubbleSort = new BubbleSort();
            InsertionSort insertionSort = new InsertionSort();
            MergeSort mergeSort = new MergeSort();
            while (true)
            {
                Console.WriteLine("Enter the option : \n1. binarySearch \n2. bubbleSort \n3. InsertionSort \n4. MergeSort");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        binarySearch.Search(@"E:\Git\GitRepository\DSAndAlgorithmsProblem\DSAndAlgorithmsProblem\DSAndAlgorithmsProblem\Words.txt");
                        break;
                    case 2:
                        bubbleSort.Bubble(@"E:\Git\GitRepository\DSAndAlgorithmsProblem\DSAndAlgorithmsProblem\DSAndAlgorithmsProblem\numb.txt");
                        break;
                    case 3:
                        insertionSort.Sort();
                        break;
                    case 4:
                        int n = 8;
                        int[] array = { 49, 3, 53, 21, 27, 75, 50, 41 };
                        Console.WriteLine("Merge Sort");
                        Console.Write("Initial array is: ");
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(array[i] + " ");
                        }
                        mergeSort.Sort(array, 0, n - 1);
                        Console.Write("\nSorted Array is: ");
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(array[i] + " ");
                        }
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("please choose correct options :");
                        break;
                }
            }
        }
    }
}