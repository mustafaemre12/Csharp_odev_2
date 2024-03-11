using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hw5;

public class Type5
{
    public void Start()
    {
        do
        {
            int number = GetNumber();
            PrintResult(number);
        } while (GetNumber() != 0);
    }

    public int GetNumber()
    {
        Console.WriteLine("Enter the number");
        return Convert.ToInt32(Console.ReadLine());
    }

    public void PrintResult(int number)
    {
        int result = number * 10;
        Console.WriteLine("Result :" + result);
    }
}