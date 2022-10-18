class Program
{
    static void Main(string[] args)
    {        
        //======================= Факториал =======================//
        Console.WriteLine("Введите число для расчета факториала: ");
        int i = Convert.ToInt32(Console.ReadLine());
        int res = Factorial(i);
        Console.WriteLine("Результат: " + res);
        //=========================================================//

        //======================= Фибоначчм =======================//
        Console.WriteLine("Введите число для расчета n-ого члена Фибоначчи: ");
        i = Convert.ToInt32(Console.ReadLine());
        res = Fibonachchi(i);
        Console.WriteLine("Результат: " + res);
        //=========================================================//
    }

    public static int Factorial(int i)
    {
        if (i == 1) return i;
        else return i * (Factorial(i - 1));
    }

    public static int Fibonachchi(int i)
    {
        if ((i == 1) || (i == 0)) return i;
        else return Fibonachchi(i - 1) + Fibonachchi(i - 2);
    }
}