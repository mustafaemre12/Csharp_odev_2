namespace Hw7;

public class Type7
{
    public void Start()
    {
        do
        {
            int sum = 0;
            int number = Getnumber();
            Process(number , sum);

        } while (Getnumber() != 0);
    }

    public int Getnumber()
    {
        Console.WriteLine("Enter the number ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public void Process(int number, int sum)
    {
        sum = number++;
        Console.WriteLine(sum);

    }
}