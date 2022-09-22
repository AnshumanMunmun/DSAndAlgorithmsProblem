namespace DSAndAlgorithmsProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearch binarySearch = new BinarySearch();
            while (true)
            {
                Console.WriteLine("Enter the option : \n1. binarySearch");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        binarySearch.Search(@"E:\Git\GitRepository\DSAndAlgorithmsProblem\DSAndAlgorithmsProblem\DSAndAlgorithmsProblem\Words.txt");
                        break;
                    default:
                        Console.WriteLine("please choose correct options :");
                        break;
                }
            }
        }
    }
}