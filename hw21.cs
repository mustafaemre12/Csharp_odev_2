namespace Hw21;

public class Type21
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

    public void Process(int number1 , int number2)
    {
        while (number1 >= number2)
        {
            if (number1 % 2 == 1)
            {
                Console.WriteLine(number1);
            }
            number1--;
        }
    }
}