namespace Hw18;

public class Type18
{
    public void Start()
    {
        int number = GetNumber();

        Process(number);
    }

    public int GetNumber()
    {
        Console.WriteLine("Enter the number");
        return Convert.ToInt32(Console.ReadLine());
    }

    public void Process(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("absolute value = " + number);
        }

        else if (number < 0)
        {
            int av = number * -1;
            Console.WriteLine("absolute value = " + av);
        }

        else
        {
            Console.WriteLine(0);
        }
    }
}