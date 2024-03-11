using System.Diagnostics;

namespace Hw24;

public class Type24
{
    public void Start()
    {
        int number1 = GetNumber("1");
        int number2 = GetNumber("2");

        Process(number1 , number2);
    }

    public int GetNumber(string prefix)
    {
        Console.WriteLine("Enter the number" + prefix);
        return Convert.ToInt32(Console.ReadLine());
    }

    public void Process(int number1, int number2)
    {
        int count = 0;
         
        if (number1 > 0)
        {
            count++;
        }

        if (number2 > 0)
        {
            count++;
        }

        Console.WriteLine(count);
    }
}