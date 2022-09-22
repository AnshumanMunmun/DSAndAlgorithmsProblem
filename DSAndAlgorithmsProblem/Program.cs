namespace DSAndAlgorithmsProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearch binarySearch = new BinarySearch();
            BubbleSort bubbleSort = new BubbleSort();
            InsertionSort insertionSort = new InsertionSort();
            while (true)
            {
                Console.WriteLine("Enter the option : \n1. binarySearch \n2. bubbleSort \n3 InsertionSort");
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
                    default:
                        Console.WriteLine("please choose correct options :");
                        break;
                }
            }
        }
    }
}