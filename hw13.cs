namespace Hw13;

public class Type13
{
    public void Start()
    {
        int number1 = Getnumber("1");
        int number2 = Getnumber("2");

        Process(number1 , number2);
    }

    public int Getnumber(string numberprefix)
    {
        Console.WriteLine("Enter the number " + numberprefix);
        return Convert.ToInt32(Console.ReadLine());
    }

    public void Process(int number1, int number2)
    {
        int i = 1;
        while (i <= 10)
        {
            Console.WriteLine(number1 + "x" + i + "=" + number1 * i);
            i++;
        }
        int a = 1;
        while (a <= 10)
        {
            Console.WriteLine(number2 + "x" + a + "=" + number2 * a);
            a++;
        }
    }
}