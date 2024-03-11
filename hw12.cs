namespace Hw12;

public class Type12
{
    public void Start()
    {
        int number1 = Getnumber("1");
        int number2 = Getnumber("2");

        Process(number1, number2);
    }

    public int Getnumber(string numberprefix)
    {
        Console.WriteLine("Enter the number " + numberprefix);
        return Convert.ToInt32(Console.ReadLine());
    }

    public void Process(int number1, int number2)
    {
        if (number2 == 0)
        {
            Console.WriteLine("not divide to zero");
        }

        else
        {
            int divide = number1 / number2;
            int mod = number1 % number2;

            Console.WriteLine("Result: " + divide);
            Console.WriteLine("mod: " +  mod);
            Console.WriteLine("Goodbye");
        }
    }
}