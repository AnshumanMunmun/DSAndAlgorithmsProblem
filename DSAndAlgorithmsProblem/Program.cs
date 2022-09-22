namespace DSAndAlgorithmsProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearch binarySearch = new BinarySearch();
            BubbleSort bubbleSort = new BubbleSort();
            while (true)
            {
                Console.WriteLine("Enter the option : \n1. binarySearch \n2. bubbleSort");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        binarySearch.Search(@"E:\Git\GitRepository\DSAndAlgorithmsProblem\DSAndAlgorithmsProblem\DSAndAlgorithmsProblem\Words.txt");
                        break;
                    case 2:
                        bubbleSort.Bubble(@"E:\Git\GitRepository\DSAndAlgorithmsProblem\DSAndAlgorithmsProblem\DSAndAlgorithmsProblem\numb.txt");
                        break;
                    default:
                        Console.WriteLine("please choose correct options :");
                        break;
                }
            }
        }
    }
}