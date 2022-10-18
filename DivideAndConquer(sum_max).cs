class Program
{ 
    static int[] inArray = new int[3];

    static int sum = 0;
    static int j   = 0;
    static int max = Int32.MinValue;

    
    static void Main(string[] args)
    {
        //======================= Факториал =======================//
        var rand = new Random();
        for (int i = 0; i <= inArray.Length - 1; i++)
        {
            inArray[i] = rand.Next(9);
            Console.Write(inArray[i]);
            Console.Write("|");
        }
        Console.WriteLine("");  //перенос на новую строку
        j = inArray.Length - 1;
        int res = SumArray(inArray);
        Console.WriteLine("Результат: " + res);

        j = inArray.Length - 1;
        int res1 = MaxElement(inArray);
        Console.WriteLine("Наибольший: " + res1);
        //=========================================================//
    }

    public static int SumArray(int[] inArray)
    {
        if (j == -1) 
        {
            return sum;            
        }
        else
        {
            sum += inArray[j];
            j--;
            return SumArray(inArray);
        }
    }

    public static int MaxElement(int[] inArray)
    {
        if (j == -1)
        {
            return max;
        }
        else
        {
            if (inArray[j] > max) max = inArray[j];
            j--;
            return MaxElement(inArray);
        }
    }

}
