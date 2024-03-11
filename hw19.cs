namespace Hw19;

public class Type19
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
        int result = 0;
        for (int i = 0; i < number1; i++)
        {
            result += number2;
        }
        Console.WriteLine(number1 + " x " + number2 + " = " + result);
        
    }
}