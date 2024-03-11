using System.Diagnostics;

namespace Hw23;

public class Type23
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
        if (number1 > 0 && number2 > 0)
        {
            Console.WriteLine("first and second number is positive");
        }

        else if (number1 > 0)
        {
            Console.WriteLine("first number is positive");
        }

        else if (number2 > 0)
        {
            Console.WriteLine("second number is positive");
        }

        else
        {
            Console.WriteLine("All numbers is negative");
        }
    }
    
}