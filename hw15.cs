namespace Hw15;

public class Type15
{
    public void Start()
    {
        int numberx = GetNumber("x");
        int numbery = GetNumber("y");

        WhileProcess(numberx, numbery);

        DoWhileProcess(numberx, numbery);
    }

    public int GetNumber(string prefix)
    {
        Console.WriteLine("Enter the number" + prefix);
        return Convert.ToInt32(Console.ReadLine());
    }

    public void WhileProcess(int numberx, int numbery)
    {
        int count = numberx;
        while (count <= numbery)
        {
            Console.Write(numberx);
            count++;
        }
    }

    public void DoWhileProcess(int numberx, int numbery)
    {
        int Count = numberx;
        do
        {
            Console.Write(numberx);
            Count++;
        } while (Count <= numberx);

    }
}