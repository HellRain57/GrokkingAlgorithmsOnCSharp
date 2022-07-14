class Program 
{
    static void Main(string[] args) 
    {
        var inputList = new List<int>();
        inputList = RandList(inputList, 10);

        foreach (var item in inputList)
        {
            Console.Write(item + " | ");
        }
        Console.WriteLine();


        var outputList = selectionSort(inputList);

        Console.WriteLine("Sorted:");
        foreach (var item in outputList)
        {
            Console.Write(item + " | ");
        }
    }


    //================= Рандом массива =================//
    private static new List<int> RandList(List<int> inputList, int numOfElements) 
    {
        for (int i = 0; i < numOfElements; i++) 
        {
            Random rnd = new Random();
            inputList.Add(rnd.Next(0, 9));
        }
        return inputList;
    }
    //==================================================//

    //=============== Сортировка выбором ===============//
    public static new List<int> selectionSort(List<int> inputList)
    {
        var outputList = new List<int>();
        int inputListLenght = inputList.Count;
        for (int i = 0; i < inputListLenght; i++)
        { 
            int smallest = findSmallest(inputList);
            outputList.Add(inputList[smallest]);
            inputList.RemoveAt(smallest);            
        }
        return outputList;
    }
    //==================================================//

    //=============== Поиск минимального ===============//
    private static int findSmallest(List<int> inputList)
    {
        int smallest = inputList[0];
        int smallestIndex = 0;

        for (int i = 0; i < inputList.Count; i++)
        {
            if (inputList[i] < smallest) 
            {
                smallest = inputList[i];
                smallestIndex = i;
            }
        }
        return smallestIndex;
    }
    //==================================================//
}