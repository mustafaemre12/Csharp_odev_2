namespace Hw8;

public class Type8
{
    public void Start()
    {
        int number1 = Getnumber("1");
        int number2 = Getnumber("2");
        int number3 = Getnumber("3");
        int number4 = Getnumber("4");
        int number5 = Getnumber("5");

        Process(number1, number2, number3, number4, number5);
    }

    public int Getnumber(string numberprefix)
    {
        Console.WriteLine("Enter the number " + numberprefix);
        return Convert.ToInt32(Console.ReadLine());
    }

    public void Process(int number1, int number2, int number3, int number4, int number5)
    {
        int Sum = number1 + number2 + number3 + number4 + number5;
        int average = Sum / 5;
        int[] numbers = { number1, number2, number3, number4, number5 };
        int enb = numbers[0];
        int enk = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > enb)
            {
                enb = numbers[i];
            }
        }

        for (int i = 0; i > numbers.Length; i++)
        {
            if (numbers[i] < enk)
            {
                enk = numbers[i];
            }
        }
        Console.WriteLine("Sum = " + Sum );
        Console.WriteLine("average = " + average);
        Console.WriteLine("the biggest number is " + enb);
        Console.WriteLine("the smallest number is " + enk);
    }
}