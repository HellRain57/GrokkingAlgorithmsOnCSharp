class Program
{
    static void Main(string[] args)
    {
        int[] a = { 1, 3, 5, 7, 9 };
        Console.WriteLine(Convert.ToString(BinarySearch(a, 5)));
    }

    
    //==================== Бинарный поиск ====================//
    static int BinarySearch(int[] inputArray, int searchNumber)
    {
        int low = 0;
        int high = inputArray.Length-1;

        while (low <= high)
        {            
            int mid = (high + low) / 2;
            if (searchNumber < inputArray[mid])
            {
                high = mid-1;
            }
            else
            {
                low = mid+1;
            }

            if (inputArray[mid] == searchNumber)
            {
                return mid;
            }
        }

        return -1;
    }
    //========================================================//
}