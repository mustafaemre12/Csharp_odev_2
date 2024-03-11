namespace Hw9;

public class Type9
{
    public void Start()
    {
        int number1 = Getnumber();
        int number2 = Getnumber();

        Process(number1 , number2);
    }

    public int Getnumber()
    {
        Console.WriteLine("Enter the number ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public void Process(int number1, int number2)
    {
        int count = 1;
        while (count <= number2)
        {
            Console.Write(number1);
            count++;
        }
    }
}