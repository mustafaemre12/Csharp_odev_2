namespace Hw16;

public class Type16
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
        int count = 0;

        while (number > 0)
        {
            number /= 10;
            count++;
        }
        Console.WriteLine("This number has " + count + " digits");
    }
}