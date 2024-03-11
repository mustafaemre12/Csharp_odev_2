using System.Diagnostics;

namespace Hw6;

public class Type6
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
        int count = number1;
        while (count <= number2)
        {
            Console.WriteLine(number1);
            number1++;
            count++;
        }
    }
}