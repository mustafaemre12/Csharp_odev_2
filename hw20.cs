namespace Hw20;

public class Type20
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
        int control = 0;
        int i = 2;
        while (i < number)
        {
            if (number % i == 0)
            {
                control++;
            }
            i++;
        }

        if (control != 0)
        {
            Console.WriteLine("this number is not a prime number");
        }

        else
        {
            Console.WriteLine("this number is a prime number");
        }
    }
}