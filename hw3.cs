using System.Diagnostics;

namespace Hw3;

public class Type3
{
    public void Start()
    {
        int number = Getnumber();

        process(number);
    }

    public int Getnumber()
    {
        Console.WriteLine("Enter a number");
        return Convert.ToInt32(Console.ReadLine());
    }

    public void process(int number)
    {
        if (number > 0) 
        {
            Console.WriteLine("Positive");
        }

        else if (number < 0)
        {
            Console.WriteLine("Negative");
        }

        else if (number == 0)
        {
            Console.WriteLine("neutral");
        }
    }
}